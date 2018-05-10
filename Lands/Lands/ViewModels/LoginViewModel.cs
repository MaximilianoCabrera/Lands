namespace Lands.ViewModels
{
    using System.Windows.Input;

    public class LoginViewModel
    {
        #region MyProperties
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool IsRunning
        {
            get;
            set;
        }
        public bool IsRemember
        {
            get;
            set;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get;
            set;
        }

        public ICommand RegisterCommand
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemember = true;
        }
        #endregion
    }
}
