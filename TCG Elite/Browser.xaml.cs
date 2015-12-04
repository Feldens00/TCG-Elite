using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TCG_Elite.Entity;

namespace TCG_Elite
{
    public partial class Browser : PhoneApplicationPage
    {
        public RssItem pageBrowser { get; set; }
        public Browser()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            myBrowser.Navigate(new Uri(pageBrowser.link, UriKind.Absolute));


        }
    }
}