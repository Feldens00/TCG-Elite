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
using System.Xml.Linq;

namespace TCG_Elite
{
    public partial class PivotTCG : PhoneApplicationPage
    {
        string j = "Player 1";
        string j2 = "Player 2";
        Repository rep = new Repository();
        Ygo ygo = new Ygo();
        Ygo select = new Ygo();

        public PivotTCG()
        {
            InitializeComponent();
        }





        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            RefreshList();

            lstpok.ItemsSource = rep.parseJson("Json/pok.json");

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if (ygo!= null)
            {
                Add page = e.Content as Add;
                page.pivotPage = ygo;

            }
            if (select!=null)
            {
                MainPage page2 = e.Content as MainPage;
                page2.pivotmain = select;
            }
        }


        private void onClickDelete(object sender, EventArgs e)
        {
            ygo = null;
            try
            {
                if (select != null)
                {
                    if (MessageBox.Show("Deletar " + select.jogador1 + "   " + select.jogador2 + "?", "Atenção", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                    {
                        rep.Delete(select);
                        RefreshList();
                        MessageBox.Show("Dupla Excluida");
                    }
                    else
                        MessageBox.Show("Ufa Tche");
                }
                else
                {
                    MessageBox.Show("Selecione uma dupla para deletar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma dupla para deletar");
            }
        


        //if (MessageBox.Show("Deletar " + select.jogador1 + "   "+select.jogador2+ "?", "Atenção", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
        //{

        //    if (select.jogador1 == null)
        //    {
        //        MessageBox.Show("Selecione  a dupla de jogadores para poder deletar !");
        //    }
        //    else if (select.jogador1 != null)
        //    {
        //        rep.Delete(select);
        //        RefreshList();
        //    }

        //}

    }

    private void RefreshList()
        {
            var jogador = rep.GetAll();
            lstJogadores.ItemsSource = jogador;
        }


      
        private void onClickNew(object sender, EventArgs e)
        {
            select = null;
            ygo = null;
            NavigationService.Navigate(new Uri("/Add.xaml", UriKind.Relative));
        }

        private void lstJogadores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            select = (sender as ListBox).SelectedItem as Ygo;
        }

        private void onClickCal(object sender, EventArgs e)
        {
            ygo= null;


            if (select==null)
            {
                //* so botei para n o select n passar com null  pq aqui eles n pegam os valores string so na mainpage.
                select.jogador1 = j ;
                select.jogador2 = j2;
            }
            
            if (MessageBox.Show("Yu Gi Oh?", "Atenção", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                select.operation = 1;

            }
            else {
                if (MessageBox.Show("Magic?", "Atenção", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    select.operation = 2;
                }
                else {
                    if (MessageBox.Show("Battle Scenes?", "Atenção", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                    {
                        select.operation = 3;
                    }
                    else
                    {
                        select.operation = 0;
                    }
                }
            }
            
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((sender as Pivot).SelectedIndex)
            {
                case 0:
                    ApplicationBar = Resources["AppBar1"] as ApplicationBar;
                    break;

                case 1:
                    ApplicationBar = Resources["AppBar2"] as ApplicationBar;
                    break;
            }

        }

     

       
        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            ygo = null;
            select = null;
            NavigationService.Navigate(new Uri("/NoticiasPok.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
              ygo = null;
            select = null;
            NavigationService.Navigate(new Uri("/NoticiasYgo.xaml", UriKind.Relative));
        }
    }
}