using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Demo1.App.Model
{
    public class UserModel : BindableBase
    {
        private string _email;
        private string _password;

        /// <summary>
        /// Campo Email del usuario
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        /// <summary>
        /// Campo Password del usuario.
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

    }
}
