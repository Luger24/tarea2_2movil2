using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace tarea2_2movil2.Converters
{
    public class ImageToByteArray : IValueConverter
    {


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ImageSource retSource = null;
            if (value != null)
            {
                byte[] imageAsBytes = (byte[])value;
                retSource = ImageSource.FromStream(() => new MemoryStream(imageAsBytes));
            }
            return retSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}