using PS.Demo1.App.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Demo1.App.Services
{
    public interface ILoginService
    {
        bool DoLoginService(UserModel user);
    }
}
