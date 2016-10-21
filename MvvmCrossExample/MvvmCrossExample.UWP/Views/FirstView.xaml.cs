using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MvvmCross.WindowsUWP.Views;
using MvvmCrossExample.Core.ViewModels;

namespace MvvmCrossExample.UWP.Views
{
    public sealed partial class FirstView : MvxWindowsPage<FirstViewModel>
    {
        public FirstView()
        {
            this.InitializeComponent();
        }
    }
}
