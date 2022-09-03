using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for CustomProgressBar.xaml
    /// </summary>
    public partial class CustomProgressBar : ProgressBar
    {

        public TubeModel TubeModel
        {
            get { return (TubeModel)GetValue(TubeModelProperty); }
            set { SetValue(TubeModelProperty, value); }
        }
        public static readonly DependencyProperty TubeModelProperty =
            DependencyProperty.Register("TubeModel", typeof(TubeModel), typeof(CustomProgressBar));


        public CustomProgressBar()
        {
            InitializeComponent();
        }
    }
}
