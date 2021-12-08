
namespace SoanDe
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnChamthi = new System.Windows.Forms.Button();
            this.btnSoanDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChamthi
            // 
            this.btnChamthi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChamthi.BackgroundImage")));
            this.btnChamthi.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamthi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChamthi.Location = new System.Drawing.Point(176, 22);
            this.btnChamthi.Name = "btnChamthi";
            this.btnChamthi.Size = new System.Drawing.Size(158, 91);
            this.btnChamthi.TabIndex = 0;
            this.btnChamthi.Text = "Chấm thi";
            this.btnChamthi.UseVisualStyleBackColor = true;
            this.btnChamthi.Click += new System.EventHandler(this.btnChamthi_Click);
            // 
            // btnSoanDe
            // 
            this.btnSoanDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoanDe.BackgroundImage")));
            this.btnSoanDe.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoanDe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSoanDe.Location = new System.Drawing.Point(12, 22);
            this.btnSoanDe.Name = "btnSoanDe";
            this.btnSoanDe.Size = new System.Drawing.Size(158, 91);
            this.btnSoanDe.TabIndex = 0;
            this.btnSoanDe.Text = "Soạn đề";
            this.btnSoanDe.UseVisualStyleBackColor = true;
            this.btnSoanDe.Click += new System.EventHandler(this.btnSoanDe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(347, 140);
            this.Controls.Add(this.btnSoanDe);
            this.Controls.Add(this.btnChamthi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Ban kiểm tra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChamthi;
        private System.Windows.Forms.Button btnSoanDe;
    }
}