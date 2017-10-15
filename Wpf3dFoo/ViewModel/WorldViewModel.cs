using System.Collections.ObjectModel;
using System.Windows.Media.Media3D;

namespace HHE.Wpf3dFoo.ViewModel
{
    internal sealed class WorldViewModel
    {
        public CameraViewModel Camera { get; }
        public ObservableCollection<VisualViewModel> Visuals { get; }

        public WorldViewModel()
        {
            Camera = new CameraViewModel(new Point3D(-40.0, 40.0, 40.0), new Vector3D(1.0, -0.75, -0.75), new Vector3D(0, 0, 1));
            Visuals = new ObservableCollection<VisualViewModel>
            {
                new LightViewModel(new Vector3D(-1, -1, -3)),
                Model3DViewModel.CreateCube()
            };
        }
    }
}
