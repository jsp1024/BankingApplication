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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
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
            if (oldpass.Text != string.Empty || newpass.Text !=string.Empty || newpasscheck.Text != string.Empty)
            {
                Admin_Table user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(nametxt.Text));
                if (user1 != null)
                {   //관리자의 계정의 기존 비밀번호가 db랑 같을경우 새로운 비밀번호를 입력했을 시에 비밀번호를 변경하게 된다.
                    if (user1.Password.Equals(oldpass.Text))
                    {
                        user1.Password = newpass.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("비밀번호 변경 완료");
                    } else
                    {
                        MessageBox.Show("변경 실패");
                    }
                }
            }
        }
    }
}
