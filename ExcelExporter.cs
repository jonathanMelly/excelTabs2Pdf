using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelToPdfExporter
{
    public class SheetInfo
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public bool IsVisible { get; set; }

        public SheetInfo(string name, int index, bool isVisible)
        {
            Name = name;
            Index = index;
            IsVisible = isVisible;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class ExcelExporter
    {
        private Excel.Application? excelApp;
        private Excel.Workbook? workbook;

        public event EventHandler<string>? StatusChanged;
        public event EventHandler<int>? ProgressChanged;

        public string? WorkbookPath { get; private set; }
        public string WorkbookName { get; private set; } = string.Empty;

        public List<SheetInfo> GetSheets(string filePath)
        {
            List<SheetInfo> sheets = new List<SheetInfo>();

            try
            {
                if (excelApp == null)
                {
                    excelApp = new Excel.Application();
                    excelApp.Visible = false;
                    excelApp.DisplayAlerts = false;
                }

                // Fermer le classeur précédent si ouvert
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                    workbook = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

                WorkbookPath = filePath;
                WorkbookName = Path.GetFileNameWithoutExtension(filePath);

                workbook = excelApp.Workbooks.Open(filePath, ReadOnly: true);

                int index = 1;
                foreach (Excel.Worksheet worksheet in workbook.Worksheets)
                {
                    bool isVisible = worksheet.Visible == Excel.XlSheetVisibility.xlSheetVisible;
                    sheets.Add(new SheetInfo(worksheet.Name, index, isVisible));
                    Marshal.ReleaseComObject(worksheet);
                    index++;
                }

                StatusChanged?.Invoke(this, $"{sheets.Count} feuille(s) trouvée(s)");
            }
            catch (Exception ex)
            {
                StatusChanged?.Invoke(this, $"Erreur: {ex.Message}");
                throw;
            }

            return sheets;
        }

       

        public void ExportSheetToPdf(SheetInfo sheetInfo, string outputPath)
        {
            if (workbook == null)
                throw new InvalidOperationException("Aucun classeur ouvert");

            Excel.Worksheet? worksheet = null;

            try
            {
                worksheet = (Excel.Worksheet)workbook.Worksheets[sheetInfo.Index];

                StatusChanged?.Invoke(this, $"Export de '{sheetInfo.Name}'...");

                worksheet.ExportAsFixedFormat(
                    Type: Excel.XlFixedFormatType.xlTypePDF,
                    Filename: outputPath,
                    Quality: Excel.XlFixedFormatQuality.xlQualityStandard,
                    IncludeDocProperties: true,
                    IgnorePrintAreas: false,
                    OpenAfterPublish: false
                );

                StatusChanged?.Invoke(this, $"'{sheetInfo.Name}' exporté avec succès");
            }
            catch (Exception ex)
            {
                StatusChanged?.Invoke(this, $"Erreur pour '{sheetInfo.Name}': {ex.Message}");
                throw;
            }
            finally
            {
                if (worksheet != null)
                    Marshal.ReleaseComObject(worksheet);
            }
        }

        public void ExportMultipleSheets(List<SheetInfo> sheets, string outputDirectory, string fileNamePattern)
        {
            if (workbook == null)
                throw new InvalidOperationException("Aucun classeur ouvert");

            int totalSheets = sheets.Count;
            int currentSheet = 0;

            foreach (var sheetInfo in sheets)
            {
                try
                {
                    string fileName = fileNamePattern
                        .Replace("{workbook}", WorkbookName)
                        .Replace("{sheet}", CleanFileName(sheetInfo.Name));

                    if (!fileName.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                        fileName += ".pdf";

                    string fullPath = Path.Combine(outputDirectory, fileName);

                    ExportSheetToPdf(sheetInfo, fullPath);

                    currentSheet++;
                    int progress = (int)((currentSheet / (float)totalSheets) * 100);
                    ProgressChanged?.Invoke(this, progress);
                }
                catch (Exception ex)
                {
                    StatusChanged?.Invoke(this, $"Erreur: {ex.Message}");
                }
            }
        }

        private string CleanFileName(string fileName)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();
            foreach (char c in invalidChars)
            {
                fileName = fileName.Replace(c, '_');
            }
            return fileName;
        }

        public void Close()
        {
            try
            {
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                    workbook = null;
                }

                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception ex)
            {
                StatusChanged?.Invoke(this, $"Erreur lors de la fermeture: {ex.Message}");
            }
        }

        ~ExcelExporter()
        {
            Close();
        }
    }
}
