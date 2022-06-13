using DialogMessage.Dialogs.Model;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DialogMessage.Dialogs.View
{
    /// <summary>
    /// Lógica interna para Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Dialog()
        {
            InitializeComponent();
            Application.Current.MainWindow.Effect = new BlurEffect();
        }

        public Dialog(DialogModel model)
        {
            InitializeComponent();
            DataContext = model;

            if (model.ShowInverted)
            {
                Grid.SetFlowDirection(gridButtons, FlowDirection.RightToLeft);
            }

            Application.Current.MainWindow.Effect = new BlurEffect();

            if (!model.ShowTwoButtons)
            {
                btncancel.IsCancel = false;
            }
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Effect = null;
            this.Close();
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Effect = null;
            this.DialogResult = true;
            this.Close();
        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Effect = null;
            this.DialogResult = false;
            this.Close();
        }
    }
}
