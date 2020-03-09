namespace project_rmq
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRMQ_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRMQ_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRMQ_Host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboDatabaseServer = new System.Windows.Forms.ComboBox();
            this.txtDB_Port = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDB_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDB_Username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDB_Host = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDB_Name = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(384, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 211);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRMQ_Password);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtRMQ_Username);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtRMQ_Host);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RMQ Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRMQ_Password
            // 
            this.txtRMQ_Password.Location = new System.Drawing.Point(79, 67);
            this.txtRMQ_Password.Name = "txtRMQ_Password";
            this.txtRMQ_Password.Size = new System.Drawing.Size(100, 20);
            this.txtRMQ_Password.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // txtRMQ_Username
            // 
            this.txtRMQ_Username.Location = new System.Drawing.Point(79, 41);
            this.txtRMQ_Username.Name = "txtRMQ_Username";
            this.txtRMQ_Username.Size = new System.Drawing.Size(100, 20);
            this.txtRMQ_Username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // txtRMQ_Host
            // 
            this.txtRMQ_Host.Location = new System.Drawing.Point(79, 15);
            this.txtRMQ_Host.Name = "txtRMQ_Host";
            this.txtRMQ_Host.Size = new System.Drawing.Size(100, 20);
            this.txtRMQ_Host.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(293, 154);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboDatabaseServer);
            this.tabPage2.Controls.Add(this.txtDB_Name);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtDB_Port);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtDB_Password);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtDB_Username);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtDB_Host);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboDatabaseServer
            // 
            this.cboDatabaseServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabaseServer.FormattingEnabled = true;
            this.cboDatabaseServer.Items.AddRange(new object[] {
            "SQL Server",
            "MySQL Server"});
            this.cboDatabaseServer.Location = new System.Drawing.Point(108, 14);
            this.cboDatabaseServer.Name = "cboDatabaseServer";
            this.cboDatabaseServer.Size = new System.Drawing.Size(121, 21);
            this.cboDatabaseServer.TabIndex = 6;
            // 
            // txtDB_Port
            // 
            this.txtDB_Port.Location = new System.Drawing.Point(108, 119);
            this.txtDB_Port.Name = "txtDB_Port";
            this.txtDB_Port.Size = new System.Drawing.Size(121, 20);
            this.txtDB_Port.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Port";
            // 
            // txtDB_Password
            // 
            this.txtDB_Password.Location = new System.Drawing.Point(108, 93);
            this.txtDB_Password.Name = "txtDB_Password";
            this.txtDB_Password.PasswordChar = '•';
            this.txtDB_Password.Size = new System.Drawing.Size(121, 20);
            this.txtDB_Password.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // txtDB_Username
            // 
            this.txtDB_Username.Location = new System.Drawing.Point(108, 67);
            this.txtDB_Username.Name = "txtDB_Username";
            this.txtDB_Username.Size = new System.Drawing.Size(121, 20);
            this.txtDB_Username.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Database";
            // 
            // txtDB_Host
            // 
            this.txtDB_Host.Location = new System.Drawing.Point(108, 41);
            this.txtDB_Host.Name = "txtDB_Host";
            this.txtDB_Host.Size = new System.Drawing.Size(121, 20);
            this.txtDB_Host.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Host";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(293, 154);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Database Name";
            // 
            // txtDB_Name
            // 
            this.txtDB_Name.Location = new System.Drawing.Point(108, 145);
            this.txtDB_Name.Name = "txtDB_Name";
            this.txtDB_Name.Size = new System.Drawing.Size(121, 20);
            this.txtDB_Name.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Name";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtRMQ_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRMQ_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRMQ_Host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDatabaseServer;
        private System.Windows.Forms.TextBox txtDB_Port;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDB_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDB_Username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDB_Host;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDB_Name;
        private System.Windows.Forms.Label label10;
    }
}

