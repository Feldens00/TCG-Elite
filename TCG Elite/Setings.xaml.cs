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
using System.Windows.Input;

namespace TCG_Elite
{
    public partial class Setings : PhoneApplicationPage
    {
        Repository rep = new Repository();
        Ygo ygo = new Ygo();
        public Setings()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            MainPage page = e.Content as MainPage;
            if (page != null)
            {
                page.newYgo = ygo;


            }
        }

        private void onClickSave(object sender, EventArgs e)
        {
            ygo.pontosVida = Convert.ToInt32(txtPonto.Text);
            ygo.jogador1 = txtJogador1.Text;
            ygo.jogador2 = txtJogador2.Text;
            
            
            NavigationService.GoBack();
        }


         /// <summary>
         ///   faz o teclado sumir depois de dar enter
         /// </summary>
         /// <param name="keyUp"></param>
         /// <param name="e"></param>
        private void txtPonto_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Focus();
            }
        }

        private void txtJogador1_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Focus();
            }
        }

        private void txtJogador2_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Focus();
            }
        }
    }
}