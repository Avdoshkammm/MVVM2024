using MVVM2024.Infrastructure.Commands;
using MVVM2024.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace MVVM2024.ViewModels
{
    internal class MainWinowsViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Заголовок окна";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status : string - Статус программы

        private string _Status = "Готов!";
        public string Status 
        { 
            get => _Status;  
            set => Set(ref _Status, value);
        }
        #endregion

        #region Команды
        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion
        #endregion
        public MainWinowsViewModel() 
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion
        }
    }
}
