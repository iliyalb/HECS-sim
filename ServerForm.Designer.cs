namespace HECS_Server
{
    partial class ServerForm
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
            this.tbConsoleOutput = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStartListener = new System.Windows.Forms.Button();
            this.tbPayLoad = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbConsoleOutput
            // 
            this.tbConsoleOutput.Location = new System.Drawing.Point(12, 38);
            this.tbConsoleOutput.Multiline = true;
            this.tbConsoleOutput.Name = "tbConsoleOutput";
            this.tbConsoleOutput.Size = new System.Drawing.Size(661, 409);
            this.tbConsoleOutput.TabIndex = 0;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(245, 12);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(56, 20);
            this.tbPort.TabIndex = 1;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(72, 12);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(167, 20);
            this.tbIPAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP/Port";
            // 
            // tbStartListener
            // 
            this.tbStartListener.Location = new System.Drawing.Point(328, 9);
            this.tbStartListener.Name = "tbStartListener";
            this.tbStartListener.Size = new System.Drawing.Size(104, 23);
            this.tbStartListener.TabIndex = 4;
            this.tbStartListener.Text = "Start";
            this.tbStartListener.UseVisualStyleBackColor = true;
            this.tbStartListener.Click += new System.EventHandler(this.tbStartListener_Click);
            // 
            // tbPayLoad
            // 
            this.tbPayLoad.Location = new System.Drawing.Point(12, 463);
            this.tbPayLoad.Multiline = true;
            this.tbPayLoad.Name = "tbPayLoad";
            this.tbPayLoad.Size = new System.Drawing.Size(420, 85);
            this.tbPayLoad.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(438, 453);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(235, 108);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 573);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbPayLoad);
            this.Controls.Add(this.tbStartListener);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbConsoleOutput);
            this.Name = "Form1";
            this.Text = "HECS(Server)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConsoleOutput;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbStartListener;
        private System.Windows.Forms.TextBox tbPayLoad;
        private System.Windows.Forms.Button btnSend;
    }
}

