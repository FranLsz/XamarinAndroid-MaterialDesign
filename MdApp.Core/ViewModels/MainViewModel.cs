using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace MdApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        readonly Type[] _menuItemTypes = {
            typeof(HomeViewModel)
        };
        public IEnumerable<string> MenuItems { get; private set; } = new[] { "Home" };

        public void NavigateTo(int position)
        {
            ShowViewModel(_menuItemTypes[position]);
        }
    }
}