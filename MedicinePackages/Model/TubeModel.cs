using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TCR.CoinDeposit.Model
{
    public class TubeModel : BindableBase
    {

        private bool isActive = false;
        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;
                RaisePropertyChanged(nameof(IsActive));
                SetIsActiveTextColor();
            }
        }

        private Brush onOffButtonBackground = Brushes.Transparent;
        public Brush OnOffButtonBackground
        {
            get => onOffButtonBackground;
            set
            {
                onOffButtonBackground = value;
                RaisePropertyChanged(nameof(OnOffButtonBackground));
            }
        }

        private string isActiveDescription;
        public string IsActiveDescription
        {
            get => isActiveDescription;
            set
            {
                isActiveDescription = value;
                RaisePropertyChanged(nameof(IsActiveDescription));
            }
        }
        
        private int tubePosition;
        public int TubePosition
        {
            get => tubePosition;
            set
            {
                tubePosition = value;
                RaisePropertyChanged(nameof(TubePosition));
            }
        }

        private string tubeDenomination;
        public string TubeDenomination
        {
            get => tubeDenomination;
            set
            {
                tubeDenomination = value;
                RaisePropertyChanged(nameof(TubeDenomination));
            }
        }

        private int tubeMaxValue;
        public int TubeMaxValue
        {
            get => tubeMaxValue;
            set
            {
                tubeMaxValue = value;
                RaisePropertyChanged(nameof(TubeMaxValue));
                SetFieldsAndHeigh();
            }
        }

        private int tubevalue;
        public int Tubevalue
        {
            get => tubevalue;
            set
            {
                tubevalue = value;
                RaisePropertyChanged(nameof(Tubevalue));
                SetTubeProgressValue();
            }
        }

        private void SetTubeProgressValue()
        {
            //This is needed to show the progress bar accordingly
            TubeProgressBarValue = (double)((100 * (double)Tubevalue) / (double)TubeMaxValue);
        }

        private void SetIsActiveTextColor()
        {
            switch (IsActive)
            {
                case true:
                    OnOffButtonBackground = Brushes.Red;
                    IsActiveDescription = "OFF";
                    break;
                case false:
                    OnOffButtonBackground = Brushes.Green;
                    IsActiveDescription = "ON";
                    break;
            }
        }

        private void SetFieldsAndHeigh()
        {
            NumberOfFields.Clear();
            for (int i = 0; i < TubeMaxValue; i++)
            {
                //this is hardcoded, 250 is the height of the progress bar (where lines should be set)
                NumberOfFields.Add(new FieldHeightModel() { FieldHeight = (350 / (double)TubeMaxValue), FieldWidth = 300 });
            }
        }

        private double tubeProgressBarValue;
        public double TubeProgressBarValue
        {
            get => tubeProgressBarValue;
            set
            {
                tubeProgressBarValue = value;
                RaisePropertyChanged(nameof(TubeProgressBarValue));
            }
        }

        private ObservableCollection<FieldHeightModel> numberOfFields = new ObservableCollection<FieldHeightModel>();
        public ObservableCollection<FieldHeightModel> NumberOfFields
        {
            get => numberOfFields;
            set
            {
                numberOfFields = value;
                RaisePropertyChanged(nameof(NumberOfFields));
            }
        }


    }

    public class FieldHeightModel : BindableBase
    {
        private double fieldHeight;
        public double FieldHeight
        {
            get => fieldHeight;
            set
            {
                fieldHeight = value;
                RaisePropertyChanged(nameof(FieldHeight));
            }
        }

        private double fieldWidth;
        public double FieldWidth
        {
            get => fieldWidth;
            set
            {
                fieldWidth = value;
                RaisePropertyChanged(nameof(FieldWidth));
            }
        }
    }
}
