using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ozeki.Camera;
using Ozeki.Media;


namespace TestPTZ
{
    public enum ActiveCam
    {
        Active = 1,
        nonActive
    }

#region Delegate Definition
    public delegate void CameraState(string CameraName, CameraStateEventArgs e);
#endregion
    public class Camera
    {
        private IIPCamera _camera;
        private DrawingImageProvider _Imageprovider;
        private MediaConnector _mediaConnector;
        private VideoViewerWF _videoViewer;
        public System.Windows.Forms.Panel PanelViewer;

        public event CameraState cameraState;
        public ActiveCam StateActive = ActiveCam.nonActive;
        public int IDControl;

        public string CameraName;

        public Camera()
        {
            _Imageprovider = new DrawingImageProvider();
            _mediaConnector = new MediaConnector();
            _videoViewer = new VideoViewerWF();
        }

        public void Initialize()
        {
            _videoViewer.Size = PanelViewer.Size;
            PanelViewer.Controls.Add(_videoViewer);

            _videoViewer.SetImageProvider(_Imageprovider);
        }

        public void Connect(string Domain, string userName, string Password)
        {
            if (_camera != null)
            {
                _camera.CameraStateChanged -= _CameraStateChanged;
                _camera.Disconnect();
                _mediaConnector.Disconnect(_camera.VideoChannel, _Imageprovider);
                _camera.Dispose();
                _camera = null;
            }

            //_camera = IPCameraFactory.GetCamera("192.168.7.37:80", "admin", "12345hik");
            _camera = IPCameraFactory.GetCamera(Domain, userName, Password);
            //stateCamera
            _camera.CameraStateChanged += _CameraStateChanged;
            _mediaConnector.Connect(_camera.VideoChannel, _Imageprovider);
            //_connector.Connect(_camera.VideoChannel, _snapShot);


            _camera.Start();
            _videoViewer.Start();
        }

        public void Disconnect()
        {
            _camera.CameraStateChanged -= _CameraStateChanged;
            _camera.Disconnect();
            _mediaConnector.Disconnect(_camera.VideoChannel, _Imageprovider);
            _camera.Dispose();
            _camera = null;
        }

        private void _CameraStateChanged(object sender, CameraStateEventArgs e)
        {
            if(cameraState != null)
                cameraState(CameraName, e);

            //if (e.State == CameraState.Streaming)
            //    Streaming();

            //if (e.State == CameraState.Disconnected)
            //    Disconnect();
        }

        public void Move(MoveDirection direction)
        {
            if (_camera == null) return;
            _camera.CameraMovement.ContinuousMove(direction);

            //switch (direction)
            //{
            //    case "Up Left":
            //        _camera.CameraMovement.ContinuousMove(MoveDirection.LeftUp);
            //        break;
            //    case "Up":
            //        _camera.CameraMovement.ContinuousMove(MoveDirection.Up);
            //        break;
            //    case "Up Right":
            //        _camera.CameraMovement.ContinuousMove(MoveDirection.RightUp);
            //        break;
            //    case "Left":
            //        _camera.CameraMovement.ContinuousMove(MoveDirection.Left);
            //        break;
            //    case "Right":
            //        _camera.CameraMovement.ContinuousMove(MoveDirection.Right);
            //        break;
            //    case "Down Left":
            //        _camera.CameraMovement.ContinuousMove(MoveDirection.LeftDown);
            //        break;
            //    case "Down":
            //        _camera.CameraMovement.ContinuousMove(MoveDirection.Down);
            //        break;
            //    case "Down Right":
            //        _camera.CameraMovement.ContinuousMove(MoveDirection.RightDown);
            //        break;
            //    //case "In":
            //    //    _camera.CameraMovement.Zoom(CameraMovement.In);
            //    //    break;
            //    //case "Out":
            //    //    _camera.CameraMovement.Zoom(CameraMovement.Out);
            //    //    break;
            //}
        }

        public void StopMove()
        {
            if (_camera != null)
                _camera.CameraMovement.StopMovement();
        }
    }
}
