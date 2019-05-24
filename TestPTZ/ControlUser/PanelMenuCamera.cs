using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPTZ.ControlUser
{
    public partial class PanelMenuCamera : UserControl
    {
        public int IDControl;
        private Camera cam;
        public PanelMenuCamera()
        {
            InitializeComponent();
        }

        public void SetCameraProperty(Camera name)
        {
            cam = name;
            name.PanelViewer = pnlViewer;
            lblMenu.Text = name.CameraName;
        }
    }
}
