using HHE.CodeHelpers;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace HHE.Wpf3dFoo.ViewModel
{
    internal sealed class Model3DViewModel : VisualViewModel
    {
        public Point3DCollection Positions { get; }
        public Int32Collection Indices { get; }

        public Model3DViewModel(Point3DCollection positions, Int32Collection indices)
        {
            Positions = positions.NotNull(nameof(positions));
            Indices = indices.NotNull(nameof(indices));
        }

        public override Model3D CreateModel3D()
        {
            return new GeometryModel3D
            {
                Geometry = new MeshGeometry3D
                {
                    Positions = Positions,
                    TriangleIndices = Indices
                },

                Material = new DiffuseMaterial
                {
                    Brush = Brushes.Red
                }
            };
        }

        public static Model3DViewModel CreateCube()
        {
            var positions = new Point3DCollection()
            {
                new Point3D(0,0,0),
                new Point3D(10,0,0),
                new Point3D(10,10,0),
                new Point3D(0,10,0),
                new Point3D(0,0,10),
                new Point3D(10,0,10),
                new Point3D(10,10,10),
                new Point3D(0,10,10)
            };

            var indices = new Int32Collection()
            {
                0, 1, 3, 1, 2, 3,
                0, 4, 3, 4, 7, 3,
                4, 6, 7, 4, 5, 6,
                0, 4, 1, 1, 4, 5,
                1, 2, 6, 6, 5, 1,
                2, 3, 7, 7, 6, 2,
            };

            return new Model3DViewModel(positions, indices);
        }        
    }
}
