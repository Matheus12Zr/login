using Login.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace login.viewmodel
{
    public class LoginViewModel:ViewModelBase
    {
        private String _Username;
        private String _Password;
        private String _errorMessage;
        private bool _isViewVisible = true;
        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
                onPropertyChanged(nameof(Username));
            }
        } 
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                onPropertyChanged(nameof(Password));
            }
        }
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                onPropertyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }
            set
            {
                _isViewVisible = value;
                onPropertyChanged(nameof(IsViewVisible));
            }
        }
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand showpasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }
        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, canExecuteLogijnCommand);
            RecoverPasswordCommand = new ViewModelCommand(p=>ExecuterecoverPassCommand("",""));
        }

        private void ExecuterecoverPassCommand(String username, String email)
        {
            throw new NotImplementedException();
        }

        private bool canExecuteLogijnCommand(object obj)
        {
            bool validDate;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 ||
                Password == null || Password.Length < 3)
                validDate = false;
            else
                validDate = true;
            return validDate;
        }

        private void ExecuteLoginCommand(object obj)
        {
           
        }
        private void ExecuteRecoverPassCommand(string username,string email)
        {
            throw new NotImplementedException();
        }
    }
        }

