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
    public partial class FDform : Form
    {
        public FDform()
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
            
            banking_dbEntities dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(accnotxt.Text);
            var accounts = dbe.userAccounts.Where(x => x.Account_No == accno).SingleOrDefault();
            FD fdform = new FD();
            fdform.Account_No = Convert.ToDecimal(accnotxt.Text);
            fdform.Mode = comboBox1.SelectedItem.ToString();
            fdform.Money = moneytxt.Text;
            fdform.Period = Convert.ToInt32(periodtxt.Text);
            fdform.Interest_rate = Convert.ToDecimal(interesttxt.Text);
            fdform.Start_Date = DateTime.UtcNow.ToString("MM/dd/yyyy");
            fdform.Maturity_Date = (DateTime.UtcNow.AddDays(Convert.ToInt32(periodtxt.Text))).ToString("MM/dd/yyyy");
            fdform.Maturity_Amount = ((Convert.ToDecimal(moneytxt.Text) * Convert.ToInt32(periodtxt.Text) * Convert.ToDecimal(interesttxt.Text)) /
                (100 * 12 * 30)) + (Convert.ToDecimal(moneytxt.Text));
            //신청일로 부터 만기일 까지 돈을 예금 후 이자율을 계산해서 돈을 합산한다.
            dbe.FDs.Add(fdform);
            decimal amount = Convert.ToDecimal(moneytxt.Text);
            decimal totalamount = Convert.ToDecimal(accounts.balance);
            decimal fdamount = totalamount - amount;
            accounts.balance = fdamount;

            dbe.SaveChanges();
            MessageBox.Show("정기예금 시작");
            

        }
    }
}
