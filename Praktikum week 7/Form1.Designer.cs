namespace Praktikum_week_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInputKalimat = new System.Windows.Forms.Label();
            this.txtBoxInputKalimat = new System.Windows.Forms.TextBox();
            this.lblInputHuruf = new System.Windows.Forms.Label();
            this.txtBoxInputHuruf = new System.Windows.Forms.TextBox();
            this.lblMenjadi = new System.Windows.Forms.Label();
            this.txtBoxMenjadi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputKalimat
            // 
            this.lblInputKalimat.AutoSize = true;
            this.lblInputKalimat.Location = new System.Drawing.Point(28, 65);
            this.lblInputKalimat.Name = "lblInputKalimat";
            this.lblInputKalimat.Size = new System.Drawing.Size(155, 25);
            this.lblInputKalimat.TabIndex = 0;
            this.lblInputKalimat.Text = "Masukkan Kalimat";
            // 
            // txtBoxInputKalimat
            // 
            this.txtBoxInputKalimat.Location = new System.Drawing.Point(208, 62);
            this.txtBoxInputKalimat.Name = "txtBoxInputKalimat";
            this.txtBoxInputKalimat.Size = new System.Drawing.Size(367, 31);
            this.txtBoxInputKalimat.TabIndex = 1;
            // 
            // lblInputHuruf
            // 
            this.lblInputHuruf.AutoSize = true;
            this.lblInputHuruf.Location = new System.Drawing.Point(28, 130);
            this.lblInputHuruf.Name = "lblInputHuruf";
            this.lblInputHuruf.Size = new System.Drawing.Size(142, 25);
            this.lblInputHuruf.TabIndex = 2;
            this.lblInputHuruf.Text = "Masukkan Huruf";
            // 
            // txtBoxInputHuruf
            // 
            this.txtBoxInputHuruf.Location = new System.Drawing.Point(208, 127);
            this.txtBoxInputHuruf.Name = "txtBoxInputHuruf";
            this.txtBoxInputHuruf.Size = new System.Drawing.Size(101, 31);
            this.txtBoxInputHuruf.TabIndex = 3;
            // 
            // lblMenjadi
            // 
            this.lblMenjadi.AutoSize = true;
            this.lblMenjadi.Location = new System.Drawing.Point(354, 130);
            this.lblMenjadi.Name = "lblMenjadi";
            this.lblMenjadi.Size = new System.Drawing.Size(80, 25);
            this.lblMenjadi.TabIndex = 4;
            this.lblMenjadi.Text = "Menjadi ";
            this.lblMenjadi.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxMenjadi
            // 
            this.txtBoxMenjadi.Location = new System.Drawing.Point(467, 127);
            this.txtBoxMenjadi.Name = "txtBoxMenjadi";
            this.txtBoxMenjadi.Size = new System.Drawing.Size(108, 31);
            this.txtBoxMenjadi.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Konvers !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(28, 271);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(59, 25);
            this.lblHasil.TabIndex = 7;
            this.lblHasil.Text = "Hasil :";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(208, 271);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(24, 25);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "...";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxMenjadi);
            this.Controls.Add(this.lblMenjadi);
            this.Controls.Add(this.txtBoxInputHuruf);
            this.Controls.Add(this.lblInputHuruf);
            this.Controls.Add(this.txtBoxInputKalimat);
            this.Controls.Add(this.lblInputKalimat);
            this.Name = "Form1";
            this.Text = "Praktikum Week 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputKalimat;
        private System.Windows.Forms.TextBox txtBoxInputKalimat;
        private System.Windows.Forms.Label lblInputHuruf;
        private System.Windows.Forms.TextBox txtBoxInputHuruf;
        private System.Windows.Forms.Label lblMenjadi;
        private System.Windows.Forms.TextBox txtBoxMenjadi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblOutput;
    }
}
