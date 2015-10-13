namespace GlsTestApi
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.grpStep2 = new System.Windows.Forms.GroupBox();
            this.btnMakeConsign = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numCntParcels = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grpStepX = new System.Windows.Forms.GroupBox();
            this.grpStep1.SuspendLayout();
            this.grpStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCntParcels)).BeginInit();
            this.grpStepX.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GlsTestApi.Properties.Settings.Default, "GlsPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.Location = new System.Drawing.Point(233, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = global::GlsTestApi.Properties.Settings.Default.GlsPassword;
            // 
            // txtLogin
            // 
            this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GlsTestApi.Properties.Settings.Default, "GlsLogin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLogin.Location = new System.Drawing.Point(54, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = global::GlsTestApi.Properties.Settings.Default.GlsLogin;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(339, 17);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Session:";
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(512, 20);
            this.txtSession.Name = "txtSession";
            this.txtSession.ReadOnly = true;
            this.txtSession.Size = new System.Drawing.Size(323, 20);
            this.txtSession.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(15, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(72, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // grpStep1
            // 
            this.grpStep1.Controls.Add(this.txtLogin);
            this.grpStep1.Controls.Add(this.txtPassword);
            this.grpStep1.Controls.Add(this.label3);
            this.grpStep1.Controls.Add(this.label1);
            this.grpStep1.Controls.Add(this.txtSession);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.btnLogin);
            this.grpStep1.Location = new System.Drawing.Point(12, 12);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Size = new System.Drawing.Size(841, 58);
            this.grpStep1.TabIndex = 8;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "Step 1: Login and getting session";
            // 
            // grpStep2
            // 
            this.grpStep2.Controls.Add(this.label5);
            this.grpStep2.Controls.Add(this.txtID);
            this.grpStep2.Controls.Add(this.btnMakeConsign);
            this.grpStep2.Controls.Add(this.label4);
            this.grpStep2.Controls.Add(this.numCntParcels);
            this.grpStep2.Enabled = false;
            this.grpStep2.Location = new System.Drawing.Point(12, 76);
            this.grpStep2.Name = "grpStep2";
            this.grpStep2.Size = new System.Drawing.Size(841, 57);
            this.grpStep2.TabIndex = 9;
            this.grpStep2.TabStop = false;
            this.grpStep2.Text = "Step 2: Prepare consignment and send it to PrepareBox";
            // 
            // btnMakeConsign
            // 
            this.btnMakeConsign.Location = new System.Drawing.Point(155, 16);
            this.btnMakeConsign.Name = "btnMakeConsign";
            this.btnMakeConsign.Size = new System.Drawing.Size(178, 23);
            this.btnMakeConsign.TabIndex = 8;
            this.btnMakeConsign.Text = "Make consignment and send";
            this.btnMakeConsign.UseVisualStyleBackColor = true;
            this.btnMakeConsign.Click += new System.EventHandler(this.btnMakeConsign_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parcel\'s count:";
            // 
            // numCntParcels
            // 
            this.numCntParcels.Location = new System.Drawing.Point(95, 19);
            this.numCntParcels.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCntParcels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCntParcels.Name = "numCntParcels";
            this.numCntParcels.Size = new System.Drawing.Size(47, 20);
            this.numCntParcels.TabIndex = 0;
            this.numCntParcels.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(512, 14);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(88, 20);
            this.txtID.TabIndex = 9;
            // 
            // grpStepX
            // 
            this.grpStepX.Controls.Add(this.btnLogout);
            this.grpStepX.Enabled = false;
            this.grpStepX.Location = new System.Drawing.Point(12, 139);
            this.grpStepX.Name = "grpStepX";
            this.grpStepX.Size = new System.Drawing.Size(841, 63);
            this.grpStepX.TabIndex = 10;
            this.grpStepX.TabStop = false;
            this.grpStepX.Text = "Step X: Logout";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 221);
            this.Controls.Add(this.grpStepX);
            this.Controls.Add(this.grpStep2);
            this.Controls.Add(this.grpStep1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            this.grpStep2.ResumeLayout(false);
            this.grpStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCntParcels)).EndInit();
            this.grpStepX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.GroupBox grpStep2;
        private System.Windows.Forms.Button btnMakeConsign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numCntParcels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grpStepX;
    }
}

