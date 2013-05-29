using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace TagAsParameter.ViewModels
{
    public class MainViewModel
    {
        private RelayCommand<FrameworkElement> _taggedCommand;

        public MainViewModel()
        {
            _taggedCommand = new RelayCommand<FrameworkElement>(CommandMethod);
        }

        public ICommand TaggedCommand
        {
            get { return _taggedCommand; }
        }

        private void CommandMethod(FrameworkElement parameter)
        {
            var tag = parameter.Tag;
            System.Diagnostics.Debug.WriteLine("Executed command: " + tag);
        }
    }
}
