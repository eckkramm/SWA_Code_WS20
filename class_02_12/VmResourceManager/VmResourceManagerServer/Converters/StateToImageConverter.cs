using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using VmResourceManagerServer.ViewModel;

namespace VmResourceManagerServer.Converters
{
    public class StateToImageConverter : IValueConverter
    {
        private static BitmapImage runningImage = new BitmapImage(new Uri("../Assets/Images/running.png", UriKind.Relative));


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            StateType temp = (StateType)value;
            switch (temp)
            {
                case StateType.Running:
                    return runningImage;
                case StateType.OnHold:
                    return new BitmapImage(new Uri("../Assets/Images/pause.png", UriKind.Relative));
                case StateType.Stopped:
                    return new BitmapImage(new Uri("../Assets/Images/stop.png", UriKind.Relative));
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
