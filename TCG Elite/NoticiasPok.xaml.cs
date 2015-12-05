﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TCG_Elite.Entity;
using System.Xml.Linq;
using Microsoft.Phone.Net.NetworkInformation;

namespace TCG_Elite
{
    public partial class NoticiasPok : PhoneApplicationPage
    {
        RssItem rss = new RssItem();
        public NoticiasPok()
        {
            InitializeComponent();
        }
        private void RssClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                var rssData = from rss in XElement.Parse(e.Result).Descendants("item")
                              select new RssItem
                              {
                                  title = rss.Element("title").Value,
                                  pubDate = rss.Element("pubDate").Value,
                                  description = rss.Element("description").Value,
                                  link = rss.Element("link").Value
                              };

                lstPok.ItemsSource = rssData;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, ative sua conexão de dados");
                NavigationService.GoBack();

            }
            


        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
                
                    //A rede está ativa, então continue com a ação do seu software...
                    WebClient rssClientPok = new WebClient();

                    rssClientPok.DownloadStringCompleted += RssClient_DownloadStringCompleted;
                    rssClientPok.Encoding = System.Text.Encoding.GetEncoding("ISO8859-1");
                    rssClientPok.DownloadStringAsync(new Uri(@"http://bulbanews.bulbagarden.net/feed/news.rss"));
              
              
           
           

            // https://yugiohblog.konami.com/?feed=rss2

        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            Browser browser = e.Content as Browser;
            if (browser != null)
            {
                browser.pageBrowser = rss;
            }

        }

        private void onSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstPok != null)
            {
                rss = (sender as ListBox).SelectedItem as RssItem;

            }


        }
        private void onPesquisaNoticia(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Browser.xaml", UriKind.Relative));
        }


    }
}