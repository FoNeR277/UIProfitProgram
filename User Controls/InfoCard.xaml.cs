using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FontAwesome.Sharp;

namespace UIProfit.User_Controls
{
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }



        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(InfoCard));



        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Number.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(int), typeof(InfoCard));



        public IconChar Icon
        {
            get { return (IconChar)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(IconChar));



        public Color BackGroundColor
        {
            get { return (Color)GetValue(BackGroundColorProperty); }
            set { SetValue(BackGroundColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackGroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackGroundColorProperty =
            DependencyProperty.Register("BackGroundColor", typeof(Color), typeof(Color));



        public Color BackGround2Color
        {
            get { return (Color)GetValue(BackGround2ColorProperty); }
            set { SetValue(BackGround2ColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackGround2Color.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackGround2ColorProperty =
            DependencyProperty.Register("BackGround2Color", typeof(Color), typeof(Color));





        public Color EllipseBackGroundColor
        {
            get { return (Color)GetValue(EllipseBackGroundColorProperty); }
            set { SetValue(EllipseBackGroundColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EllipseBackGroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EllipseBackGroundColorProperty =
            DependencyProperty.Register("EllipseBackGroundColor", typeof(Color), typeof(Color));







        public Color EllipseBackGroundColor2
        {
            get { return (Color)GetValue(EllipseBackGroundColor2Property); }
            set { SetValue(EllipseBackGroundColor2Property, value); }
        }

        // Using a DependencyProperty as the backing store for EllipseBackGroundColor2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EllipseBackGroundColor2Property =
            DependencyProperty.Register("EllipseBackGroundColor2", typeof(Color), typeof(Color));



    }
}
