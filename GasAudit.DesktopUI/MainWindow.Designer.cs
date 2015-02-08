namespace GasAudit.DesktopUI
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tmrSensor = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbFIR = new System.Windows.Forms.TrackBar();
            this.tbPIR = new System.Windows.Forms.TrackBar();
            this.tbTIR = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbImitation = new System.Windows.Forms.GroupBox();
            this.gbWraper = new System.Windows.Forms.GroupBox();
            this.gbImitatorLuncher = new System.Windows.Forms.GroupBox();
            this.btnHideImitation = new System.Windows.Forms.Button();
            this.gasMnemo1 = new GasAudit.DesktopUI.GasMnemo();
            ((System.ComponentModel.ISupportInitialize)(this.tbFIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTIR)).BeginInit();
            this.gbImitation.SuspendLayout();
            this.gbWraper.SuspendLayout();
            this.gbImitatorLuncher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSensor
            // 
            this.tmrSensor.Interval = 500;
            this.tmrSensor.Tick += new System.EventHandler(this.tmrSensor_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbFIR
            // 
            this.tbFIR.Location = new System.Drawing.Point(164, 86);
            this.tbFIR.Maximum = 40;
            this.tbFIR.Minimum = 30;
            this.tbFIR.Name = "tbFIR";
            this.tbFIR.Size = new System.Drawing.Size(104, 45);
            this.tbFIR.TabIndex = 3;
            this.tbFIR.Value = 33;
            this.tbFIR.Scroll += new System.EventHandler(this.tbFIR_Scroll);
            // 
            // tbPIR
            // 
            this.tbPIR.Location = new System.Drawing.Point(164, 137);
            this.tbPIR.Maximum = 15;
            this.tbPIR.Minimum = 6;
            this.tbPIR.Name = "tbPIR";
            this.tbPIR.Size = new System.Drawing.Size(104, 45);
            this.tbPIR.TabIndex = 4;
            this.tbPIR.Value = 8;
            this.tbPIR.Scroll += new System.EventHandler(this.tbPIR_Scroll);
            // 
            // tbTIR
            // 
            this.tbTIR.Location = new System.Drawing.Point(164, 35);
            this.tbTIR.Maximum = 80;
            this.tbTIR.Minimum = 60;
            this.tbTIR.Name = "tbTIR";
            this.tbTIR.Size = new System.Drawing.Size(104, 45);
            this.tbTIR.TabIndex = 5;
            this.tbTIR.Value = 67;
            this.tbTIR.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(340, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(340, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(340, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PIR-1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "FIR-2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "TIR-3";
            // 
            // gbImitation
            // 
            this.gbImitation.Controls.Add(this.label3);
            this.gbImitation.Controls.Add(this.label4);
            this.gbImitation.Controls.Add(this.tbFIR);
            this.gbImitation.Controls.Add(this.label5);
            this.gbImitation.Controls.Add(this.tbPIR);
            this.gbImitation.Controls.Add(this.label6);
            this.gbImitation.Controls.Add(this.tbTIR);
            this.gbImitation.Controls.Add(this.label1);
            this.gbImitation.Controls.Add(this.label2);
            this.gbImitation.Location = new System.Drawing.Point(6, 48);
            this.gbImitation.Name = "gbImitation";
            this.gbImitation.Size = new System.Drawing.Size(446, 189);
            this.gbImitation.TabIndex = 12;
            this.gbImitation.TabStop = false;
            this.gbImitation.Text = "Імітація датчиків";
            // 
            // gbWraper
            // 
            this.gbWraper.Controls.Add(this.gbImitatorLuncher);
            this.gbWraper.Controls.Add(this.gbImitation);
            this.gbWraper.Location = new System.Drawing.Point(12, 484);
            this.gbWraper.Name = "gbWraper";
            this.gbWraper.Size = new System.Drawing.Size(611, 257);
            this.gbWraper.TabIndex = 13;
            this.gbWraper.TabStop = false;
            this.gbWraper.Text = "Панель управління";
            // 
            // gbImitatorLuncher
            // 
            this.gbImitatorLuncher.Controls.Add(this.button2);
            this.gbImitatorLuncher.Controls.Add(this.button1);
            this.gbImitatorLuncher.Location = new System.Drawing.Point(461, 48);
            this.gbImitatorLuncher.Name = "gbImitatorLuncher";
            this.gbImitatorLuncher.Size = new System.Drawing.Size(144, 131);
            this.gbImitatorLuncher.TabIndex = 13;
            this.gbImitatorLuncher.TabStop = false;
            this.gbImitatorLuncher.Text = "Опитування датчиків";
            // 
            // btnHideImitation
            // 
            this.btnHideImitation.Location = new System.Drawing.Point(538, 455);
            this.btnHideImitation.Name = "btnHideImitation";
            this.btnHideImitation.Size = new System.Drawing.Size(75, 23);
            this.btnHideImitation.TabIndex = 14;
            this.btnHideImitation.Text = "show/hide";
            this.btnHideImitation.UseVisualStyleBackColor = true;
            this.btnHideImitation.Click += new System.EventHandler(this.btnHideImitation_Click);
            // 
            // gasMnemo1
            // 
            this.gasMnemo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gasMnemo1.BackgroundImage")));
            this.gasMnemo1.Location = new System.Drawing.Point(0, -2);
            this.gasMnemo1.Name = "gasMnemo1";
            this.gasMnemo1.Size = new System.Drawing.Size(640, 480);
            this.gasMnemo1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 753);
            this.Controls.Add(this.btnHideImitation);
            this.Controls.Add(this.gbWraper);
            this.Controls.Add(this.gasMnemo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Gas Audit";
            ((System.ComponentModel.ISupportInitialize)(this.tbFIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTIR)).EndInit();
            this.gbImitation.ResumeLayout(false);
            this.gbImitation.PerformLayout();
            this.gbWraper.ResumeLayout(false);
            this.gbImitatorLuncher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSensor;
        public GasMnemo gasMnemo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar tbFIR;
        private System.Windows.Forms.TrackBar tbPIR;
        private System.Windows.Forms.TrackBar tbTIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbImitation;
        private System.Windows.Forms.GroupBox gbWraper;
        private System.Windows.Forms.GroupBox gbImitatorLuncher;
        private System.Windows.Forms.Button btnHideImitation;

    }
}

