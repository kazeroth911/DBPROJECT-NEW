
namespace DBPROJECT
{
    partial class frmUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserProfile));
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.pkrBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSMTPport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSMTPHOST = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPhoto = new System.Windows.Forms.GroupBox();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grpPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLoadPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPhoto.Image")));
            this.btnLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLoadPhoto.Location = new System.Drawing.Point(67, 201);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(146, 23);
            this.btnLoadPhoto.TabIndex = 1;
            this.btnLoadPhoto.Text = "Load New Photo";
            this.btnLoadPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadPhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClear.Location = new System.Drawing.Point(219, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Photo";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnChangePwd);
            this.groupBox1.Controls.Add(this.cbxGender);
            this.groupBox1.Controls.Add(this.pkrBirthdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSMTPport);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSMTPHOST);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLoginName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(325, 225);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 23);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(233, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnChangePwd.ForeColor = System.Drawing.Color.Black;
            this.btnChangePwd.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePwd.Image")));
            this.btnChangePwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePwd.Location = new System.Drawing.Point(14, 222);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(190, 29);
            this.btnChangePwd.TabIndex = 32;
            this.btnChangePwd.Text = "Change User Password";
            this.btnChangePwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cbxGender.Location = new System.Drawing.Point(108, 155);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(100, 21);
            this.cbxGender.TabIndex = 31;
            // 
            // pkrBirthdate
            // 
            this.pkrBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkrBirthdate.Location = new System.Drawing.Point(109, 129);
            this.pkrBirthdate.Name = "pkrBirthdate";
            this.pkrBirthdate.Size = new System.Drawing.Size(100, 20);
            this.pkrBirthdate.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Birthdate";
            // 
            // txtSMTPport
            // 
            this.txtSMTPport.Location = new System.Drawing.Point(110, 102);
            this.txtSMTPport.Name = "txtSMTPport";
            this.txtSMTPport.Size = new System.Drawing.Size(99, 20);
            this.txtSMTPport.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "SMTP Port";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email";
            // 
            // txtSMTPHOST
            // 
            this.txtSMTPHOST.Location = new System.Drawing.Point(110, 77);
            this.txtSMTPHOST.Name = "txtSMTPHOST";
            this.txtSMTPHOST.Size = new System.Drawing.Size(301, 20);
            this.txtSMTPHOST.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "SMTP Host";
            // 
            // txtLoginName
            // 
            this.txtLoginName.AcceptsReturn = true;
            this.txtLoginName.AcceptsTab = true;
            this.txtLoginName.Location = new System.Drawing.Point(110, 26);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.ReadOnly = true;
            this.txtLoginName.Size = new System.Drawing.Size(301, 20);
            this.txtLoginName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login Name";
            // 
            // grpPhoto
            // 
            this.grpPhoto.Controls.Add(this.picBoxUser);
            this.grpPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpPhoto.Location = new System.Drawing.Point(67, 12);
            this.grpPhoto.Name = "grpPhoto";
            this.grpPhoto.Size = new System.Drawing.Size(271, 185);
            this.grpPhoto.TabIndex = 35;
            this.grpPhoto.TabStop = false;
            // 
            // picBoxUser
            // 
            this.picBoxUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBoxUser.ErrorImage")));
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.Location = new System.Drawing.Point(3, 16);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(265, 160);
            this.picBoxUser.TabIndex = 0;
            this.picBoxUser.TabStop = false;
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 506);
            this.Controls.Add(this.grpPhoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserProfile_FormClosing);
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.DateTimePicker pkrBirthdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSMTPport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMTPHOST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPhoto;
        private System.Windows.Forms.PictureBox picBoxUser;
    }
}