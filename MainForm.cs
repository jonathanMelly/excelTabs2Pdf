using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExcelToPdfExporter
{
    public partial class MainForm : Form
    {
        private ExcelExporter exporter;
        private List<SheetInfo> allSheets;

        public MainForm()
        {
            InitializeComponent();
            exporter = new ExcelExporter();
            exporter.StatusChanged += Exporter_StatusChanged;
            exporter.ProgressChanged += Exporter_ProgressChanged;
            allSheets = new List<SheetInfo>();

            // Initialiser le pattern par défaut
            txtFileNamePattern.Text = "{workbook}-{sheet}";
            
            // Détecter les fichiers Excel ouverts au démarrage
            RefreshOpenExcelFiles();
        }
        
        private void RefreshOpenExcelFiles()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                lstOpenFiles.Items.Clear();
                
                var openFiles = ExcelInstanceDetector.GetOpenExcelFiles();
                
                if (openFiles.Count == 0)
                {
                    lstOpenFiles.Items.Add("(Aucun fichier Excel ouvert détecté)");
                    lstOpenFiles.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    lstOpenFiles.ForeColor = System.Drawing.SystemColors.WindowText;
                    foreach (var file in openFiles)
                    {
                        lstOpenFiles.Items.Add(file);
                    }
                }
                
                lblOpenFilesCount.Text = $"{openFiles.Count} fichier(s) ouvert(s)";
            }
            catch (Exception ex)
            {
                lstOpenFiles.Items.Clear();
                lstOpenFiles.Items.Add($"(Erreur: {ex.Message})");
                lstOpenFiles.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        
        private void btnRefreshOpenFiles_Click(object sender, EventArgs e)
        {
            RefreshOpenExcelFiles();
        }
        
        private void lstOpenFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstOpenFiles.SelectedItem is OpenExcelFile selectedFile)
            {
                txtExcelPath.Text = selectedFile.FilePath;
                LoadSheets(selectedFile.FilePath);
                
                // Passer à l'onglet suivant
                tabControl.SelectedIndex = 1;
            }
        }

        private void Exporter_StatusChanged(object? sender, string status)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Exporter_StatusChanged(sender, status)));
                return;
            }

            lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] {status}");
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }

        private void Exporter_ProgressChanged(object? sender, int progress)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Exporter_ProgressChanged(sender, progress)));
                return;
            }

            progressBar.Value = Math.Min(progress, 100);
        }

        private void btnBrowseExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Fichiers Excel|*.xlsx;*.xls;*.xlsm|Tous les fichiers|*.*";
                dlg.Title = "Sélectionner un fichier Excel";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtExcelPath.Text = dlg.FileName;
                    LoadSheets(dlg.FileName);
                }
            }
        }

        private void LoadSheets(string filePath)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                lstSheets.Items.Clear();
                lstLog.Items.Clear();

                allSheets = exporter.GetSheets(filePath);

                foreach (var sheet in allSheets)
                {
                    lstSheets.Items.Add(sheet, sheet.IsVisible);
                }

                lblSheetCount.Text = $"{allSheets.Count} feuille(s)";
                btnExport.Enabled = allSheets.Count > 0;

                txtOutputPath.Text = Path.GetDirectoryName(OneDrivePathConverter.ConvertUrlToLocalPath(filePath));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement du fichier:\n{ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Sélectionner le dossier de sortie";
                dlg.ShowNewFolderButton = true;

                if (!string.IsNullOrEmpty(txtExcelPath.Text))
                {
                    dlg.InitialDirectory = Path.GetDirectoryName(OneDrivePathConverter.ConvertUrlToLocalPath(txtExcelPath.Text));
                    //dlg.SelectedPath = ;
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtOutputPath.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSheets.Items.Count; i++)
            {
                lstSheets.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSheets.Items.Count; i++)
            {
                lstSheets.SetItemChecked(i, false);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrEmpty(txtExcelPath.Text))
            {
                MessageBox.Show("Veuillez sélectionner un fichier Excel.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstSheets.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins une feuille à exporter.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string outputPath = txtOutputPath.Text;
            if (string.IsNullOrEmpty(outputPath))
            {
                // Utiliser le même dossier que le fichier Excel
                outputPath = Path.GetDirectoryName(txtExcelPath.Text) ?? "";
                txtOutputPath.Text = outputPath;
            }

            if (!Directory.Exists(outputPath))
            {
                MessageBox.Show("Le dossier de sortie n'existe pas.", 
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer les feuilles sélectionnées
            List<SheetInfo> selectedSheets = new List<SheetInfo>();
            foreach (SheetInfo sheet in lstSheets.CheckedItems)
            {
                selectedSheets.Add(sheet);
            }

            // Export
            try
            {
                lstLog.Items.Clear();
                progressBar.Value = 0;
                btnExport.Enabled = false;
                Cursor = Cursors.WaitCursor;

                exporter.ExportMultipleSheets(selectedSheets, outputPath, txtFileNamePattern.Text);

                MessageBox.Show($"{selectedSheets.Count} feuille(s) exportée(s) avec succès!", 
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'export:\n{ex.Message}", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExport.Enabled = true;
                Cursor = Cursors.Default;
                progressBar.Value = 100;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            exporter.Close();
        }

        private void lstSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSheets.SelectedItem is SheetInfo sheet)
            {
                // Prévisualiser le nom de fichier
                string preview = txtFileNamePattern.Text
                    .Replace("{workbook}", exporter.WorkbookName)
                    .Replace("{sheet}", sheet.Name);

                if (!preview.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                    preview += ".pdf";

                lblPreview.Text = $"Aperçu: {preview}";
            }
        }

        private void txtFileNamePattern_TextChanged(object sender, EventArgs e)
        {
            // Mettre à jour l'aperçu
            if (lstSheets.SelectedItem is SheetInfo sheet)
            {
                lstSheets_SelectedIndexChanged(sender, e);
            }
        }
    }
}
