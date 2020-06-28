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

namespace Form1
{
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities BSE;
        MemoryStream ms; //백업 저장소가 메모리인 스트림을 생성해 준다.
     
        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            comboBox1.Items.Add("고객");
        }

        private void loadaccount()
        {   
            /* 계좌번호 텍스트 박스에 자동으로 새로운 계좌번호를 입력하되 만약 계좌번호가 중복일 시에 
             가장 최근에 만들어진 계좌번호에 1을 더하여서 텍스트 박스에 출력한다.*/
            BSE = new banking_dbEntities();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accnotext.Text = Convert.ToString(no);

        }

        private void loaddate()
        {
            datelbl.Text = DateTime.Now.ToString("yyyy년dd월mm일");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {   //이미지 파일을 메모리 스트림에 저장한다.
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maleradio.Checked)
            {
                gender = "남자";
            }
            else if (femaleradio.Checked)
            {
                gender = "여자";
            }
            if (marriedradio.Checked)
            {
                m_status = "기혼";
            }
            else if (unmarriedradio.Checked)
            {
                m_status = "미혼";
            }
            //텍스트 박스와 체크박스 및 입력된 정보들을 db에 저장시킨다.
            BSE = new banking_dbEntities();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonetxt.Text;
            acc.Address = adresstxt.Text;
            acc.District = disttxt.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.martial_status = m_status;
            acc.Father_Name = fathertxt.Text;
            acc.Mother_Name = mothertxt.Text;
            acc.balance = Convert.ToDecimal(balancetxt.Text);
            acc.Date = datelbl.Text;
            acc.Picture = ms.ToArray();
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("세이브 완료");
        }
    }
}
