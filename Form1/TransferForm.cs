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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //버튼 클릭시 입력한 본인계좌가 db에 있을시에 자기 이름과 잔액을 보여준다.
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name;
            amounttxt.Text = Convert.ToString(item.balance);

        }

        private void button3_Click(object sender, EventArgs e)
        {   
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.balance);
            decimal totalbal = Convert.ToDecimal(transfertxt.Text);
            decimal transferacc = Convert.ToDecimal(desaccounttxt.Text);
            //보낼 돈의 금액이 본인 계좌의 돈보다 적을시에 송금을 실행한다.
            if (b1 > totalbal)
            {
                userAccount item2 = (from u in dbe.userAccounts
                                     where u.Account_No == transferacc
                                     select u).FirstOrDefault();
                item2.balance = item2.balance + totalbal;
                item.balance = item.balance - totalbal;
                Transfer transfer = new Transfer();
                transfer.Account_No = Convert.ToDecimal(fromacctxt.Text);
                transfer.ToTransfer = Convert.ToDecimal(desaccounttxt.Text);
                //송금한 시간을 기입한다.
                transfer.Date = DateTime.UtcNow.ToString();
                transfer.Name = nametxt.Text;
                transfer.balance = Convert.ToDecimal(transfertxt.Text);

                dbe.Transfers.Add(transfer);
                dbe.SaveChanges();
                MessageBox.Show("송금완료");
            }
           
        }
    }
}
