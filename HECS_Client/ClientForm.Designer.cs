using MetroFramework.Forms;

namespace HECS_Client

{
    partial class HECS_Client :MetroForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbPayLoad = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TrackBar();
            this.tbRichter = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.pnlSeason = new System.Windows.Forms.Panel();
            this.rdbSpring = new System.Windows.Forms.RadioButton();
            this.rdbFall = new System.Windows.Forms.RadioButton();
            this.rdbSummer = new System.Windows.Forms.RadioButton();
            this.rdbWinter = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRichter = new System.Windows.Forms.Label();
            this.chrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRichter)).BeginInit();
            this.pnlSeason.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 456);
            this.textBox1.TabIndex = 0;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(94, 66);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(100, 20);
            this.tbIPAddress.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(200, 66);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(43, 20);
            this.tbPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP/Port";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(279, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSend.Location = new System.Drawing.Point(688, 561);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(119, 41);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbPayLoad
            // 
            this.tbPayLoad.Location = new System.Drawing.Point(23, 572);
            this.tbPayLoad.Name = "tbPayLoad";
            this.tbPayLoad.Size = new System.Drawing.Size(659, 20);
            this.tbPayLoad.TabIndex = 6;
            this.tbPayLoad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPayLoad_KeyDown);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(575, 214);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(357, 45);
            this.tbTime.TabIndex = 7;
            // 
            // tbRichter
            // 
            this.tbRichter.Location = new System.Drawing.Point(573, 287);
            this.tbRichter.Name = "tbRichter";
            this.tbRichter.Size = new System.Drawing.Size(359, 45);
            this.tbRichter.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(572, 187);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time :";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(783, 102);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 10;
            this.cbCity.Text = "Select city";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(573, 102);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 21);
            this.cbState.TabIndex = 11;
            this.cbState.Text = "Select state";
            // 
            // pnlSeason
            // 
            this.pnlSeason.Controls.Add(this.rdbWinter);
            this.pnlSeason.Controls.Add(this.rdbSummer);
            this.pnlSeason.Controls.Add(this.rdbFall);
            this.pnlSeason.Controls.Add(this.rdbSpring);
            this.pnlSeason.Location = new System.Drawing.Point(575, 366);
            this.pnlSeason.Name = "pnlSeason";
            this.pnlSeason.Size = new System.Drawing.Size(121, 127);
            this.pnlSeason.TabIndex = 12;
            // 
            // rdbSpring
            // 
            this.rdbSpring.AutoSize = true;
            this.rdbSpring.Location = new System.Drawing.Point(20, 20);
            this.rdbSpring.Name = "rdbSpring";
            this.rdbSpring.Size = new System.Drawing.Size(55, 17);
            this.rdbSpring.TabIndex = 0;
            this.rdbSpring.TabStop = true;
            this.rdbSpring.Text = "Spring";
            this.rdbSpring.UseVisualStyleBackColor = true;
            // 
            // rdbFall
            // 
            this.rdbFall.AutoSize = true;
            this.rdbFall.Location = new System.Drawing.Point(20, 66);
            this.rdbFall.Name = "rdbFall";
            this.rdbFall.Size = new System.Drawing.Size(41, 17);
            this.rdbFall.TabIndex = 1;
            this.rdbFall.TabStop = true;
            this.rdbFall.Text = "Fall";
            this.rdbFall.UseVisualStyleBackColor = true;
            // 
            // rdbSummer
            // 
            this.rdbSummer.AutoSize = true;
            this.rdbSummer.Location = new System.Drawing.Point(20, 43);
            this.rdbSummer.Name = "rdbSummer";
            this.rdbSummer.Size = new System.Drawing.Size(63, 17);
            this.rdbSummer.TabIndex = 2;
            this.rdbSummer.TabStop = true;
            this.rdbSummer.Text = "Summer";
            this.rdbSummer.UseVisualStyleBackColor = true;
            // 
            // rdbWinter
            // 
            this.rdbWinter.AutoSize = true;
            this.rdbWinter.Location = new System.Drawing.Point(20, 90);
            this.rdbWinter.Name = "rdbWinter";
            this.rdbWinter.Size = new System.Drawing.Size(56, 17);
            this.rdbWinter.TabIndex = 3;
            this.rdbWinter.TabStop = true;
            this.rdbWinter.Text = "Winter";
            this.rdbWinter.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(813, 559);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 43);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRichter
            // 
            this.lblRichter.AutoSize = true;
            this.lblRichter.Location = new System.Drawing.Point(572, 262);
            this.lblRichter.Name = "lblRichter";
            this.lblRichter.Size = new System.Drawing.Size(47, 13);
            this.lblRichter.TabIndex = 14;
            this.lblRichter.Text = "Richter :";
            // 
            // chrt
            // 
            chartArea3.Name = "ChartArea1";
            this.chrt.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrt.Legends.Add(legend3);
            this.chrt.Location = new System.Drawing.Point(714, 338);
            this.chrt.Name = "chrt";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrt.Series.Add(series3);
            this.chrt.Size = new System.Drawing.Size(218, 184);
            this.chrt.TabIndex = 15;
            this.chrt.Text = "chart1";
            this.chrt.Click += new System.EventHandler(this.chart1_Click);
            // 
            // HECS_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 644);
            this.Controls.Add(this.chrt);
            this.Controls.Add(this.lblRichter);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlSeason);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tbRichter);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbPayLoad);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HECS_Client";
            this.Text = "HECS Client";
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRichter)).EndInit();
            this.pnlSeason.ResumeLayout(false);
            this.pnlSeason.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbPayLoad;
        private System.Windows.Forms.TrackBar tbTime;
        private System.Windows.Forms.TrackBar tbRichter;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Panel pnlSeason;
        private System.Windows.Forms.RadioButton rdbWinter;
        private System.Windows.Forms.RadioButton rdbSummer;
        private System.Windows.Forms.RadioButton rdbFall;
        private System.Windows.Forms.RadioButton rdbSpring;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRichter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt;
    }
}

