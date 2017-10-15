using System.Windows.Media.Media3D;

namespace HHE.Wpf3dFoo.ViewModel
{
    internal sealed class CameraViewModel
    {
        public Point3D Position { get; }
        public Vector3D LookDirection { get; }
        public Vector3D UpDirection { get; }
       
        public CameraViewModel(Point3D position, Vector3D lookDirection, Vector3D upDirection)
        {
            Position = position;
            LookDirection = lookDirection;
            UpDirection = upDirection;
        }
    }
}
