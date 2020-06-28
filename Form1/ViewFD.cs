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
    public partial class ViewFD : Form
    {
        BindingList<FD> bi;
        banking_dbEntities dbe;

        public ViewFD()
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
        {   //db에서 고객의 정기예금 정보를 받아서 리스트형태로 보여준다.
            bi = new BindingList<FD>();
            dbe = new banking_dbEntities();
            string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            MessageBox.Show(date);
            var item = dbe.FDs.Where(a => a.Start_Date.Equals(date));
            dataGridView1.DataSource = item.ToList();
        }
    }
}
