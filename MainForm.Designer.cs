namespace ExcelToPdfExporter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOpenFiles = new System.Windows.Forms.TabPage();
            this.grpOpenFiles = new System.Windows.Forms.GroupBox();
            this.lblOpenFilesHelp = new System.Windows.Forms.Label();
            this.lblOpenFilesCount = new System.Windows.Forms.Label();
            this.btnRefreshOpenFiles = new System.Windows.Forms.Button();
            this.lstOpenFiles = new System.Windows.Forms.ListBox();
            this.tabBrowseFile = new System.Windows.Forms.TabPage();
            this.grpExcelFile = new System.Windows.Forms.GroupBox();
            this.btnBrowseExcel = new System.Windows.Forms.Button();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.lblExcelPath = new System.Windows.Forms.Label();
            this.grpSheets = new System.Windows.Forms.GroupBox();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lblSheetCount = new System.Windows.Forms.Label();
            this.lstSheets = new System.Windows.Forms.CheckedListBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.txtFileNamePattern = new System.Windows.Forms.TextBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.lblPatternHelp = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabOpenFiles.SuspendLayout();
            this.grpOpenFiles.SuspendLayout();
            this.tabBrowseFile.SuspendLayout();
            this.grpExcelFile.SuspendLayout();
            this.grpSheets.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOpenFiles);
            this.tabControl.Controls.Add(this.tabBrowseFile);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 180);
            this.tabControl.TabIndex = 0;
            // 
            // tabOpenFiles
            // 
            this.tabOpenFiles.Controls.Add(this.grpOpenFiles);
            this.tabOpenFiles.Location = new System.Drawing.Point(4, 24);
            this.tabOpenFiles.Name = "tabOpenFiles";
            this.tabOpenFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpenFiles.Size = new System.Drawing.Size(752, 152);
            this.tabOpenFiles.TabIndex = 0;
            this.tabOpenFiles.Text = "📂 Fichiers ouverts";
            this.tabOpenFiles.UseVisualStyleBackColor = true;
            // 
            // grpOpenFiles
            // 
            this.grpOpenFiles.Controls.Add(this.lblOpenFilesHelp);
            this.grpOpenFiles.Controls.Add(this.lblOpenFilesCount);
            this.grpOpenFiles.Controls.Add(this.btnRefreshOpenFiles);
            this.grpOpenFiles.Controls.Add(this.lstOpenFiles);
            this.grpOpenFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOpenFiles.Location = new System.Drawing.Point(3, 3);
            this.grpOpenFiles.Name = "grpOpenFiles";
            this.grpOpenFiles.Size = new System.Drawing.Size(746, 146);
            this.grpOpenFiles.TabIndex = 0;
            this.grpOpenFiles.TabStop = false;
            this.grpOpenFiles.Text = "Fichiers Excel actuellement ouverts";
            // 
            // lblOpenFilesHelp
            // 
            this.lblOpenFilesHelp.AutoSize = true;
            this.lblOpenFilesHelp.ForeColor = System.Drawing.Color.Gray;
            this.lblOpenFilesHelp.Location = new System.Drawing.Point(15, 120);
            this.lblOpenFilesHelp.Name = "lblOpenFilesHelp";
            this.lblOpenFilesHelp.Size = new System.Drawing.Size(250, 15);
            this.lblOpenFilesHelp.TabIndex = 3;
            this.lblOpenFilesHelp.Text = "💡 Double-cliquez pour sélectionner un fichier";
            // 
            // lblOpenFilesCount
            // 
            this.lblOpenFilesCount.AutoSize = true;
            this.lblOpenFilesCount.Location = new System.Drawing.Point(630, 120);
            this.lblOpenFilesCount.Name = "lblOpenFilesCount";
            this.lblOpenFilesCount.Size = new System.Drawing.Size(100, 15);
            this.lblOpenFilesCount.TabIndex = 2;
            this.lblOpenFilesCount.Text = "0 fichier(s) ouvert(s)";
            // 
            // btnRefreshOpenFiles
            // 
            this.btnRefreshOpenFiles.Location = new System.Drawing.Point(640, 25);
            this.btnRefreshOpenFiles.Name = "btnRefreshOpenFiles";
            this.btnRefreshOpenFiles.Size = new System.Drawing.Size(90, 80);
            this.btnRefreshOpenFiles.TabIndex = 1;
            this.btnRefreshOpenFiles.Text = "🔄\r\nRafraîchir";
            this.btnRefreshOpenFiles.UseVisualStyleBackColor = true;
            this.btnRefreshOpenFiles.Click += new System.EventHandler(this.btnRefreshOpenFiles_Click);
            // 
            // lstOpenFiles
            // 
            this.lstOpenFiles.FormattingEnabled = true;
            this.lstOpenFiles.ItemHeight = 15;
            this.lstOpenFiles.Location = new System.Drawing.Point(15, 25);
            this.lstOpenFiles.Name = "lstOpenFiles";
            this.lstOpenFiles.Size = new System.Drawing.Size(615, 79);
            this.lstOpenFiles.TabIndex = 0;
            this.lstOpenFiles.DoubleClick += new System.EventHandler(this.lstOpenFiles_DoubleClick);
            // 
            // tabBrowseFile
            // 
            this.tabBrowseFile.Controls.Add(this.grpExcelFile);
            this.tabBrowseFile.Location = new System.Drawing.Point(4, 24);
            this.tabBrowseFile.Name = "tabBrowseFile";
            this.tabBrowseFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowseFile.Size = new System.Drawing.Size(752, 152);
            this.tabBrowseFile.TabIndex = 1;
            this.tabBrowseFile.Text = "📁 Parcourir";
            this.tabBrowseFile.UseVisualStyleBackColor = true;
            // 
            // grpExcelFile
            // 
            this.grpExcelFile.Controls.Add(this.btnBrowseExcel);
            this.grpExcelFile.Controls.Add(this.txtExcelPath);
            this.grpExcelFile.Controls.Add(this.lblExcelPath);
            this.grpExcelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpExcelFile.Location = new System.Drawing.Point(3, 3);
            this.grpExcelFile.Name = "grpExcelFile";
            this.grpExcelFile.Size = new System.Drawing.Size(746, 146);
            this.grpExcelFile.TabIndex = 0;
            this.grpExcelFile.TabStop = false;
            this.grpExcelFile.Text = "Sélectionner un fichier Excel";
            // 
            // btnBrowseExcel
            // 
            this.btnBrowseExcel.Location = new System.Drawing.Point(640, 60);
            this.btnBrowseExcel.Name = "btnBrowseExcel";
            this.btnBrowseExcel.Size = new System.Drawing.Size(90, 27);
            this.btnBrowseExcel.TabIndex = 2;
            this.btnBrowseExcel.Text = "Parcourir...";
            this.btnBrowseExcel.UseVisualStyleBackColor = true;
            this.btnBrowseExcel.Click += new System.EventHandler(this.btnBrowseExcel_Click);
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(110, 62);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.ReadOnly = true;
            this.txtExcelPath.Size = new System.Drawing.Size(520, 23);
            this.txtExcelPath.TabIndex = 1;
            // 
            // lblExcelPath
            // 
            this.lblExcelPath.AutoSize = true;
            this.lblExcelPath.Location = new System.Drawing.Point(15, 65);
            this.lblExcelPath.Name = "lblExcelPath";
            this.lblExcelPath.Size = new System.Drawing.Size(89, 15);
            this.lblExcelPath.TabIndex = 0;
            this.lblExcelPath.Text = "Fichier Excel:";
            // 
            // grpSheets
            // 
            this.grpSheets.Controls.Add(this.btnDeselectAll);
            this.grpSheets.Controls.Add(this.btnSelectAll);
            this.grpSheets.Controls.Add(this.lblSheetCount);
            this.grpSheets.Controls.Add(this.lstSheets);
            this.grpSheets.Location = new System.Drawing.Point(12, 198);
            this.grpSheets.Name = "grpSheets";
            this.grpSheets.Size = new System.Drawing.Size(760, 200);
            this.grpSheets.TabIndex = 1;
            this.grpSheets.TabStop = false;
            this.grpSheets.Text = "2. Sélectionner les feuilles";
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Location = new System.Drawing.Point(118, 165);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(100, 27);
            this.btnDeselectAll.TabIndex = 3;
            this.btnDeselectAll.Text = "Tout désélectionner";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(12, 165);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(100, 27);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "Tout sélectionner";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lblSheetCount
            // 
            this.lblSheetCount.AutoSize = true;
            this.lblSheetCount.Location = new System.Drawing.Point(656, 170);
            this.lblSheetCount.Name = "lblSheetCount";
            this.lblSheetCount.Size = new System.Drawing.Size(81, 15);
            this.lblSheetCount.TabIndex = 1;
            this.lblSheetCount.Text = "0 feuille(s)";
            // 
            // lstSheets
            // 
            this.lstSheets.CheckOnClick = true;
            this.lstSheets.FormattingEnabled = true;
            this.lstSheets.Location = new System.Drawing.Point(12, 25);
            this.lstSheets.Name = "lstSheets";
            this.lstSheets.Size = new System.Drawing.Size(734, 130);
            this.lstSheets.TabIndex = 0;
            this.lstSheets.SelectedIndexChanged += new System.EventHandler(this.lstSheets_SelectedIndexChanged);
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblPreview);
            this.grpOutput.Controls.Add(this.txtFileNamePattern);
            this.grpOutput.Controls.Add(this.lblPattern);
            this.grpOutput.Controls.Add(this.lblPatternHelp);
            this.grpOutput.Controls.Add(this.btnBrowseOutput);
            this.grpOutput.Controls.Add(this.txtOutputPath);
            this.grpOutput.Controls.Add(this.lblOutputPath);
            this.grpOutput.Location = new System.Drawing.Point(12, 404);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(760, 135);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "3. Paramètres d\'export";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.ForeColor = System.Drawing.Color.Blue;
            this.lblPreview.Location = new System.Drawing.Point(110, 110);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(150, 15);
            this.lblPreview.TabIndex = 6;
            this.lblPreview.Text = "Aperçu: fichier-feuille.pdf";
            // 
            // txtFileNamePattern
            // 
            this.txtFileNamePattern.Location = new System.Drawing.Point(110, 75);
            this.txtFileNamePattern.Name = "txtFileNamePattern";
            this.txtFileNamePattern.Size = new System.Drawing.Size(540, 23);
            this.txtFileNamePattern.TabIndex = 5;
            this.txtFileNamePattern.TextChanged += new System.EventHandler(this.txtFileNamePattern_TextChanged);
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(15, 78);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(85, 15);
            this.lblPattern.TabIndex = 4;
            this.lblPattern.Text = "Nom de fichier:";
            // 
            // lblPatternHelp
            // 
            this.lblPatternHelp.AutoSize = true;
            this.lblPatternHelp.ForeColor = System.Drawing.Color.Gray;
            this.lblPatternHelp.Location = new System.Drawing.Point(656, 78);
            this.lblPatternHelp.Name = "lblPatternHelp";
            this.lblPatternHelp.Size = new System.Drawing.Size(85, 15);
            this.lblPatternHelp.TabIndex = 3;
            this.lblPatternHelp.Text = "{workbook} {sheet}";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(656, 36);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(90, 27);
            this.btnBrowseOutput.TabIndex = 2;
            this.btnBrowseOutput.Text = "Parcourir...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(110, 38);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(540, 23);
            this.txtOutputPath.TabIndex = 1;
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Location = new System.Drawing.Point(15, 41);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(89, 15);
            this.lblOutputPath.TabIndex = 0;
            this.lblOutputPath.Text = "Dossier sortie:";
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.lstLog);
            this.grpLog.Location = new System.Drawing.Point(12, 545);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(760, 120);
            this.grpLog.TabIndex = 3;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Journal";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(12, 22);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(734, 84);
            this.lstLog.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 671);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(650, 23);
            this.progressBar.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.Location = new System.Drawing.Point(668, 671);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 36);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpSheets);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel to PDF Exporter - Par votre enseignant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabOpenFiles.ResumeLayout(false);
            this.grpOpenFiles.ResumeLayout(false);
            this.grpOpenFiles.PerformLayout();
            this.tabBrowseFile.ResumeLayout(false);
            this.grpExcelFile.ResumeLayout(false);
            this.grpExcelFile.PerformLayout();
            this.grpSheets.ResumeLayout(false);
            this.grpSheets.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabOpenFiles;
        private System.Windows.Forms.TabPage tabBrowseFile;
        private System.Windows.Forms.GroupBox grpOpenFiles;
        private System.Windows.Forms.ListBox lstOpenFiles;
        private System.Windows.Forms.Button btnRefreshOpenFiles;
        private System.Windows.Forms.Label lblOpenFilesCount;
        private System.Windows.Forms.Label lblOpenFilesHelp;
        private System.Windows.Forms.GroupBox grpExcelFile;
        private System.Windows.Forms.Button btnBrowseExcel;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Label lblExcelPath;
        private System.Windows.Forms.GroupBox grpSheets;
        private System.Windows.Forms.CheckedListBox lstSheets;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblSheetCount;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.TextBox txtFileNamePattern;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label lblPatternHelp;
        private System.Windows.Forms.Label lblPreview;
    }
}
