using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class DabitForm : Form
    {
        public DabitForm()
        {
            InitializeComponent();
            loadmode();
        }

        private void loadmode()
        {
            comboBox1.Items.Add("현금");
            comboBox1.Items.Add("수표");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retrievedata();
        }

        private void retrievedata()
        {   //계좌번호 텍스트 박스에 있는 정보를 토대로 db에서 고객의 정보를 받아온다.
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name;
            oldbalancetxt.Text = Convert.ToString(item.balance);
        }

        private void savedata()
        {   //각 텍스트 박스에 있는 정보를 debit테이블에 넣은후 데이터를 저장시킨다
            banking_dbEntities dbe = new banking_dbEntities();
            newAccount nacc = new newAccount();
            debit dp = new debit();
            dp.Date = DateTime.UtcNow.ToString("MM/dd/yyyy");
            dp.Account = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalace = Convert.ToDecimal(oldbalancetxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DebAmount = Convert.ToDecimal(amounttxt.Text);
            dbe.debits.Add(dp);
            dbe.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            item.balance = item.balance - Convert.ToDecimal(amounttxt.Text);
            dbe.SaveChanges();
            MessageBox.Show("인출 완료");
        }

    }
}
