using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM2024.ViewModels.Base;

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
    }
}
