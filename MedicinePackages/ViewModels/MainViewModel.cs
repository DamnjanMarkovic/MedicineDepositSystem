using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using TCR.CoinDeposit.Model;

namespace TCR.CoinDeposit.ViewModels
{
    public class MainViewModel: BindableBase
    {
        #region Properties

        private int tubeWidth;
        public int TubeWidth
        {
            get => tubeWidth;
            set
            {
                tubeWidth = value;
                RaisePropertyChanged(nameof(TubeWidth));
            }
        }

        private ObservableCollection<TubeModel> tubesList = new ObservableCollection<TubeModel>();
        public ObservableCollection<TubeModel> TubesList
        {
            get => tubesList;
            set
            {
                tubesList = value;
                RaisePropertyChanged(nameof(TubesList));
            }
        }

        public int NumberOfColumns { get; set; }
        #endregion

        #region Commands
        public ICommand AddCoin { get; set; }
        public ICommand RemoveCoin { get; set; }
        public ICommand ActivateTube { get; set; }

        #endregion

        #region Contructor

        public MainViewModel()
        {
            AddCoin = new DelegateCommand<TubeModel>(AddCoinAction, CanDoAction);
            RemoveCoin = new DelegateCommand<TubeModel>(RemoveCoinAction, CanDoAction);
            ActivateTube = new DelegateCommand<TubeModel>(ActivateTubeAction);

            SetMockUpData();

        }

        private void ActivateTubeAction(TubeModel obj)
        {
            TubeModel itemClicked = obj as TubeModel;
            if (itemClicked.IsActive)
            {
                itemClicked.IsActive = false;
            }
            else
            {
                itemClicked.IsActive = true;
            }
        }

        private void SetMockUpData()
        {
            TubesList = new ObservableCollection<TubeModel>()
            {
                new TubeModel() { TubePosition = 1, TubeDenomination = "1 box", TubeMaxValue = 5, Tubevalue = 1, IsActive = true },
                new TubeModel() { TubePosition = 2, TubeDenomination = "1 box", TubeMaxValue = 5, Tubevalue = 2, IsActive = true},
                new TubeModel() { TubePosition = 3, TubeDenomination = "2 box", TubeMaxValue = 5, Tubevalue = 3, IsActive = false },
                new TubeModel() { TubePosition = 4, TubeDenomination = "2 box", TubeMaxValue = 5, Tubevalue = 4, IsActive = true },
                new TubeModel() { TubePosition = 5, TubeDenomination = "5 box", TubeMaxValue = 10, Tubevalue = 3, IsActive = false },
                new TubeModel() { TubePosition = 6, TubeDenomination = "5 box", TubeMaxValue = 10, Tubevalue = 6, IsActive = true },
                new TubeModel() { TubePosition = 7, TubeDenomination = "10 box", TubeMaxValue = 10, Tubevalue = 5, IsActive = false },
                new TubeModel() { TubePosition = 8, TubeDenomination = "10 box", TubeMaxValue = 10, Tubevalue = 2, IsActive = true },
                new TubeModel() { TubePosition = 9, TubeDenomination = "20 box", TubeMaxValue = 20, Tubevalue = 11, IsActive = false },
                new TubeModel() { TubePosition = 10, TubeDenomination = "20 box", TubeMaxValue = 20, Tubevalue = 5, IsActive = true },

                //new TubeModel() { TubePosition = 2, TubeDenomination = "5 box", TubeMaxValue = 10, Tubevalue = 5 },
                //new TubeModel() { TubePosition = 3, TubeDenomination = "10 box", TubeMaxValue = 20, Tubevalue = 12 },
            };

            if (TubesList.Count % 2 != 0)
                NumberOfColumns = (TubesList.Count + 1) / 2;
            else
                NumberOfColumns = TubesList.Count / 2;

            TubeWidth = (int)System.Windows.Application.Current.MainWindow.Width / NumberOfColumns;
        }

        private void RemoveCoinAction(TubeModel obj)
        {
            TubeModel itemClicked = obj as TubeModel;
            if (itemClicked.Tubevalue > 0)
                itemClicked.Tubevalue--;
            
        }


        #endregion

        #region Funcs
        private void AddCoinAction(object obj)
        {
            TubeModel itemClicked = obj as TubeModel;
            if (itemClicked.Tubevalue < itemClicked.TubeMaxValue)
                itemClicked.Tubevalue++;

        }

        public bool CanDoAction(object something)
        {
            return true;
        }

        #endregion
    }
}
