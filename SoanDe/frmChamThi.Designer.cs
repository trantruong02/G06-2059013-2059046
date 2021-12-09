
namespace SoanDe
{
    partial class frmChamThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamThi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filemenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCorrectAns = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenExamAnswer = new System.Windows.Forms.ToolStripMenuItem();
            this.export = new System.Windows.Forms.ToolStripMenuItem();
            this.back = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDiem = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMade = new System.Windows.Forms.TextBox();
            this.btnCham = new System.Windows.Forms.Button();
            this.lbSBD = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.txtSBD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBaiLam = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenuFile,
            this.export,
            this.back,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filemenuFile
            // 
            this.filemenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCorrectAns,
            this.btnOpenExamAnswer});
            this.filemenuFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filemenuFile.Name = "filemenuFile";
            this.filemenuFile.Size = new System.Drawing.Size(49, 22);
            this.filemenuFile.Text = "File";
            // 
            // btnCorrectAns
            // 
            this.btnCorrectAns.Name = "btnCorrectAns";
            this.btnCorrectAns.Size = new System.Drawing.Size(205, 26);
            this.btnCorrectAns.Text = "Đề";
            this.btnCorrectAns.Click += new System.EventHandler(this.btnCorrectAns_Click);
            // 
            // btnOpenExamAnswer
            // 
            this.btnOpenExamAnswer.Enabled = false;
            this.btnOpenExamAnswer.Name = "btnOpenExamAnswer";
            this.btnOpenExamAnswer.Size = new System.Drawing.Size(205, 26);
            this.btnOpenExamAnswer.Text = "Bài làm thí sinh";
            this.btnOpenExamAnswer.Click += new System.EventHandler(this.btnOpenExamAnswer_Click);
            // 
            // export
            // 
            this.export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(71, 22);
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(60, 22);
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDiem.Location = new System.Drawing.Point(456, 60);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(47, 18);
            this.lbDiem.TabIndex = 35;
            this.lbDiem.Text = "Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.Enabled = false;
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(509, 52);
            this.txtDiem.Multiline = true;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(94, 28);
            this.txtDiem.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMade);
            this.groupBox1.Controls.Add(this.btnCham);
            this.groupBox1.Controls.Add(this.lbDiem);
            this.groupBox1.Controls.Add(this.lbSBD);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.lbHoten);
            this.groupBox1.Controls.Add(this.txtSBD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtTG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 86);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Đề";
            // 
            // txtMade
            // 
            this.txtMade.Location = new System.Drawing.Point(350, 54);
            this.txtMade.Name = "txtMade";
            this.txtMade.Size = new System.Drawing.Size(100, 24);
            this.txtMade.TabIndex = 37;
            // 
            // btnCham
            // 
            this.btnCham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCham.Location = new System.Drawing.Point(622, 16);
            this.btnCham.Name = "btnCham";
            this.btnCham.Size = new System.Drawing.Size(110, 64);
            this.btnCham.TabIndex = 36;
            this.btnCham.Text = "Chấm bài";
            this.btnCham.UseVisualStyleBackColor = true;
            this.btnCham.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSBD
            // 
            this.lbSBD.AutoSize = true;
            this.lbSBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSBD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSBD.Location = new System.Drawing.Point(6, 55);
            this.lbSBD.Name = "lbSBD";
            this.lbSBD.Size = new System.Drawing.Size(42, 18);
            this.lbSBD.TabIndex = 13;
            this.lbSBD.Text = "SBD";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbHoten.Location = new System.Drawing.Point(6, 20);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(58, 18);
            this.lbHoten.TabIndex = 13;
            this.lbHoten.Text = "Họ tên";
            // 
            // txtSBD
            // 
            this.txtSBD.Enabled = false;
            this.txtSBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSBD.Location = new System.Drawing.Point(70, 50);
            this.txtSBD.Multiline = true;
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.Size = new System.Drawing.Size(190, 28);
            this.txtSBD.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(270, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Thời gian thi";
            // 
            // txthoten
            // 
            this.txthoten.Enabled = false;
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(70, 16);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(190, 26);
            this.txthoten.TabIndex = 10;
            // 
            // txtTG
            // 
            this.txtTG.Enabled = false;
            this.txtTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.Location = new System.Drawing.Point(390, 15);
            this.txtTG.Multiline = true;
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(213, 29);
            this.txtTG.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtDe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(75, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 387);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phần đề";
            // 
            // txtDe
            // 
            this.txtDe.Enabled = false;
            this.txtDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtDe.Location = new System.Drawing.Point(13, 21);
            this.txtDe.Multiline = true;
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(337, 360);
            this.txtDe.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtBaiLam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(442, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 387);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phần bài làm";
            // 
            // txtBaiLam
            // 
            this.txtBaiLam.Enabled = false;
            this.txtBaiLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtBaiLam.Location = new System.Drawing.Point(13, 21);
            this.txtBaiLam.Multiline = true;
            this.txtBaiLam.Name = "txtBaiLam";
            this.txtBaiLam.Size = new System.Drawing.Size(348, 360);
            this.txtBaiLam.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(738, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 65);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmChamThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChamThi";
            this.Text = "ChamThi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filemenuFile;
        private System.Windows.Forms.ToolStripMenuItem btnCorrectAns;
        private System.Windows.Forms.ToolStripMenuItem btnOpenExamAnswer;
        private System.Windows.Forms.ToolStripMenuItem export;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSBD;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.TextBox txtSBD;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBaiLam;
        private System.Windows.Forms.ToolStripMenuItem back;
        private System.Windows.Forms.Button btnCham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMade;
        private System.Windows.Forms.Button btnRefresh;
    }
}