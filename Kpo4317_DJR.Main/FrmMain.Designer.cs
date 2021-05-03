namespace Kpo4317_DJR.Main
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmSemiconductor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenSemiconductor = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSemiConductors = new System.Windows.Forms.DataGridView();
            this.txtboxDataFileName = new System.Windows.Forms.TextBox();
            this.txtboxLogPath = new System.Windows.Forms.TextBox();
            this.ListLoadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemiConductors)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmSemiconductor});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(800, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpen,
            this.mnExit});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(57, 20);
            this.mmFile.Text = "&1.Файл";
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(121, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(121, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mmSemiconductor
            // 
            this.mmSemiconductor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenSemiconductor});
            this.mmSemiconductor.Name = "mmSemiconductor";
            this.mmSemiconductor.Size = new System.Drawing.Size(117, 20);
            this.mmSemiconductor.Text = "&2.Полупроводник";
            // 
            // mnOpenSemiconductor
            // 
            this.mnOpenSemiconductor.Name = "mnOpenSemiconductor";
            this.mnOpenSemiconductor.Size = new System.Drawing.Size(211, 22);
            this.mnOpenSemiconductor.Text = "Открыть полупроводник";
            this.mnOpenSemiconductor.Click += new System.EventHandler(this.mnOpenSemiconductor_Click);
            // 
            // dgvSemiConductors
            // 
            this.dgvSemiConductors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemiConductors.Location = new System.Drawing.Point(13, 27);
            this.dgvSemiConductors.Name = "dgvSemiConductors";
            this.dgvSemiConductors.Size = new System.Drawing.Size(642, 398);
            this.dgvSemiConductors.TabIndex = 2;
            // 
            // txtboxDataFileName
            // 
            this.txtboxDataFileName.Location = new System.Drawing.Point(661, 79);
            this.txtboxDataFileName.Name = "txtboxDataFileName";
            this.txtboxDataFileName.ReadOnly = true;
            this.txtboxDataFileName.Size = new System.Drawing.Size(127, 20);
            this.txtboxDataFileName.TabIndex = 3;
            // 
            // txtboxLogPath
            // 
            this.txtboxLogPath.Location = new System.Drawing.Point(661, 53);
            this.txtboxLogPath.Name = "txtboxLogPath";
            this.txtboxLogPath.ReadOnly = true;
            this.txtboxLogPath.Size = new System.Drawing.Size(127, 20);
            this.txtboxLogPath.TabIndex = 3;
            // 
            // ListLoadingProgressBar
            // 
            this.ListLoadingProgressBar.Location = new System.Drawing.Point(661, 105);
            this.ListLoadingProgressBar.Name = "ListLoadingProgressBar";
            this.ListLoadingProgressBar.Size = new System.Drawing.Size(127, 23);
            this.ListLoadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ListLoadingProgressBar.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListLoadingProgressBar);
            this.Controls.Add(this.txtboxLogPath);
            this.Controls.Add(this.txtboxDataFileName);
            this.Controls.Add(this.dgvSemiConductors);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Name = "FrmMain";
            this.Text = "КПО:4317:Дельмухаметов";
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemiConductors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.DataGridView dgvSemiConductors;
        private System.Windows.Forms.ToolStripMenuItem mmSemiconductor;
        private System.Windows.Forms.ToolStripMenuItem mnOpenSemiconductor;
        private System.Windows.Forms.TextBox txtboxDataFileName;
        private System.Windows.Forms.TextBox txtboxLogPath;
        private System.Windows.Forms.ProgressBar ListLoadingProgressBar;
    }
}

