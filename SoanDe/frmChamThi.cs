using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SoanDe
{
    public partial class frmChamThi : Form
    {
        List<Cauhoi> lstCauhoi = new List<Cauhoi>();
        List<Cauhoi> lstExaminees = new List<Cauhoi>();
        List<KetQua> lstKetQua = new List<KetQua>();


        public frmChamThi()
        {
            InitializeComponent();
        }

        //Đọc đáp án đúng của đề bài
        private void btnCorrectAns_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "De<MaDe> .xml | *.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {
                String filepath = open.FileName;
                DeThi(filepath);
            }
            btnOpenExamAnswer.Enabled = true;
        }
        private void DeThi(string filepath)
        {
            XmlReader reader = XmlReader.Create(filepath);
            while (reader.ReadToFollowing("DapAn"))
            {
                Cauhoi cauhoi = new Cauhoi();
                reader.ReadToFollowing("DapAnDung");
                cauhoi.DapAnDung = reader.ReadElementContentAsString();
                lstCauhoi.Add(cauhoi);
            }
            reader.Close();

            foreach (var s in lstCauhoi)
            {
                txtDe.Text += s.DapAnDung;
            }
        }


        //Đọc đáp án bài làm của thí sinh
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenExamAnswer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "De_<Mã đề>_<SBD> .xml | *.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {
                String filepath = open.FileName;
                //int start = filepath.IndexOf("De");
                //txtMade.Text = filepath.Substring(start, 4);
                BaiLam(filepath);
            }
        }
        private void BaiLam(String file)
        {
            XmlReader reader = XmlReader.Create(file);
            while (reader.ReadToFollowing("BaiLam"))
            {
                Cauhoi examinee = new Cauhoi();

                reader.ReadToFollowing("ThoiGianThi");
                txtTG.Text = reader.ReadElementContentAsString();

                reader.ReadToFollowing("HoTenThiSinh");
                examinee.Name = reader.ReadElementContentAsString();

                reader.ReadToFollowing("ID-ThiSinh");
                examinee.ID = reader.ReadElementContentAsString();

                reader.ReadToFollowing("CauTraLoi");
                examinee.TraLoi = reader.ReadElementContentAsString();

                lstExaminees.Add(examinee);
            }
            reader.Close();

            foreach (var m in lstExaminees)
            {
                txthoten.Text = m.Name;
                txtSBD.Text = m.ID;
                txtBaiLam.Text += m.TraLoi;
            }
        }

        //private void btnChamBai_Click(object sender, EventArgs e)
        //{
        //    int diemThi = 0;
        //    String s = String.Empty;
        //    String m = String.Empty;

        //    foreach(var ss in lstCauhoi)
        //    {
        //        s += ss.DapAnDung;
        //        txtDe.Text = s;
        //    }

        //    foreach(var mm in lstExaminees)
        //    {
        //        m += mm.TraLoi;
        //        txtBaiLam.Text = m;
        //    }

        //    for (int i = 0; i < m.Length; i++)
        //    {
        //        if (m[i] == s[i])
        //            diemThi++;
        //        txtDiem.Text = diemThi.ToString();
        //    }
        //}

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Ket Qua .txt | *txt";
            if(save.ShowDialog() == DialogResult.OK)
            {
                String filepath = save.FileName;
                KetQua(filepath);
            }
        }
        private void KetQua(string filepath)
        {
            StreamWriter writer = File.CreateText(filepath);
            foreach (var s in lstKetQua)
            {
                String kq = s.name + "|" + s.Id + "|" + s.Diem + "|" + s.thoiGianThi;
            }
            writer.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Visible = false;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diemThi = 0;
            String s = String.Empty;
            String m = String.Empty;

            foreach (var ss in lstCauhoi)
            {
                s += ss.DapAnDung;
                txtDe.Text = s;
            }

            foreach (var mm in lstExaminees)
            {
                m += mm.TraLoi;
                txtBaiLam.Text = m;
            }

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == s[i])
                    diemThi++;
                txtDiem.Text = diemThi.ToString();
            }
        }
    }
}
