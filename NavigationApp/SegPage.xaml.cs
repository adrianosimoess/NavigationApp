﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationApp
{
    public partial class SegPage : ContentPage
    {
        void voltarProInicio(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public SegPage()
        {
            InitializeComponent();
        }
    }
}
