using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFDiscord.Common.Controls
{
    public class EllipseButton : Button
    {
        public ImageSource NormalImage
        {
            get
            {
                return (ImageSource)GetValue(NormalImageProperty);
            }
            set
            {
                SetValue(NormalImageProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NormalImageProperty =
            DependencyProperty.Register("NormalImage", typeof(ImageSource), typeof(EllipseButton));

        public Color MouseOverBackground
        {
            get
            {
                return (Color)GetValue(MouseOverBackgroundProperty);
            }
            set
            {
                SetValue(MouseOverBackgroundProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for MouseOverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Color), typeof(EllipseButton));



        public CornerRadius ButtonCornerRadius
        {
            get
            {
                return (CornerRadius)GetValue(ButtonCornerRadiusProperty);
            }
            set
            {
                SetValue(ButtonCornerRadiusProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(EllipseButton));



        public double TopLeftCorner
        {
            get
            {
                return (int)GetValue(TopLeftCornerProperty);
            }
            set
            {
                SetValue(TopLeftCornerProperty, value);
            }
        }
        public static readonly DependencyProperty TopLeftCornerProperty =
            DependencyProperty.Register(nameof(TopLeftCorner), typeof(int), typeof(EllipseButton),
                new PropertyMetadata(0, (s, e) =>
                {
                    ((EllipseButton)s).ButtonCornerRadius = new CornerRadius(
                        double.Parse(e.NewValue.ToString()!),
                        ((EllipseButton)s).ButtonCornerRadius.TopRight,
                        ((EllipseButton)s).ButtonCornerRadius.BottomRight,
                        ((EllipseButton)s).ButtonCornerRadius.BottomLeft);
                }));

        public double TopRightCorner
        {
            get
            {
                return (int)GetValue(TopRightCornerProperty);
            }
            set
            {
                SetValue(TopRightCornerProperty, value);
            }
        }
        public static readonly DependencyProperty TopRightCornerProperty =
            DependencyProperty.Register(nameof(TopRightCorner), typeof(int), typeof(EllipseButton),
                new PropertyMetadata(0, (s, e) =>
                {
                    ((EllipseButton)s).ButtonCornerRadius = new CornerRadius(
                        ((EllipseButton)s).ButtonCornerRadius.TopLeft,
                        double.Parse(e.NewValue.ToString()!),
                        ((EllipseButton)s).ButtonCornerRadius.BottomRight,
                        ((EllipseButton)s).ButtonCornerRadius.BottomLeft);
                }));

        public double BottomRightCorner
        {
            get
            {
                return (int)GetValue(BottomRightCornerProperty);
            }
            set
            {
                SetValue(BottomRightCornerProperty, value);
            }
        }
        public static readonly DependencyProperty BottomRightCornerProperty =
            DependencyProperty.Register(nameof(BottomRightCorner), typeof(int), typeof(EllipseButton),
                new PropertyMetadata(0, (s, e) =>
                {
                    ((EllipseButton)s).ButtonCornerRadius = new CornerRadius(
                        ((EllipseButton)s).ButtonCornerRadius.TopLeft,
                        ((EllipseButton)s).ButtonCornerRadius.TopRight,
                        double.Parse(e.NewValue.ToString()!),
                        ((EllipseButton)s).ButtonCornerRadius.BottomLeft);
                }));

        public double BottomLeftCorner
        {
            get
            {
                return (int)GetValue(BottomLeftCornerProperty);
            }
            set
            {
                SetValue(BottomLeftCornerProperty, value);
            }
        }
        public static readonly DependencyProperty BottomLeftCornerProperty =
            DependencyProperty.Register(nameof(BottomLeftCorner), typeof(int), typeof(EllipseButton),
                new PropertyMetadata(0, (s, e) =>
                {
                    ((EllipseButton)s).ButtonCornerRadius = new CornerRadius(
                        ((EllipseButton)s).ButtonCornerRadius.TopLeft,
                        ((EllipseButton)s).ButtonCornerRadius.TopRight,
                        ((EllipseButton)s).ButtonCornerRadius.BottomRight,
                        double.Parse(e.NewValue.ToString()!));
                }));



        public EventHandler CornerCompleted
        {
            get
            {
                return (EventHandler)GetValue(CornerCompletedProperty);
            }
            set
            {
                SetValue(CornerCompletedProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for CornerCompleted.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerCompletedProperty =
            DependencyProperty.Register("CornerCompleted", typeof(EventHandler), typeof(EllipseButton));


        public EllipseButton()
        {
            DefaultStyleKey = typeof(EllipseButton);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}
