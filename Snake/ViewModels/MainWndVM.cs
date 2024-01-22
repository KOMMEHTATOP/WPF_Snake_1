using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.ViewModels
{
    internal class MainWndVM : BindableBase
    {
        private bool _continueGame;

        public bool ContinueGame
        {
            get { return _continueGame; }
            private set
            {
                _continueGame = value;
                RaisePropertyChanged(nameof(ContinueGame));
            }
        }

        public DelegateCommand StartStopCommand { get; }

        public MainWndVM()
        {
            StartStopCommand = new DelegateCommand(() => ContinueGame = !ContinueGame);
        }

    }
}
