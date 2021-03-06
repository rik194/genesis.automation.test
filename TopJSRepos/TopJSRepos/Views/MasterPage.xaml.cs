﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TopJSRepos.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopJSRepos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView;

        public MasterPage()
        {
            InitializeComponent();

            BindingContext = new MasterPageViewModel();
            ListView = MenuItemsListView;
        }
    }
}