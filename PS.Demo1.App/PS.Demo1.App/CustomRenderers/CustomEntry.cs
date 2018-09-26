using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PS.Demo1.App.CustomRenderers
{
    public class CustomEntry:Entry
    {
        public CustomEntry()
        {
            BackgroundColor = Color.FromHex("#FFFACD");
            TextColor = Color.Black;
        }
    }
}
