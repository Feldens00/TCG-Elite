using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Input;
using TCG_Elite.Entity;

namespace TCG_Elite
{
    public partial class Add : PhoneApplicationPage
    {
       
        Repository rep = new Repository();
        public Ygo pivotPage { get; set; }
        public Add()
        {
            InitializeComponent();
        }

       

        private void onClickSave(object sender, EventArgs e)

        {
            if (pivotPage == null)
            {
                Ygo  go= new Ygo
                {
                    jogador1 = txtJogador1.Text,
                    jogador2 = txtJogador2.Text
                };
                rep.Create(go);
            }
            else
            {
                pivotPage.jogador1 = txtJogador1.Text;
                pivotPage.jogador2 = txtJogador2.Text;

                rep.Update(pivotPage);
            }

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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (pivotPage != null)
            {
               
                txtJogador1.Text = pivotPage.jogador1;
                txtJogador2.Text = pivotPage.jogador2;
            }
        }
    }
}