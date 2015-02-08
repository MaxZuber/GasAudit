namespace GasAudit.DesktopUI
{
    partial class GasMnemo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasMnemo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTIR = new System.Windows.Forms.Label();
            this.lblFIR = new System.Windows.Forms.Label();
            this.lblPIR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIR-3 Температура газу";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FIR - 2 Витрата газу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PIR - 1 Тиск газу";
            // 
            // lblTIR
            // 
            this.lblTIR.AutoSize = true;
            this.lblTIR.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTIR.Location = new System.Drawing.Point(327, 187);
            this.lblTIR.Name = "lblTIR";
            this.lblTIR.Size = new System.Drawing.Size(0, 13);
            this.lblTIR.TabIndex = 3;
            // 
            // lblFIR
            // 
            this.lblFIR.AutoSize = true;
            this.lblFIR.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFIR.Location = new System.Drawing.Point(190, 399);
            this.lblFIR.Name = "lblFIR";
            this.lblFIR.Size = new System.Drawing.Size(0, 13);
            this.lblFIR.TabIndex = 4;
            // 
            // lblPIR
            // 
            this.lblPIR.AutoSize = true;
            this.lblPIR.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPIR.Location = new System.Drawing.Point(406, 399);
            this.lblPIR.Name = "lblPIR";
            this.lblPIR.Size = new System.Drawing.Size(0, 13);
            this.lblPIR.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(220, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Облік газу";
            // 
            // GasMnemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPIR);
            this.Controls.Add(this.lblFIR);
            this.Controls.Add(this.lblTIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GasMnemo";
            this.Size = new System.Drawing.Size(640, 480);
            this.Load += new System.EventHandler(this.GasMnemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblTIR;
        public System.Windows.Forms.Label lblFIR;
        public System.Windows.Forms.Label lblPIR;
    }
}
