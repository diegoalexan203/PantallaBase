using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using PS.Demo1.App.Model;
using PS.Demo1.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PS.Demo1.App.ViewModels
{
	public class Login2PageViewModel : ViewModelBase
	{
        public Login2PageViewModel(INavigationService navigationService, IPageDialogService dialogService, ILoginService loginService)
            : base(navigationService)
        {
            LoginCommand = new DelegateCommand(DoLogin);
            Title = "Login";
            User = new UserModel();
            _dialogServices = dialogService;
            _loginServices = loginService;
        }

        /// <summary>
        /// Metodo invocado por Command, para realizar la accion de Login
        /// </summary>
        private void DoLogin()
        {
            if (!ValidarCampos())
            {
                this.IsRunningIndicator = true;
                //Se realiza el llamado al metodo que consume un api, base de datos, etc
                Boolean responseLogin = _loginServices.DoLoginService(User);
                if (responseLogin)
                {
                    NavigationService.NavigateAsync("NavigationPage/IndexContentPage");
                }
                else
                {
                    this._dialogServices.DisplayAlertAsync("Info!", "Usuario o contraseña incorrectos", "Ok");
                }
                IsRunningIndicator = false;
            }
        }

        #region Attributes
        /// <summary>
        /// Atributo para controlar el ActityIndicator
        /// </summary>
        private Boolean _isRunningIndicator;
        /// <summary>
        /// Atributo para bindiar los datos del usuario
        /// </summary>
        private UserModel _user;

        private bool _isVisibleLabel;
        #endregion


        /// <summary>
        /// Propiedad para el dispara el evento de login desde la view
        /// </summary>
        public DelegateCommand LoginCommand { get; private set; }

        #region Properties
        /// <summary>
        /// Propiedad para hacer el binding del ActivityIndicator
        /// </summary>
        public Boolean IsRunningIndicator
        {
            get { return _isRunningIndicator; }
            set { SetProperty(ref _isRunningIndicator, value); }
        }

        /// <summary>
        /// Propiedad para hacer el binding de los campos de usuario
        /// </summary>
        public UserModel User
        {
            get { return _user; }
            set
            {
                if (_user == null)
                {
                    _user = new UserModel();
                }
                ValidarCampos();
                SetProperty(ref _user, value);
            }
        }

        private IPageDialogService _dialogServices;
        private ILoginService _loginServices;

        /// <summary>
        /// Metodo para validar los campos
        /// </summary>
        /// <returns></returns>
        private Boolean ValidarCampos()
        {
            if ((_user.Email != null) && (_user.Password != null))
            {
                if ((_user.Email.Equals(string.Empty)) && (_user.Password.Equals(string.Empty)))
                {
                    IsVisibleLabel = true;
                }
                else
                {
                    IsVisibleLabel = false;
                }
            }
            else
            {
                IsVisibleLabel = true;
            }
            return IsVisibleLabel;
        }

        /// <summary>
        /// Propiedad para Bindear la visibilidad del label de Message
        /// </summary>
        public Boolean IsVisibleLabel
        {
            get { return _isVisibleLabel; }
            set { SetProperty(ref _isVisibleLabel, value); }
        }

        #endregion
    }
}

