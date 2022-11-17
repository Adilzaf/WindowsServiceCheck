namespace WindowsFormsApp1
{
    partial class Forms1
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDBServer = new System.Windows.Forms.Label();
            this.txtDBserver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDBport = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultSrv1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(0, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Service name:";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(189, 16);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(100, 20);
            this.txtServiceName.TabIndex = 1;
            this.txtServiceName.Text = "RpcSs";
            this.txtServiceName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDBServer
            // 
            this.lblDBServer.AutoSize = true;
            this.lblDBServer.Location = new System.Drawing.Point(340, 23);
            this.lblDBServer.Name = "lblDBServer";
            this.lblDBServer.Size = new System.Drawing.Size(114, 13);
            this.lblDBServer.TabIndex = 3;
            this.lblDBServer.Text = "DB Server Name/Port:";
            this.lblDBServer.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDBserver
            // 
            this.txtDBserver.Location = new System.Drawing.Point(525, 19);
            this.txtDBserver.Name = "txtDBserver";
            this.txtDBserver.Size = new System.Drawing.Size(100, 20);
            this.txtDBserver.TabIndex = 4;
            this.txtDBserver.Text = "localhost";
            this.txtDBserver.TextChanged += new System.EventHandler(this.txtDBserver_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DB Server Port:";
            // 
            // txtDBport
            // 
            this.txtDBport.Location = new System.Drawing.Point(728, 19);
            this.txtDBport.Name = "txtDBport";
            this.txtDBport.Size = new System.Drawing.Size(100, 20);
            this.txtDBport.TabIndex = 6;
            this.txtDBport.Text = "1433";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Check port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(349, 82);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // lblResultSrv1
            // 
            this.lblResultSrv1.AutoSize = true;
            this.lblResultSrv1.Location = new System.Drawing.Point(0, 82);
            this.lblResultSrv1.Name = "lblResultSrv1";
            this.lblResultSrv1.Size = new System.Drawing.Size(37, 13);
            this.lblResultSrv1.TabIndex = 9;
            this.lblResultSrv1.Text = "Result";
            // 
            // Forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 472);
            this.Controls.Add(this.lblResultSrv1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDBport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDBserver);
            this.Controls.Add(this.lblDBServer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.lblStatus);
            this.Name = "Forms1";
            this.Text = "Check prereqs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDBServer;
        private System.Windows.Forms.TextBox txtDBserver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDBport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultSrv1;
    }
}

