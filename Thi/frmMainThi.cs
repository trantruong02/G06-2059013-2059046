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

namespace Thi
{
    public partial class frmMainThi : Form
    {
        List<Question> lstQues = new List<Question>();

        //int CauHienTai;
        int CauHienTai = 0;
        private int count = 15; //Thời gian trung bình cho 1 câu hỏi
        String time;

        public frmMainThi()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
/*------------------------------------------------------------------------------------------------------------------------------*/
        //Tính thời gian thi 
        private void timerTick_Tick(object sender, EventArgs e)
        {
            count--;
            if(count == 0)
            {
                timerTick.Stop();
                MessageBox.Show("Hết thời gian làm bài!!!", "Thông báo!!!");
                rbA.Enabled = false;
                rbB.Enabled = false;
                rbC.Enabled = false;
                rbD.Enabled = false;
                btnNext.Enabled = false;
                btnPre.Enabled = false;
                btnDone.Enabled = false;
                btnStart.Enabled = false;
                //Hết thời gian thì hệ thống vô hiệu hóa các button cần thiết
            }
            txtTime.Text = count.ToString();
        }
/*------------------------------------------------------------------------------------------------------------------------------*/

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Thông tin thí sinh trước khi bắt đầu thi !!!", "Thông báo");
            }
            else
            {
                timerTick.Start();
                count = count * lstQues.Count; //thời gian thi * số câu hỏi có trong đề thi (lstCauHoi)

                btnNext.Enabled = true;
                btnPre.Enabled = true;

                rbA.Enabled = true;
                rbB.Enabled = true;
                rbC.Enabled = true;
                rbD.Enabled = true;
            }

        }

/*------------------------------------------------------------------------------------------------------------------------------*/
        /* Load file đề (xml) lên chương trfinh để bắt đầu thi*/
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "De<MaDe> .xml | *.xml";
            if(open.ShowDialog() == DialogResult.OK)
            {
                String filepath = open.FileName;
                ReadFile(filepath);
            }
            btnStart.Enabled = true;
        }
        private void ReadFile(String filepath)
        {
            XmlReader reader = XmlReader.Create(filepath);
            while (reader.ReadToFollowing("CauHoi"))
            {
                Question question = new Question();
                reader.ReadToFollowing("NoiDungCauHoi");
                question.CauHoi = reader.ReadElementContentAsString();

                reader.ReadToFollowing("A");
                question.CauA = reader.ReadElementContentAsString();

                reader.ReadToFollowing("B");
                question.CauB = reader.ReadElementContentAsString();

                reader.ReadToFollowing("C");
                question.CauC = reader.ReadElementContentAsString();

                reader.ReadToFollowing("D");
                question.CauD = reader.ReadElementContentAsString();
                lstQues.Add(question);
            }

            reader.Close();
             
            foreach(var s in lstQues)
            {
                txtCauHoi.Text = s.CauHoi;
                txtA.Text = s.CauA;
                txtB.Text = s.CauB;
                txtC.Text = s.CauC;
                txtD.Text = s.CauD;
            }
        }
/*------------------------------------------------------------------------------------------------------------------------------*/

        private void ResetRadioButton(string a)
        {
            if (a == rbA.Text)
                rbA.Checked = true;
            else if (a == rbB.Text)
                rbB.Checked = true;
            else if (a == rbC.Text)
                rbC.Checked = true;
            else if (a == rbD.Text)
                rbD.Checked = true;
            else
            {
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;
            }
        }
/*------------------------------------------------------------------------------------------------------------------------------*/
       
        /* Các button để xem câu trước và câu sau*/
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CauHienTai < lstQues.Count - 1)
            {
                CauHienTai++;
                ResetRadioButton(lstQues[CauHienTai].CauTraLoi);
                txtCauHoi.Text = lstQues[CauHienTai].CauHoi;
                txtA.Text = lstQues[CauHienTai].CauA;
                txtB.Text = lstQues[CauHienTai].CauB;
                txtC.Text = lstQues[CauHienTai].CauC;
                txtD.Text = lstQues[CauHienTai].CauD;
            }
        }
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (CauHienTai > 0)
            {
                CauHienTai--;
                ResetRadioButton(lstQues[CauHienTai].CauTraLoi);

                txtCauHoi.Text = lstQues[CauHienTai].CauHoi;
                txtA.Text = lstQues[CauHienTai].CauA;
                txtB.Text = lstQues[CauHienTai].CauB;
                txtC.Text = lstQues[CauHienTai].CauC;
                txtD.Text = lstQues[CauHienTai].CauD;
            }
        }

/*------------------------------------------------------------------------------------------------------------------------------*/
        
        //button Hoàn thành: Kết thúc bài thi và lưu ra file xml.
        private void btnDone_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "De_<MaDe>_<MSSV> .xml | *.xml";
            if(save.ShowDialog() == DialogResult.OK)
            {
                String filepath = save.FileName;
                LuuBaiLam(filepath);
            }
        }
        private void LuuBaiLam(string filepath)
        {
            time = DateTime.Now.ToString();
            XmlWriter writer = XmlWriter.Create(filepath, new XmlWriterSettings() { Indent = true });
            writer.WriteStartElement("BaiLam");

            writer.WriteStartElement("ThoiGianThi");
            writer.WriteValue(time);
            writer.WriteEndElement();

            writer.WriteStartElement("HoTenThiSinh");
            writer.WriteValue(txtName.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("ID-ThiSinh");
            writer.WriteValue(txtID.Text);
            writer.WriteEndElement();

            writer.WriteStartElement("CauTraLoi");
            for (int i = 0; i < lstQues.Count; i++)
            {
                writer.WriteValue(lstQues[i].CauTraLoi);
            }
            writer.WriteEndElement();


            writer.WriteEndElement();
            writer.Close();
        }

/*------------------------------------------------------------------------------------------------------------------------------*/
       
        /*Check chung quy chọn đáp án cho từng câu hỏi
         nếu có chọn (không cần biết đáp án nào)
        thì trả về    "true" - Đã chọn đáp án cho câu hỏi
                     "false" - Chưa chọn đáp án cho câu hỏi */
        private bool SelectCheck()
        {
            if (rbA.Checked == true || rbB.Checked == true || rbC.Checked == true || rbD.Checked == true)
                return true;
            return false;
        }
        /*Nếu đã chọn đc đáp án cho câu hỏi thì sẽ lưu lại đáp án vừa chọn cho câu hỏi hiện tại
        Và gán các giá trị tương ứng cho từng đáp án [A B C D] thành [1 2 3 4] để tiện cho việc dò đáp án đúng*/
        private void LuuCauTraLoi()
        {
            if (SelectCheck() == true)
            {
                if (rbA.Checked == true)
                    lstQues[CauHienTai].CauTraLoi = rbA.Text;
                else if (rbB.Checked == true)
                    lstQues[CauHienTai].CauTraLoi = rbB.Text;
                else if (rbC.Checked == true)
                    lstQues[CauHienTai].CauTraLoi = rbC.Text;
                else
                    lstQues[CauHienTai].CauTraLoi = rbD.Text;
            }
            else
                lstQues[CauHienTai].CauTraLoi = "";
        }

/*------------------------------------------------------------------------------------------------------------------------------*/

        /* Sửa/Cập nhập lại đáp án cho câu hỏi hiện tại*/
        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            LuuCauTraLoi();
        }
        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            LuuCauTraLoi();
        }
        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            LuuCauTraLoi();
        }
        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            LuuCauTraLoi();
        }

    }
}
