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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {  //고객의 정보를 db에서 받아와서 datagridview에 뿌려줌
           // 단 datagridview에 명시되어 있는 컬럼만 보여주도록 설정함
            dataGridView1.AutoGenerateColumns = false;
            banking_dbEntities bs = new banking_dbEntities();
            var item = bs.userAccounts.ToList();
            dataGridView1.DataSource = item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
