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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
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

        private void button3_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            newAccount acc = new newAccount();
            Deposit dp = new Deposit();
            dp.Date = datelbl.Text;
            dp.AccountNo = Convert.ToDecimal(textBox1.Text);
            dp.Name = textBox2.Text;
            dp.OldBalance = Convert.ToDecimal(textBox3.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(textBox4.Text);
            //텍스트박스의 정보를 deposit에 각 컬럼에 넣은 후 정보를 반영한다.
            context.Deposits.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault(); // context 안에 있는 account_No 가 b와 같을때에 item안에 정보를 입력한다.

            item.balance = item.balance + Convert.ToDecimal(textBox4.Text);
            context.SaveChanges();
            MessageBox.Show("입금 완료");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            //item 변수에 들어있는 고객정보를 텍스트 박스에 뿌려줌
            textBox2.Text = item.Name;
            textBox3.Text = Convert.ToString(item.balance);

        }
    }
}
