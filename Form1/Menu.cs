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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            newAccount newacc = new newAccount();
            //부모폼을 불러온다.
            newacc.MdiParent = this.MdiParent;
            newacc.Show();
            this.Close();
        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm up = new UpdateForm();
            up.MdiParent = this.MdiParent;
            up.Show();
            this.Close();
        }

        private void allCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList cl = new CustomerList();
            cl.MdiParent = this.MdiParent;
            cl.Show();
            this.Close();
        }

        private void DepositMenuitem_Click(object sender, EventArgs e)
        {
            CreditForm crdfrm = new CreditForm();
            crdfrm.MdiParent = this.MdiParent;
            crdfrm.Show();
            this.Close();
        }

        private void WidthdrawManuitem_Click(object sender, EventArgs e)
        {
            DabitForm dpf = new DabitForm();
            dpf.MdiParent = this.MdiParent;
            dpf.Show();
            this.Close();
        }

        private void TransferMenuitem_Click(object sender, EventArgs e)
        {
            TransferForm tf = new TransferForm();
            tf.MdiParent = this.MdiParent;
            tf.Show();
            this.Close();
        }

        private void FDformMenuitem_Click(object sender, EventArgs e)
        {
            FDform fdf = new FDform();
            fdf.MdiParent = this.MdiParent;
            fdf.Show();
            this.Close();
        }

        private void BalanceSheetMenuitem_Click(object sender, EventArgs e)
        {
            balanceSheet bls = new balanceSheet();
            bls.MdiParent = this.MdiParent;
            bls.Show();
            this.Close();
        }

        private void ViewFDMenuitem_Click(object sender, EventArgs e)
        {
            ViewFD viewFD = new ViewFD();
            viewFD.MdiParent = this.MdiParent;
            viewFD.Show();
            this.Close();
        }

        private void LogoutMenuitem_Click(object sender, EventArgs e)
        {
            Login_form lf = new Login_form();
            lf.Show();
            this.Close();
        }

        private void ChangePasswordMenuitem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpf = new ChangePasswordForm();
            cpf.MdiParent = this.MdiParent;
            cpf.Show();
            this.Close();
        }
    }
}
