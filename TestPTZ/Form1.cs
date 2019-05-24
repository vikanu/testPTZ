using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPTZ.ControlUser;
using Ozeki.Camera;
using Ozeki.Media;

namespace TestPTZ
{
    public partial class Form1 : Form
    {
        private UserControl UsrCtrl1 = new PanelUser();

        private Camera ActiveCamera = null;

        private frmConnect connnection;
        private frmAdd AddCamera;

        private int IDCamera = 0;

        public Form1()
        {
            InitializeComponent();

            //initialize tag button
            btnLeft.Tag = MoveDirection.Left;
            btnRight.Tag = MoveDirection.Right;
            btnUp.Tag = MoveDirection.Up;
            btnDown.Tag = MoveDirection.Down;
            btnUpLeft.Tag = MoveDirection.LeftUp;
            btnUpRight.Tag = MoveDirection.RightUp;
            btnDownLeft.Tag = MoveDirection.LeftDown;
            btnDownRight.Tag = MoveDirection.RightDown;

            UsrCtrl1.Location = new System.Drawing.Point(0, 0);
            UsrCtrl1.Width = pnlMenuFloating.Width;
            UsrCtrl1.Height = pnlMenuFloating.Height;

            
            pnlMenuFloating.Controls.Add(UsrCtrl1);
        }

        void InvokeThread(Action action)
        {
            BeginInvoke(action);
        }

        void CameraStateChanged(string CameraName, CameraStateEventArgs e)
        {
            InvokeThread(() =>
            {
                listBox1.Items.Add(CameraName + " : " + e.State.ToString());
            });
        }

        private void MouseDownMove(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            var moveDirection = (MoveDirection)((Button)sender).Tag;

            if (ActiveCamera != null)
            {
                ActiveCamera.Move(moveDirection);

                listBox1.Items.Add(ActiveCamera.CameraName + " : Direction Move " + moveDirection.ToString());
            }
        }

        private void MouseUpMove(object sender, MouseEventArgs e)
        {
            if (ActiveCamera != null)
                ActiveCamera.StopMove();
        }

        ListViewItem FindItemWithTag(ListView lv, object tag)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                if (lv.Items[i].Tag == tag)
                    return lv.Items[i];
            }
            return null;
        }

        private void lvCameraList_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem _LVitem = new ListViewItem();
            _LVitem = lvCameraList.FocusedItem;

            if (_LVitem.Tag == this.ActiveCamera)
                return;

            //set camera to non active 
            this.ActiveCamera.StateActive = ActiveCam.nonActive;

            ListViewItem item;
            item = FindItemWithTag(lvCameraList, this.ActiveCamera);
            if (item != null)
            {
                item.SubItems[1].Text = this.ActiveCamera.StateActive.ToString();
            }

            ((Camera)_LVitem.Tag).StateActive = ActiveCam.Active;

            _LVitem.SubItems[1].Text = ((Camera)_LVitem.Tag).StateActive.ToString();
            this.ActiveCamera = ((Camera)_LVitem.Tag);
        }

        private void MenuStrip(object sender, EventArgs e)
        {
            string st = ((ToolStripItem)sender).Tag.ToString();
            int tag;
            int.TryParse(st, out tag);

            switch (tag)
            {
                case 0: //Add
                    AddCamera = new frmAdd();
                    AddCamera.ShowDialog();

                    if (AddCamera.dgResult == DialogResult.OK)
                    {
                        //create Camera
                        Camera cam;
                        cam = new Camera();
                        cam.CameraName = "Camera_" + IDCamera.ToString();
                        //camera2.PanelViewer = pnlViewer2;

                        //add camera to user control
                        ((PanelUser)UsrCtrl1).AddPanel(cam);
                        cam.cameraState += CameraStateChanged;
                        cam.Initialize();

                        if (ActiveCamera == null)
                        {
                            ActiveCamera = cam;
                            cam.StateActive = ActiveCam.Active;
                        }

                        //add Camera object to listview
                        ListViewItem li = new ListViewItem();
                        li.Text = cam.CameraName;
                        li.Tag = cam;
                        li.Name = cam.CameraName;
                        li.SubItems.Add(cam.StateActive.ToString());
                        lvCameraList.Items.Add(li);

                        //increment idcamera
                        IDCamera++;
                    }
                    break;
                case 1: //Delete
                    if (ActiveCamera != null)
                    {
                        ((PanelUser)UsrCtrl1).RemovePanel(ActiveCamera.IDControl);

                        ListViewItem item;
                        item = FindItemWithTag(lvCameraList, this.ActiveCamera);
                        if (item != null)
                        {
                            lvCameraList.Items.Remove(item);
                        }
                    }
                    break;
                case 2: //Connect
                    connnection = new frmConnect();
                    connnection.cameraActive = this.ActiveCamera;
                    connnection.Show();
                    break;
                case 3://Disconnect
                    this.ActiveCamera.Disconnect();
                    break;
            }
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            if (UsrCtrl1.Bottom >= pnlMenuFloating.Top + pnlMenuFloating.Height)
            {
                UsrCtrl1.Top -= 5;
            }
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            if (UsrCtrl1.Top < 0)
            {
                UsrCtrl1.Top += 5;
            }
        }

        private void btnDownPanel_MouseDown(object sender, MouseEventArgs e)
        {
            tmrDown.Start();
        }

        private void btnDownPanel_MouseUp(object sender, MouseEventArgs e)
        {
            tmrDown.Stop();
        }

        private void btnUpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            tmrUp.Start();
        }

        private void btnUpPanel_MouseUp(object sender, MouseEventArgs e)
        {
            tmrUp.Stop();
        }
    }
}
