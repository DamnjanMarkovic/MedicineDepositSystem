using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Medicine.Packages.Model
{
    public class TubeModel : BindableBase
    {
        #region Properties

        #region Tube Activation 
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

        #endregion

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
            }
        }

        private int tubevalue;
        public int Tubevalue
        {
            get => tubevalue;
            set
            {
                //Check if value is in the range (not higher then max value)
                if (value <= TubeMaxValue)
                {
                    tubevalue = value;
                    RaisePropertyChanged(nameof(Tubevalue));

                    // SetTubeProgressValue
                    TubeProgressBarValue = (double)(100 * (double)Tubevalue / TubeMaxValue);
                }
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

        private bool isTextBoxFocused = true;
        public bool IsTextBoxFocused
        {
            get => isTextBoxFocused;
            set
            {
                isTextBoxFocused = value;
                RaisePropertyChanged(nameof(IsTextBoxFocused));
            }
        }




        #endregion

        #region Funcs

        /// <summary>
        /// Sets buttons for Activate/Deactivate - Text and Color
        /// </summary>
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
        /// <summary>
        /// Func calculate progress bar in order to display it
        /// </summary>
        private void SetTubeProgressValue()
        {
            TubeProgressBarValue = (double)(100 * (double)Tubevalue / TubeMaxValue);
        }

        #endregion
    }
}
