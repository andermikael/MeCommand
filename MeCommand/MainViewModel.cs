using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeCommand
{
    internal class MainViewModel : ObservableObject
    {
        private bool nameSwitch = false;

        public MainViewModel()
        {
            Button1Command = new RelayCommand(DoButton1Command);
            Button2Command = new RelayCommand(DoButton2Command, CanButton2Execute);
            Button3Command = new RelayCommand<string>(DoButton3Command, CanButton3Execute);
        }

        private string? _Name1;

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string? Name1
        {
            get => _Name1;
            set
            {
                SetProperty(ref _Name1, value);
                // Let the Button2 and Button3 know that we have a change in the Name property.
                // The function CanButton2Execute will be executed and the result will effect the button IsEnable
                Button2Command.NotifyCanExecuteChanged();
                Button3Command.NotifyCanExecuteChanged();
            }
        }

        private string? _Name2;

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string? Name2
        {
            get => _Name2;
            set
            {
                SetProperty(ref _Name2, value);
            }
        }

        #region Commands

        // Button1Command Just execute a function...
        public IRelayCommand Button1Command { get; }

        private void DoButton1Command()
        {
            if (nameSwitch)
            {
                Name1 = "Uriah Heep";
                nameSwitch = false;
            }
            else
            {
                Name1 = "Deep Purple";
                nameSwitch = true;
            }
        }

        // Button2Command
        public IRelayCommand Button2Command { get; }

        private bool CanButton2Execute()
        {
            if (!string.IsNullOrWhiteSpace(Name1))
                return true;
            else
                return false;
        }

        private void DoButton2Command()
        {
            if (nameSwitch)
            {
                Name1 = "Uriah Heep";
                nameSwitch = false;
            }
            else
            {
                Name1 = "Deep Purple";
                nameSwitch = true;
            }
        }

        // Button3Command
        public IRelayCommand Button3Command { get; }

        private bool CanButton3Execute(string? obj)
        {
            if (!string.IsNullOrWhiteSpace(Name1))
                return true;
            else
                return false;
        }

        private void DoButton3Command(string? name)
        {
            Name2 = name;
        }

        #endregion Commands
    }
}