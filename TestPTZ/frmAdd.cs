using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPTZ
{
    public partial class frmAdd : Form
    {
        public DialogResult dgResult;
        public string Addr;
        public string UserName;
        public string Password;

        public frmAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addr = txtAddress.Text;
            UserName = txtUsername.Text;
            Password = txtPassword.Text;

            dgResult = DialogResult.OK;

            Close();
        }
    }
}
