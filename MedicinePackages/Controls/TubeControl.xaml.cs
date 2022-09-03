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
using TCR.CoinDeposit.Model;

namespace TCR.CoinDeposit.Controls
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



        public TubeControl()
        {
            InitializeComponent();
        }
    }
}
