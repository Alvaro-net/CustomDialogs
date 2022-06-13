using DialogMessage.Dialogs;
using DialogMessage.Dialogs.Model;
using DialogMessage.Dialogs.View;
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

namespace DialogMessage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btndialogsinglebutton_Click(object sender, RoutedEventArgs e)
        {
            CustomDialog.ShowMessage(new DialogModel()
            {
                Title = "titulo de teste",
                Text = "Corpo do Texto!",
                CornerRadius = 60,
                ShowClose = true,
                ShowIcon = true,
                Icon = Geometry.Parse("M12,9A3,3 0 0,0 9,12A3,3 0 0,0 12,15A3,3 0 0,0 15,12A3,3 0 0,0 12,9M12,17A5,5 0 0,1 7,12A5,5 0 0,1 12,7A5,5 0 0,1 17,12A5,5 0 0,1 12,17M12,4.5C7,4.5 2.73,7.61 1,12C2.73,16.39 7,19.5 12,19.5C17,19.5 21.27,16.39 23,12C21.27,7.61 17,4.5 12,4.5Z"),
                Background = new SolidColorBrush(Colors.Blue),
                Foreground = new SolidColorBrush(Colors.White),
                Border = new SolidColorBrush(Colors.Purple),
                BorderThickness = 10,
                FontFamily = new FontFamily("Comic Sans"),
                FontSize = 20,
                TitleFontSize = 24,
                OKText = "OK!",
                OKBackground = new SolidColorBrush(Colors.Green),
                OKBorder = new SolidColorBrush(Colors.Yellow),
                OKBorderThickness = 5,
                OKForeground = new SolidColorBrush(Colors.Yellow),
                OKFontFamily = new FontFamily("Roboto"),
                CancelText = "Cancel!",
                CancelBackground = new SolidColorBrush(Colors.Red),
                CancelBorder = new SolidColorBrush(Colors.SlateGray),
                CancelBorderThickness = 5,
                CancelFontFamily = new FontFamily("Sans Serif"),
                CancelForeground = new SolidColorBrush(Colors.Gray),
                ShowInverted = false,
                ShowTwoButtons = true,

            });
        }
    }
}
