
namespace SoanDe
{
    partial class frmSoan_De
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoan_De));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMaDe = new System.Windows.Forms.TextBox();
            this.btnMaDe = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveAns = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInfor = new System.Windows.Forms.Button();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCauhoi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvDS = new System.Windows.Forms.ListView();
            this.Cauhoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CauA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CauB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CauC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CauD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DapAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.txtMaDe);
            this.groupBox1.Controls.Add(this.btnMaDe);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnSaveAns);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnInfor);
            this.groupBox1.Controls.Add(this.rdD);
            this.groupBox1.Controls.Add(this.rdC);
            this.groupBox1.Controls.Add(this.rdB);
            this.groupBox1.Controls.Add(this.rdA);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCauhoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soạn đề";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(946, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 30);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMaDe
            // 
            this.txtMaDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDe.Location = new System.Drawing.Point(370, 16);
            this.txtMaDe.Multiline = true;
            this.txtMaDe.Name = "txtMaDe";
            this.txtMaDe.Size = new System.Drawing.Size(90, 30);
            this.txtMaDe.TabIndex = 22;
            // 
            // btnMaDe
            // 
            this.btnMaDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaDe.Location = new System.Drawing.Point(281, 16);
            this.btnMaDe.Name = "btnMaDe";
            this.btnMaDe.Size = new System.Drawing.Size(75, 30);
            this.btnMaDe.TabIndex = 21;
            this.btnMaDe.Text = "Mã đề";
            this.btnMaDe.UseVisualStyleBackColor = true;
            this.btnMaDe.Click += new System.EventHandler(this.btnMaDe_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(946, 149);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 30);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveAns
            // 
            this.btnSaveAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAns.Location = new System.Drawing.Point(946, 79);
            this.btnSaveAns.Name = "btnSaveAns";
            this.btnSaveAns.Size = new System.Drawing.Size(105, 30);
            this.btnSaveAns.TabIndex = 17;
            this.btnSaveAns.Text = "Lưu Đáp án";
            this.btnSaveAns.UseVisualStyleBackColor = true;
            this.btnSaveAns.Click += new System.EventHandler(this.btnSaveAns_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Location = new System.Drawing.Point(792, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 30);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInfor
            // 
            this.btnInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInfor.Location = new System.Drawing.Point(946, 112);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Size = new System.Drawing.Size(105, 30);
            this.btnInfor.TabIndex = 15;
            this.btnInfor.Text = "Chi tiết";
            this.btnInfor.UseVisualStyleBackColor = true;
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // rdD
            // 
            this.rdD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(466, 149);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(43, 24);
            this.rdD.TabIndex = 14;
            this.rdD.TabStop = true;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(466, 116);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(42, 24);
            this.rdC.TabIndex = 13;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(466, 83);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(42, 24);
            this.rdB.TabIndex = 12;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(466, 50);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(41, 24);
            this.rdA.TabIndex = 11;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // txtD
            // 
            this.txtD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(513, 148);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(384, 27);
            this.txtD.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(513, 115);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(384, 27);
            this.txtC.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(513, 82);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(384, 27);
            this.txtB.TabIndex = 2;
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(513, 49);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(384, 27);
            this.txtA.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(946, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu đề";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Location = new System.Drawing.Point(697, 187);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(605, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(513, 187);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Câu hỏi";
            // 
            // txtCauhoi
            // 
            this.txtCauhoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauhoi.Location = new System.Drawing.Point(10, 49);
            this.txtCauhoi.Multiline = true;
            this.txtCauhoi.Name = "txtCauhoi";
            this.txtCauhoi.Size = new System.Drawing.Size(450, 168);
            this.txtCauhoi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.lvDS);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách câu hỏi";
            // 
            // lvDS
            // 
            this.lvDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cauhoi,
            this.CauA,
            this.CauB,
            this.CauC,
            this.CauD,
            this.DapAn});
            this.lvDS.FullRowSelect = true;
            this.lvDS.GridLines = true;
            this.lvDS.HideSelection = false;
            this.lvDS.Location = new System.Drawing.Point(14, 21);
            this.lvDS.Name = "lvDS";
            this.lvDS.Size = new System.Drawing.Size(1058, 297);
            this.lvDS.TabIndex = 0;
            this.lvDS.UseCompatibleStateImageBehavior = false;
            this.lvDS.View = System.Windows.Forms.View.Details;
            this.lvDS.SelectedIndexChanged += new System.EventHandler(this.lvDS_SelectedIndexChanged);
            // 
            // Cauhoi
            // 
            this.Cauhoi.Text = "Câu hỏi";
            this.Cauhoi.Width = 395;
            // 
            // CauA
            // 
            this.CauA.Text = "Câu A";
            this.CauA.Width = 67;
            // 
            // CauB
            // 
            this.CauB.Text = "Câu B";
            this.CauB.Width = 68;
            // 
            // CauC
            // 
            this.CauC.Text = "Câu C";
            this.CauC.Width = 74;
            // 
            // CauD
            // 
            this.CauD.Text = "Câu D";
            this.CauD.Width = 82;
            // 
            // DapAn
            // 
            this.DapAn.Text = "Đáp án";
            this.DapAn.Width = 86;
            // 
            // frmSoan_De
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSoan_De";
            this.Text = "Soạn đề thi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCauhoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvDS;
        private System.Windows.Forms.ColumnHeader Cauhoi;
        private System.Windows.Forms.ColumnHeader CauA;
        private System.Windows.Forms.ColumnHeader CauB;
        private System.Windows.Forms.ColumnHeader CauC;
        private System.Windows.Forms.ColumnHeader CauD;
        private System.Windows.Forms.ColumnHeader DapAn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.Button btnInfor;
        private System.Windows.Forms.Button btnClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSaveAns;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtMaDe;
        private System.Windows.Forms.Button btnMaDe;
        private System.Windows.Forms.Button btnExit;
    }
}

