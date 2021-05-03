namespace Kpo4317_DJR.Lib
{
    partial class FrmSemiConductor
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
            this.txtboxSubstance_Name = new System.Windows.Forms.TextBox();
            this.txtboxForbiddenZone_width = new System.Windows.Forms.TextBox();
            this.txtboxElectron_move = new System.Windows.Forms.TextBox();
            this.txtboxHole_move = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxSubstance_Name
            // 
            this.txtboxSubstance_Name.Location = new System.Drawing.Point(136, 46);
            this.txtboxSubstance_Name.Name = "txtboxSubstance_Name";
            this.txtboxSubstance_Name.ReadOnly = true;
            this.txtboxSubstance_Name.Size = new System.Drawing.Size(118, 20);
            this.txtboxSubstance_Name.TabIndex = 0;
            // 
            // txtboxForbiddenZone_width
            // 
            this.txtboxForbiddenZone_width.Location = new System.Drawing.Point(136, 72);
            this.txtboxForbiddenZone_width.Name = "txtboxForbiddenZone_width";
            this.txtboxForbiddenZone_width.ReadOnly = true;
            this.txtboxForbiddenZone_width.Size = new System.Drawing.Size(118, 20);
            this.txtboxForbiddenZone_width.TabIndex = 1;
            // 
            // txtboxElectron_move
            // 
            this.txtboxElectron_move.Location = new System.Drawing.Point(136, 98);
            this.txtboxElectron_move.Name = "txtboxElectron_move";
            this.txtboxElectron_move.ReadOnly = true;
            this.txtboxElectron_move.Size = new System.Drawing.Size(118, 20);
            this.txtboxElectron_move.TabIndex = 2;
            // 
            // txtboxHole_move
            // 
            this.txtboxHole_move.Location = new System.Drawing.Point(136, 124);
            this.txtboxHole_move.Name = "txtboxHole_move";
            this.txtboxHole_move.ReadOnly = true;
            this.txtboxHole_move.Size = new System.Drawing.Size(118, 20);
            this.txtboxHole_move.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Substance title";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Forbidden zone width";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Movement of electrons";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(118, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Movement of holes";
            // 
            // FrmSemiConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtboxHole_move);
            this.Controls.Add(this.txtboxElectron_move);
            this.Controls.Add(this.txtboxForbiddenZone_width);
            this.Controls.Add(this.txtboxSubstance_Name);
            this.Name = "FrmSemiConductor";
            this.Text = "FrmSemiConductor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxSubstance_Name;
        private System.Windows.Forms.TextBox txtboxForbiddenZone_width;
        private System.Windows.Forms.TextBox txtboxElectron_move;
        private System.Windows.Forms.TextBox txtboxHole_move;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}