﻿using PS.Demo1.App.ViewModels;
using PS.Demo1.App.Views;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PS.Demo1.App.Services;
using PS.Demo1.App.Services.Imp;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PS.Demo1.App
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/LoginPage");
            await NavigationService.NavigateAsync("NavigationPage/Login3");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();

            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<IndexContentPage>();
            Container.RegisterType<ILoginService, LoginService>();
            Container.RegisterTypeForNavigation<Login2Page>("Login2");
            Container.RegisterTypeForNavigation<Login3Page1>("Login3");
        }
    }
}
