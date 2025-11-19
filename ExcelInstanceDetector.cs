using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelToPdfExporter
{
    public class OpenExcelFile
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public bool IsReadOnly { get; set; }
        public int SheetCount { get; set; }

        public OpenExcelFile(string filePath, string fileName, bool isReadOnly, int sheetCount)
        {
            FilePath = filePath;
            FileName = fileName;
            IsReadOnly = isReadOnly;
            SheetCount = sheetCount;
        }

        public override string ToString()
        {
            string readOnlyText = IsReadOnly ? " [Lecture seule]" : "";
            return $"{FileName} ({SheetCount} feuille(s)){readOnlyText}";
        }
    }

    public class ExcelInstanceDetector
    {
        [DllImport("ole32.dll")]
        private static extern int GetRunningObjectTable(int reserved, out IRunningObjectTable prot);

        [DllImport("ole32.dll")]
        private static extern int CreateBindCtx(int reserved, out IBindCtx ppbc);

        public static List<OpenExcelFile> GetOpenExcelFiles()
        {
            List<OpenExcelFile> openFiles = new List<OpenExcelFile>();

            try
            {
                openFiles = GetFilesFromROT();

            }
            catch (Exception)
            {
                // Retourner une liste vide en cas d'échec
            }

            return openFiles;
        }


        private static List<OpenExcelFile> GetFilesFromROT()
        {
            List<OpenExcelFile> files = new List<OpenExcelFile>();

            IRunningObjectTable rot;
            IEnumMoniker enumMoniker;
            int retVal = GetRunningObjectTable(0, out rot);

            if (retVal == 0)
            {
                rot.EnumRunning(out enumMoniker);
                enumMoniker.Reset();

                try
                {
                    IMoniker[] monikers = new IMoniker[1];
                    IntPtr fetched = IntPtr.Zero;

                    while (enumMoniker.Next(1, monikers, fetched) == 0)
                    {
                        IBindCtx bindCtx;
                        CreateBindCtx(0, out bindCtx);
                        string displayName;
                        monikers[0].GetDisplayName(bindCtx, null, out displayName);

                        try
                        {
                            if (displayName.Contains(".xl") && !displayName.StartsWith("!"))
                            {
                                try
                                {
                                    object obj;
                                    rot.GetObject(monikers[0], out obj);

                                    if (obj is Excel.Workbook workbook)
                                    {
                                        string path = OneDrivePathConverter.ConvertUrlToLocalPath(workbook.FullName);
                                        string name = workbook.Name;
                                        bool isReadOnly = workbook.ReadOnly;
                                        int sheetCount = workbook.Worksheets.Count;

                                        files.Add(new OpenExcelFile(path, name, isReadOnly, sheetCount));

                                        Marshal.ReleaseComObject(workbook);
                                    }
                                }
                                catch
                                {
                                    // Ignorer les erreurs pour ce fichier
                                }
                            }
                        }
                        finally
                        {
                            Marshal.ReleaseComObject(bindCtx);
                            Marshal.ReleaseComObject(monikers[0]);
                        }



                    }
                }
                finally
                {
                    Marshal.ReleaseComObject(enumMoniker);
                    Marshal.ReleaseComObject(rot);
                }


            }

            return files;
        }

    }
}
