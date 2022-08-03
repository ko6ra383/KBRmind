using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBRmind.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        #region Properties
        #region Title
        private string _Title = "KBRmind";
        public string Title { get => _Title; set => Set(ref _Title, value); }
        #endregion  
        #endregion
        #region Commands

        #endregion
        public MainViewModel()
        {
            #region Commands

            #endregion
        }
    }
}
