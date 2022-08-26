using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WPFDiscord.Common.Controls
{
    public class ImageButton : Button
    {
        public ImageSource? Image
        {
            get
            {
                return GetValue(ImageProperty) as ImageSource;
            }
            set
            {
                SetValue(ImageProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(ImageButton));

        public ImageSource? MouseOverImage
        {
            get
            {
                return GetValue(MouseOverImageProperty) as ImageSource;
            }
            set
            {
                SetValue(MouseOverImageProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for HoverImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverImageProperty =
            DependencyProperty.Register("MouseOverImage", typeof(ImageSource), typeof(ImageButton));

        public Brush MouseOverBackground
        {
            get
            {
                return (Brush)GetValue(MouseOverBackgroundProperty);
            }
            set
            {
                SetValue(MouseOverBackgroundProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for MouseOverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(ImageButton));

        public ImageSource MousePressedImage
        {
            get
            {
                return (ImageSource)GetValue(MousePressedImageProperty);
            }
            set
            {
                SetValue(MousePressedImageProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for MousePressedImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MousePressedImageProperty =
            DependencyProperty.Register("MousePressedImage", typeof(ImageSource), typeof(ImageButton));

        public Cursor MouseOverCursor
        {
            get
            {
                return (Cursor)GetValue(MouseOverCursorProperty);
            }
            set
            {
                SetValue(MouseOverCursorProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for MouseOverCursor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverCursorProperty =
            DependencyProperty.Register("MouseOverCursor", typeof(Cursor), typeof(ImageButton));

        public ImageButton()
        {
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
            DefaultStyleKey = typeof(ImageButton);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}
