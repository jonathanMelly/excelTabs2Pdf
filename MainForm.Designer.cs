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
            tabControl = new System.Windows.Forms.TabControl();
            tabOpenFiles = new System.Windows.Forms.TabPage();
            grpOpenFiles = new System.Windows.Forms.GroupBox();
            lblOpenFilesHelp = new System.Windows.Forms.Label();
            lblOpenFilesCount = new System.Windows.Forms.Label();
            btnRefreshOpenFiles = new System.Windows.Forms.Button();
            lstOpenFiles = new System.Windows.Forms.ListBox();
            tabBrowseFile = new System.Windows.Forms.TabPage();
            grpExcelFile = new System.Windows.Forms.GroupBox();
            btnBrowseExcel = new System.Windows.Forms.Button();
            txtExcelPath = new System.Windows.Forms.TextBox();
            lblExcelPath = new System.Windows.Forms.Label();
            grpSheets = new System.Windows.Forms.GroupBox();
            btnDeselectAll = new System.Windows.Forms.Button();
            btnSelectAll = new System.Windows.Forms.Button();
            lblSheetCount = new System.Windows.Forms.Label();
            lstSheets = new System.Windows.Forms.CheckedListBox();
            grpOutput = new System.Windows.Forms.GroupBox();
            lblPreview = new System.Windows.Forms.Label();
            txtFileNamePattern = new System.Windows.Forms.TextBox();
            lblPattern = new System.Windows.Forms.Label();
            lblPatternHelp = new System.Windows.Forms.Label();
            btnBrowseOutput = new System.Windows.Forms.Button();
            txtOutputPath = new System.Windows.Forms.TextBox();
            lblOutputPath = new System.Windows.Forms.Label();
            grpLog = new System.Windows.Forms.GroupBox();
            lstLog = new System.Windows.Forms.ListBox();
            progressBar = new System.Windows.Forms.ProgressBar();
            btnExport = new System.Windows.Forms.Button();
            tabControl.SuspendLayout();
            tabOpenFiles.SuspendLayout();
            grpOpenFiles.SuspendLayout();
            tabBrowseFile.SuspendLayout();
            grpExcelFile.SuspendLayout();
            grpSheets.SuspendLayout();
            grpOutput.SuspendLayout();
            grpLog.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOpenFiles);
            tabControl.Controls.Add(tabBrowseFile);
            tabControl.Location = new System.Drawing.Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(760, 180);
            tabControl.TabIndex = 0;
            // 
            // tabOpenFiles
            // 
            tabOpenFiles.Controls.Add(grpOpenFiles);
            tabOpenFiles.Location = new System.Drawing.Point(4, 24);
            tabOpenFiles.Name = "tabOpenFiles";
            tabOpenFiles.Padding = new System.Windows.Forms.Padding(3);
            tabOpenFiles.Size = new System.Drawing.Size(752, 152);
            tabOpenFiles.TabIndex = 0;
            tabOpenFiles.Text = "📂 Fichiers ouverts";
            tabOpenFiles.UseVisualStyleBackColor = true;
            // 
            // grpOpenFiles
            // 
            grpOpenFiles.Controls.Add(lblOpenFilesHelp);
            grpOpenFiles.Controls.Add(lblOpenFilesCount);
            grpOpenFiles.Controls.Add(btnRefreshOpenFiles);
            grpOpenFiles.Controls.Add(lstOpenFiles);
            grpOpenFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            grpOpenFiles.Location = new System.Drawing.Point(3, 3);
            grpOpenFiles.Name = "grpOpenFiles";
            grpOpenFiles.Size = new System.Drawing.Size(746, 146);
            grpOpenFiles.TabIndex = 0;
            grpOpenFiles.TabStop = false;
            grpOpenFiles.Text = "Fichiers Excel actuellement ouverts";
            // 
            // lblOpenFilesHelp
            // 
            lblOpenFilesHelp.AutoSize = true;
            lblOpenFilesHelp.ForeColor = System.Drawing.Color.Gray;
            lblOpenFilesHelp.Location = new System.Drawing.Point(15, 120);
            lblOpenFilesHelp.Name = "lblOpenFilesHelp";
            lblOpenFilesHelp.Size = new System.Drawing.Size(247, 15);
            lblOpenFilesHelp.TabIndex = 3;
            lblOpenFilesHelp.Text = "💡 Double-cliquez pour sélectionner un fichier";
            // 
            // lblOpenFilesCount
            // 
            lblOpenFilesCount.AutoSize = true;
            lblOpenFilesCount.Location = new System.Drawing.Point(630, 120);
            lblOpenFilesCount.Name = "lblOpenFilesCount";
            lblOpenFilesCount.Size = new System.Drawing.Size(112, 15);
            lblOpenFilesCount.TabIndex = 2;
            lblOpenFilesCount.Text = "0 fichier(s) ouvert(s)";
            // 
            // btnRefreshOpenFiles
            // 
            btnRefreshOpenFiles.Location = new System.Drawing.Point(640, 25);
            btnRefreshOpenFiles.Name = "btnRefreshOpenFiles";
            btnRefreshOpenFiles.Size = new System.Drawing.Size(90, 80);
            btnRefreshOpenFiles.TabIndex = 1;
            btnRefreshOpenFiles.Text = "🔄\r\nRafraîchir";
            btnRefreshOpenFiles.UseVisualStyleBackColor = true;
            btnRefreshOpenFiles.Click += btnRefreshOpenFiles_Click;
            // 
            // lstOpenFiles
            // 
            lstOpenFiles.FormattingEnabled = true;
            lstOpenFiles.ItemHeight = 15;
            lstOpenFiles.Location = new System.Drawing.Point(15, 25);
            lstOpenFiles.Name = "lstOpenFiles";
            lstOpenFiles.Size = new System.Drawing.Size(615, 79);
            lstOpenFiles.TabIndex = 0;
            lstOpenFiles.DoubleClick += lstOpenFiles_DoubleClick;
            // 
            // tabBrowseFile
            // 
            tabBrowseFile.Controls.Add(grpExcelFile);
            tabBrowseFile.Location = new System.Drawing.Point(4, 24);
            tabBrowseFile.Name = "tabBrowseFile";
            tabBrowseFile.Padding = new System.Windows.Forms.Padding(3);
            tabBrowseFile.Size = new System.Drawing.Size(752, 152);
            tabBrowseFile.TabIndex = 1;
            tabBrowseFile.Text = "📁 Parcourir";
            tabBrowseFile.UseVisualStyleBackColor = true;
            // 
            // grpExcelFile
            // 
            grpExcelFile.Controls.Add(btnBrowseExcel);
            grpExcelFile.Controls.Add(txtExcelPath);
            grpExcelFile.Controls.Add(lblExcelPath);
            grpExcelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            grpExcelFile.Location = new System.Drawing.Point(3, 3);
            grpExcelFile.Name = "grpExcelFile";
            grpExcelFile.Size = new System.Drawing.Size(746, 146);
            grpExcelFile.TabIndex = 0;
            grpExcelFile.TabStop = false;
            grpExcelFile.Text = "Sélectionner un fichier Excel";
            // 
            // btnBrowseExcel
            // 
            btnBrowseExcel.Location = new System.Drawing.Point(640, 60);
            btnBrowseExcel.Name = "btnBrowseExcel";
            btnBrowseExcel.Size = new System.Drawing.Size(90, 27);
            btnBrowseExcel.TabIndex = 2;
            btnBrowseExcel.Text = "Parcourir...";
            btnBrowseExcel.UseVisualStyleBackColor = true;
            btnBrowseExcel.Click += btnBrowseExcel_Click;
            // 
            // txtExcelPath
            // 
            txtExcelPath.Location = new System.Drawing.Point(110, 62);
            txtExcelPath.Name = "txtExcelPath";
            txtExcelPath.ReadOnly = true;
            txtExcelPath.Size = new System.Drawing.Size(520, 23);
            txtExcelPath.TabIndex = 1;
            // 
            // lblExcelPath
            // 
            lblExcelPath.AutoSize = true;
            lblExcelPath.Location = new System.Drawing.Point(15, 65);
            lblExcelPath.Name = "lblExcelPath";
            lblExcelPath.Size = new System.Drawing.Size(75, 15);
            lblExcelPath.TabIndex = 0;
            lblExcelPath.Text = "Fichier Excel:";
            // 
            // grpSheets
            // 
            grpSheets.Controls.Add(btnDeselectAll);
            grpSheets.Controls.Add(btnSelectAll);
            grpSheets.Controls.Add(lblSheetCount);
            grpSheets.Controls.Add(lstSheets);
            grpSheets.Location = new System.Drawing.Point(12, 198);
            grpSheets.Name = "grpSheets";
            grpSheets.Size = new System.Drawing.Size(760, 200);
            grpSheets.TabIndex = 1;
            grpSheets.TabStop = false;
            grpSheets.Text = "2. Sélectionner les feuilles";
            // 
            // btnDeselectAll
            // 
            btnDeselectAll.Location = new System.Drawing.Point(118, 165);
            btnDeselectAll.Name = "btnDeselectAll";
            btnDeselectAll.Size = new System.Drawing.Size(100, 27);
            btnDeselectAll.TabIndex = 3;
            btnDeselectAll.Text = "Tout désélectionner";
            btnDeselectAll.UseVisualStyleBackColor = true;
            btnDeselectAll.Click += btnDeselectAll_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Location = new System.Drawing.Point(12, 165);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new System.Drawing.Size(100, 27);
            btnSelectAll.TabIndex = 2;
            btnSelectAll.Text = "Tout sélectionner";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // lblSheetCount
            // 
            lblSheetCount.AutoSize = true;
            lblSheetCount.Location = new System.Drawing.Point(656, 170);
            lblSheetCount.Name = "lblSheetCount";
            lblSheetCount.Size = new System.Drawing.Size(61, 15);
            lblSheetCount.TabIndex = 1;
            lblSheetCount.Text = "0 feuille(s)";
            // 
            // lstSheets
            // 
            lstSheets.CheckOnClick = true;
            lstSheets.FormattingEnabled = true;
            lstSheets.Location = new System.Drawing.Point(12, 25);
            lstSheets.Name = "lstSheets";
            lstSheets.Size = new System.Drawing.Size(734, 130);
            lstSheets.TabIndex = 0;
            lstSheets.SelectedIndexChanged += lstSheets_SelectedIndexChanged;
            // 
            // grpOutput
            // 
            grpOutput.Controls.Add(lblPreview);
            grpOutput.Controls.Add(txtFileNamePattern);
            grpOutput.Controls.Add(lblPattern);
            grpOutput.Controls.Add(lblPatternHelp);
            grpOutput.Controls.Add(btnBrowseOutput);
            grpOutput.Controls.Add(txtOutputPath);
            grpOutput.Controls.Add(lblOutputPath);
            grpOutput.Location = new System.Drawing.Point(12, 404);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new System.Drawing.Size(760, 135);
            grpOutput.TabIndex = 2;
            grpOutput.TabStop = false;
            grpOutput.Text = "3. Paramètres d'export";
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.ForeColor = System.Drawing.Color.Blue;
            lblPreview.Location = new System.Drawing.Point(110, 110);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new System.Drawing.Size(142, 15);
            lblPreview.TabIndex = 6;
            lblPreview.Text = "Aperçu: fichier-feuille.pdf";
            // 
            // txtFileNamePattern
            // 
            txtFileNamePattern.Location = new System.Drawing.Point(110, 75);
            txtFileNamePattern.Name = "txtFileNamePattern";
            txtFileNamePattern.Size = new System.Drawing.Size(540, 23);
            txtFileNamePattern.TabIndex = 5;
            txtFileNamePattern.TextChanged += txtFileNamePattern_TextChanged;
            // 
            // lblPattern
            // 
            lblPattern.AutoSize = true;
            lblPattern.Location = new System.Drawing.Point(15, 78);
            lblPattern.Name = "lblPattern";
            lblPattern.Size = new System.Drawing.Size(89, 15);
            lblPattern.TabIndex = 4;
            lblPattern.Text = "Nom de fichier:";
            // 
            // lblPatternHelp
            // 
            lblPatternHelp.AutoSize = true;
            lblPatternHelp.ForeColor = System.Drawing.Color.Gray;
            lblPatternHelp.Location = new System.Drawing.Point(656, 78);
            lblPatternHelp.Name = "lblPatternHelp";
            lblPatternHelp.Size = new System.Drawing.Size(107, 15);
            lblPatternHelp.TabIndex = 3;
            lblPatternHelp.Text = "{workbook} {sheet}";
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.Location = new System.Drawing.Point(656, 36);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new System.Drawing.Size(90, 27);
            btnBrowseOutput.TabIndex = 2;
            btnBrowseOutput.Text = "Parcourir...";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // txtOutputPath
            // 
            txtOutputPath.Location = new System.Drawing.Point(110, 38);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new System.Drawing.Size(540, 23);
            txtOutputPath.TabIndex = 1;
            // 
            // lblOutputPath
            // 
            lblOutputPath.AutoSize = true;
            lblOutputPath.Location = new System.Drawing.Point(15, 41);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new System.Drawing.Size(80, 15);
            lblOutputPath.TabIndex = 0;
            lblOutputPath.Text = "Dossier sortie:";
            // 
            // grpLog
            // 
            grpLog.Controls.Add(lstLog);
            grpLog.Location = new System.Drawing.Point(12, 545);
            grpLog.Name = "grpLog";
            grpLog.Size = new System.Drawing.Size(760, 120);
            grpLog.TabIndex = 3;
            grpLog.TabStop = false;
            grpLog.Text = "Journal";
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.HorizontalScrollbar = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new System.Drawing.Point(12, 22);
            lstLog.Name = "lstLog";
            lstLog.Size = new System.Drawing.Size(734, 79);
            lstLog.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(12, 671);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(650, 23);
            progressBar.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.Enabled = false;
            btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnExport.Location = new System.Drawing.Point(668, 671);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(104, 36);
            btnExport.TabIndex = 5;
            btnExport.Text = "Exporter";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 711);
            Controls.Add(btnExport);
            Controls.Add(progressBar);
            Controls.Add(grpLog);
            Controls.Add(grpOutput);
            Controls.Add(grpSheets);
            Controls.Add(tabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Excel tabs to PDF Exporter";
            FormClosing += MainForm_FormClosing;
            tabControl.ResumeLayout(false);
            tabOpenFiles.ResumeLayout(false);
            grpOpenFiles.ResumeLayout(false);
            grpOpenFiles.PerformLayout();
            tabBrowseFile.ResumeLayout(false);
            grpExcelFile.ResumeLayout(false);
            grpExcelFile.PerformLayout();
            grpSheets.ResumeLayout(false);
            grpSheets.PerformLayout();
            grpOutput.ResumeLayout(false);
            grpOutput.PerformLayout();
            grpLog.ResumeLayout(false);
            ResumeLayout(false);

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
