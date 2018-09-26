using PS.Demo1.App.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PS.Demo1.App.Services.Imp
{
    public class LoginService: ILoginService
    {
        public bool DoLoginService(UserModel user)
        {
            Thread.Sleep(4000);
            return true;
        }
    }
}
