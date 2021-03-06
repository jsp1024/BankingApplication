﻿using System;
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
    public partial class Login_form : Form
    {
       
        public Login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //db 연결
            banking_dbEntities dbe = new banking_dbEntities();
            
            
            /*유저네임과 비밀번호가 공백이 아닐시에 유저네임과 비밀번호를
            db에 있는 정보와 비교한 후 일치 할때에 접속이 되게 한다.*/
            if(usertxt.Text!=string.Empty || passtxt.Text != string.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usertxt.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(passtxt.Text))
                    {   //
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("비밀번호를 다시 입력해 주세요.");
                    }
                }
                else
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 확인해 주세요.");
                }
            }   
            else
            {
                MessageBox.Show("아이디와 비밀번호를 입력해 주세요.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   //폼 닫기
            this.Close();
        }

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
        {   //비밀번호 입력을 마친 후 엔터키를 누르면 버튼이 클릭되게 한다.
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
