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
    public partial class PanelUser : UserControl
    {
        int LocationY = 10;
        int LocationX = 10;
        int IDControl = 0;
        public PanelUser()
        {
            InitializeComponent();
        }

        public void AddPanel(Camera cam)
        {
            UserControl UsrCtrl1 = new PanelMenuCamera();
            ((PanelMenuCamera)UsrCtrl1).IDControl = IDControl;
            UsrCtrl1.BackColor = Color.DarkGray;
            cam.IDControl = IDControl;
            ((PanelMenuCamera)UsrCtrl1).SetCameraProperty(cam);


            UsrCtrl1.Location = new Point(LocationX, LocationY);

            if ((UsrCtrl1.Right + 20) >= this.Width)
            {
                LocationY = UsrCtrl1.Location.Y + UsrCtrl1.Height + 10;
                LocationX = 10;
            }
            else
                LocationX = UsrCtrl1.Location.X + UsrCtrl1.Width + 10;

            //UsrCtrl1.Width = this.Width - 50;

            pnlSlide.Controls.Add(UsrCtrl1);

            if (UsrCtrl1.Bottom >= this.Height)
                this.Height += 275;

            this.Refresh();

            IDControl++;
        }

        public void RemovePanel(int IDPanel)
        {
            //to remove control by ID
            foreach (UserControl item in pnlSlide.Controls)
            {
                if (((PanelMenuCamera)item).IDControl == IDPanel)
                {
                    pnlSlide.Controls.Remove(item);
                    break;
                }
            }
        }
    }
}
