using System.Windows;
using MVVM2024.Infrastructure.Commands.Base;

namespace MVVM2024.Infrastructure.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
