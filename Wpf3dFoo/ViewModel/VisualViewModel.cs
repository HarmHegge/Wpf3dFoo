using System.Windows.Media.Media3D;

namespace HHE.Wpf3dFoo.ViewModel
{
    internal abstract class VisualViewModel
    {
        public abstract Model3D CreateModel3D();
    }
}
