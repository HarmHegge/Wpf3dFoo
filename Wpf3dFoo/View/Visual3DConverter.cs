using HHE.Wpf3dFoo.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Media3D;

namespace HHE.Wpf3dFoo.View
{
    internal sealed class Visual3DConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Model3DCollection(InternalConvert(value as IEnumerable<VisualViewModel>));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        private IEnumerable<Model3D> InternalConvert(IEnumerable<VisualViewModel> models)
        {
            if(models == null)
            {
                yield break;
            }

            foreach(var model in models)
            {
                yield return model.CreateModel3D();
            }
        }
    }
}
