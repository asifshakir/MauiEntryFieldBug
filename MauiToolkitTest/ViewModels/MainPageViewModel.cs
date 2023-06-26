using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiToolkitTest.ViewModels
{
    internal partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string greeting = "Hello World!";

        long counter = 0;
        public long Counter {
            get => counter; 
            set => SetProperty(ref counter, value); 
        }
    }
}
