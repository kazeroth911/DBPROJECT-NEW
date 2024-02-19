
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
            this.pictBoxUser = new System.Windows.Forms.PictureBox();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxUser
            // 
            this.pictBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxUser.Image")));
            this.pictBoxUser.ImageLocation = "67,12";
            this.pictBoxUser.Location = new System.Drawing.Point(67, 12);
            this.pictBoxUser.Name = "pictBoxUser";
            this.pictBoxUser.Size = new System.Drawing.Size(265, 183);
            this.pictBoxUser.TabIndex = 0;
            this.pictBoxUser.TabStop = false;
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
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.pictBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserProfile";
            this.Text = "User Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxUser;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}