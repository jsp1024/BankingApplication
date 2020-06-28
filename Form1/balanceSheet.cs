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
    public partial class balanceSheet : Form
    {
        public balanceSheet()
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
        {
           
            banking_dbEntities dbe = new banking_dbEntities();
            // DB에서 받아온 고객의 정보를 받아서 리스트로 변환하여 보여준다
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in dbe.debits
                        where u.Account == b
                        select u);
            dataGridView1.DataSource = item.ToList();
            var item1 = (from u in dbe.Deposits
                         where u.AccountNo == b
                         select u);
            dataGridView2.DataSource = item1.ToList();
            var item2 = (from u in dbe.Transfers
                         where u.Account_No == b
                         select u);
            dataGridView3.DataSource = item2.ToList();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
        }
    }
}
