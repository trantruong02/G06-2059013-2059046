using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SoanDe
{
    public partial class frmSoanDe : Form
    {
        BindingList<Cauhoi> lstCauHoi = new BindingList<Cauhoi>();
        Cauhoi dapAn = new Cauhoi();

        //list lưu đáp án cho đề
        List<Cauhoi> lstDapAnTongThe = new List<Cauhoi>();

        public frmSoanDe()
        {
            InitializeComponent();
        }

        // Các button cơ bản

        //Thêm phần tử mới vào danh sách câu hỏi
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtCauhoi.Text == "" || txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "")
            {
                MessageBox.Show("Please fill in all information to perform the operation [Thêm].", "Attention please !!!");
            }
            else if (rdA.Checked == false && rdB.Checked == false && rdC.Checked == false && rdD.Checked == false)
            {
                MessageBox.Show("Please select the right answer for the question please.", "Attention !!!");
            }
            else
            {
                ListViewItem list = new ListViewItem(txtCauhoi.Text);
                list.SubItems.Add(txtA.Text);
                list.SubItems.Add(txtB.Text);
                list.SubItems.Add(txtC.Text);
                list.SubItems.Add(txtD.Text);
           
                Cauhoi cauhoi = new Cauhoi();
                cauhoi.CauHoi = txtCauhoi.Text;
                cauhoi.Dan_A = txtA.Text;
                cauhoi.Dan_B = txtB.Text;
                cauhoi.Dan_C = txtC.Text;
                cauhoi.Dan_D = txtD.Text;
                

                if (rdA.Checked == true)
                {
                    list.SubItems.Add(rdA.Text);
                    cauhoi.DapAnDung = rdA.Text;
                }
                else if (rdB.Checked == true)
                {
                    list.SubItems.Add(rdB.Text);
                    cauhoi.DapAnDung = rdB.Text;
                }
                else if (rdC.Checked == true)
                {
                    list.SubItems.Add(rdC.Text);
                    cauhoi.DapAnDung = rdC.Text;
                }
                else
                {
                    list.SubItems.Add(rdD.Text);
                    cauhoi.DapAnDung = rdD.Text;
                }
                lvDS.Items.Add(list);
                lstCauHoi.Add(cauhoi);
            }

            txtCauhoi.Text = txtA.Text = txtB.Text = txtC.Text = txtD.Text = String.Empty;
            rdA.Checked = rdB.Checked = rdC.Checked = rdD.Checked = false;
        }

        //Xóa 1 phần tử trong danh sách câu hỏi.
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
                lvDS.Items.Remove(lvDS.SelectedItems[0]);
            else
                MessageBox.Show("Chọn ít nhất 1 dòng để xoá", "Thông báo");
        }

        //Sửa lại câu hỏi hoạc đáp án cho câu hỏi
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
            {
                lvDS.SelectedItems[0].SubItems[0].Text = txtCauhoi.Text;
                lvDS.SelectedItems[0].SubItems[1].Text = txtA.Text;
                lvDS.SelectedItems[0].SubItems[2].Text = txtB.Text;
                lvDS.SelectedItems[0].SubItems[3].Text = txtC.Text;
                lvDS.SelectedItems[0].SubItems[4].Text = txtD.Text;

                if (rdA.Checked == true)
                    lvDS.SelectedItems[0].SubItems[5].Text = rdA.Text;
                else if (rdB.Checked == true)
                    lvDS.SelectedItems[0].SubItems[5].Text = rdB.Text;
                else if (rdC.Checked == true)
                    lvDS.SelectedItems[0].SubItems[5].Text = rdC.Text;
                else
                    lvDS.SelectedItems[0].SubItems[5].Text = rdD.Text;
            }
            else
                MessageBox.Show("Select at least 1 element to perform the operation.", "Attention please !!!");
        }

        //Chọn item trong listview
        private void lvDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
            {
                txtCauhoi.Text = lvDS.SelectedItems[0].SubItems[0].Text;
                txtA.Text = lvDS.SelectedItems[0].SubItems[1].Text;
                txtB.Text = lvDS.SelectedItems[0].SubItems[2].Text;
                txtC.Text = lvDS.SelectedItems[0].SubItems[3].Text;
                txtD.Text = lvDS.SelectedItems[0].SubItems[4].Text;
            }
            //https://www.youtube.com/watch?v=5DKd08qO39M&t=1172s/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Luu lại đề vừa soạn
        private void LuuDeThi(string filepath)
        {
            XmlWriter writer = XmlWriter.Create(filepath, new XmlWriterSettings() { Indent = true });
            //https://social.msdn.microsoft.com/Forums/en-US/19b9c067-fb62-4d2d-bd39-789c35f9d4a0/c-how-to-write-data-from-listview-to-xml-and-back

            writer.WriteStartElement("DeThi");
            for (int i = 0; i < lvDS.Items.Count; i++)
            {
                writer.WriteStartElement("CauHoi");
                writer.WriteStartElement("NoiDungCauHoi");
                String cauhoi = lvDS.Items[i].SubItems[0].Text;
                writer.WriteValue(cauhoi);
                writer.WriteEndElement();

                writer.WriteStartElement("A");
                String A = lvDS.Items[i].SubItems[1].Text;
                writer.WriteValue(A);
                writer.WriteEndElement();

                writer.WriteStartElement("B");
                String B = lvDS.Items[i].SubItems[2].Text;
                writer.WriteValue(B);
                writer.WriteEndElement();

                writer.WriteStartElement("C");
                String C = lvDS.Items[i].SubItems[3].Text;
                writer.WriteValue(C);
                writer.WriteEndElement();

                writer.WriteStartElement("D");
                String D = lvDS.Items[i].SubItems[4].Text;
                writer.WriteValue(D);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "De<MaDe>.xml | *.xml";
            if(save.ShowDialog() == DialogResult.OK)
            {
                String filepath = save.FileName;
                LuuDeThi(filepath);
            } 
        }

        //Lưu đáp án riêng cho câu hỏi
        private void btnSaveAns_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAnswer = new SaveFileDialog();
            saveAnswer.Filter = "DapAn<MaDe>.xml | *.xml";
            if (saveAnswer.ShowDialog() == DialogResult.OK)
            {
                String filepath2 = saveAnswer.FileName;
                LuuDapAnDung(filepath2);
            }
        }
        private void LuuDapAnDung(String filepath2)
        {
            Cauhoi DapAnDung = new Cauhoi();
            XmlWriter writer = XmlWriter.Create(filepath2, new XmlWriterSettings() { Indent = true });
            writer.WriteStartElement("DapAn");

            writer.WriteStartElement("DapAnDung");
            for (int i = 0; i < lvDS.Items.Count; i++)
            {
                writer.WriteValue(lvDS.Items[i].SubItems[5].Text);
                lstDapAnTongThe.Add(DapAnDung);
            }
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.Close();

        }


        //Thông tin chi tiết
        private void btnInfor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Hào Quách + Trân Trương", "Thông tin chi tiết");
        }

        //Xóa toàn bộ câu hỏi (làm lại đề mới)
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCauHoi.Clear();
            lvDS.Items.Clear();
        }


        private void btnMaDe_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int MaDeThi = rd.Next(1, 100);
            txtMaDe.Text = MaDeThi.ToString();
        }
    }
}
