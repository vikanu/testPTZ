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
    public partial class frmConnect : Form
    {
        private Camera _cameraActiv;
        public Camera cameraActive { 
            get{
                return _cameraActiv;
            }
            set { 
                _cameraActiv = value; 
            } 
        }
        public frmConnect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cameraActive != null)
                cameraActive.Connect(txtAddress.Text, txtUsername.Text, txtPassword.Text);

            Close();
        }
        
    }
}
