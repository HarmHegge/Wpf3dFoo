using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace HHE.Wpf3dFoo.ViewModel
{
    internal sealed class LightViewModel : VisualViewModel
    {
        public Vector3D Direction { get; }

        public LightViewModel(Vector3D direction)
        {
            Direction = direction;
        }

        public override Model3D CreateModel3D()
        {
            return new DirectionalLight
            {
                Direction = Direction,
                Color = Color.FromRgb(255, 255, 255)
            };
        }
    }
}
