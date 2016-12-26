using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace wiebOS
{
    class OpacityToSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var opacity = (double) value;

            if (opacity <= 0.1)
            {
                value = ("bin/Design/TextPad.png");
            }
            else if (opacity >= 0.1)
            {
                value = ("bin/Design/TextPadBG.png");
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
