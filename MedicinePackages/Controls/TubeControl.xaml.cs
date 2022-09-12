using Medicine.Packages.Model;
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

namespace Medicine.Packages.Controls
{
    /// <summary>
    /// Interaction logic for TubeControl.xaml
    /// </summary>
    public partial class TubeControl : UserControl
    {
        public TubeModel TubeModel
        {
            get { return (TubeModel)GetValue(TubeModelProperty); }
            set { SetValue(TubeModelProperty, value); }
        }
        public static readonly DependencyProperty TubeModelProperty =
            DependencyProperty.Register("TubeModel", typeof(TubeModel), typeof(TubeControl));

        public ICommand AddCoinAction
        {
            get { return (ICommand)GetValue(AddCoinActionProperty); }
            set { SetValue(AddCoinActionProperty, value); }
        }
        public static readonly DependencyProperty AddCoinActionProperty =
            DependencyProperty.Register("AddCoinAction", typeof(ICommand), typeof(TubeControl));


        public ICommand RemoveCoinAction
        {
            get { return (ICommand)GetValue(RemoveCoinActionProperty); }
            set { SetValue(RemoveCoinActionProperty, value); }
        }
        public static readonly DependencyProperty RemoveCoinActionProperty =
            DependencyProperty.Register("RemoveCoinAction", typeof(ICommand), typeof(TubeControl));

        public ICommand ActivateTubeAction
        {
            get { return (ICommand)GetValue(ActivateTubeActionProperty); }
            set { SetValue(ActivateTubeActionProperty, value); }
        }
        public static readonly DependencyProperty ActivateTubeActionProperty =
            DependencyProperty.Register("ActivateTubeAction", typeof(ICommand), typeof(TubeControl));



        public ICommand LostFocusCommand
        {
            get { return (ICommand)GetValue(LostFocusCommandProperty); }
            set { SetValue(LostFocusCommandProperty, value); }
        }
        public static readonly DependencyProperty LostFocusCommandProperty =
            DependencyProperty.Register("LostFocusCommand", typeof(ICommand), typeof(TubeControl));



        public ICommand GotFocusCommand
        {
            get { return (ICommand)GetValue(GotFocusCommandProperty); }
            set { SetValue(GotFocusCommandProperty, value); }
        }
        public static readonly DependencyProperty GotFocusCommandProperty =
            DependencyProperty.Register("GotFocusCommand", typeof(ICommand), typeof(TubeControl));




        public TubeControl()
        {
            InitializeComponent();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox senderTextBox = sender as TextBox;
            if (string.IsNullOrEmpty(senderTextBox.Text))
            {
                TubeModel tubeModel = senderTextBox.DataContext as TubeModel;
                tubeModel.Tubevalue = 0;
            }
        }
    }
}
