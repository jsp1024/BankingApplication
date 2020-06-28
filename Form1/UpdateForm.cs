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
    public partial class UpdateForm : Form
    {

        banking_dbEntities dbe;
        MemoryStream ms;
        BindingList<userAccount> bi; //배열안에 사용자 계좌 정보를 입력한다.

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(accnotext.Text);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno);//Account_No의 값이 텍스트 박스에 입력한 계좌번호와 같을때에 정보를 불러온다
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi; //데이터를 표시한다.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();
            var item = dbe.userAccounts.Where(a => a.Name == nametxt.Text);//이름이 db에 있을경우 list박스에 출력한다.
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno).FirstOrDefault();
            accnotext.Text = item.Account_No.ToString();
            nametxt.Text = item.Name;
            mothertxt.Text = item.Mother_Name;
            fathertxt.Text = item.Father_Name;
            phonetxt.Text = item.PhoneNo;
            adresstxt.Text = item.Address;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            disttxt.Text = item.District;
            comboBox1.Text = item.State;
            if(item.Gender == "male")
            {
                maleradio.Checked = true;
            }
            else if (item.Gender == "female")
            {
                femaleradio.Checked = true;
            }
            else if (item.martial_status == "married")
            {
                marriedradio.Checked = true;
            } 
            else if (item.martial_status == "unmarried")
            {
                unmarriedradio.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendig = new OpenFileDialog();

            if(opendig.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendig.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {   //선택되어 있는 정보들을 전부 삭제 한 후 저장한다.
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dbe = new banking_dbEntities();
            decimal a = Convert.ToDecimal(accnotext.Text);
            userAccount acc = dbe.userAccounts.First(s => s.Account_No.Equals(a));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {   //db에 있는 계좌번호와 텍스트박스에 계좌번호가 일치 할 때 기존에 있는 정보를 새롭게 업데이트 시킨다.
            dbe = new banking_dbEntities();
            decimal accuntno = Convert.ToDecimal(accnotext.Text);
            userAccount useraccount = dbe.userAccounts.First(s => s.Account_No.Equals(accuntno));
            useraccount.Account_No = Convert.ToDecimal(accnotext.Text);
            useraccount.Name = nametxt.Text;
            useraccount.Date = dateTimePicker1.Value.ToString();
            useraccount.Mother_Name = mothertxt.Text;
            useraccount.Father_Name = fathertxt.Text;
            useraccount.PhoneNo = phonetxt.Text;
            if (maleradio.Checked == true)
            {
                useraccount.Gender = "남자";
            } 
            else if(femaleradio.Checked == true)
            {
                useraccount.Gender = "여자";
            }
            
            if(maleradio.Checked == true)
            {
                useraccount.martial_status = "기혼";
            }
            else if(unmarriedradio.Checked == true)
            {
                useraccount.martial_status = "미혼";
            }
            Image img = pictureBox1.Image;
            if (img.RawFormat != null)
            {
                if (ms != null)
                {
                    img.Save(ms, img.RawFormat);
                    useraccount.Picture = ms.ToArray();
                }
            }
            useraccount.Address = adresstxt.Text;
            useraccount.District = disttxt.Text;
            useraccount.State = comboBox1.Text;
            dbe.SaveChanges();
            MessageBox.Show("업데이트 완료");
        }
    }
}
