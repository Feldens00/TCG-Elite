using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TCG_Elite.Resources;
using TCG_Elite.Entity;

namespace TCG_Elite
{
    public partial class MainPage : PhoneApplicationPage
    {
        string j = "Player 1";
        string j2 = "Player 2";
        public Ygo newYgo { get; set; }
        public Ygo pivotmain { get; set; }

        
        int value1=0;
        int value2=0;
        int result=0;
        int  operation=0;
        int player=0;
       


        // Constructor
        public MainPage()
        {
            InitializeComponent();

           
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            if (pivotmain.operation==1)
            {
                if (pivotmain != null)
                {
                   int pv = 8000;
                    txtVida1.Text = Convert.ToString(pv);
                    txtVida2.Text = Convert.ToString(pv);
                    if (pivotmain.jogador1==null)
                    {
                        Btn_P1.Content = j;
                        Btn_P2.Content = j2;
                    }
                    else
                    {
                        Btn_P1.Content = pivotmain.jogador1;
                        Btn_P2.Content = pivotmain.jogador2;
                    }
                   
                    pv = 0;
                    
                }
            }
            else if (pivotmain.operation==2)
            {
                if (pivotmain != null)
                {
                  int  pv = 20;
                    txtVida1.Text = Convert.ToString(pv);
                    txtVida2.Text = Convert.ToString(pv);
                    if (pivotmain.jogador1 == null)
                    {
                        Btn_P1.Content = j;
                        Btn_P2.Content = j2;
                    }
                    else
                    {
                        Btn_P1.Content = pivotmain.jogador1;
                        Btn_P2.Content = pivotmain.jogador2;
                    }
                    pv = 0;
                }
            }
            else if (pivotmain.operation == 3)
            {
                if (pivotmain != null)
                {
                   int  pv = 15;
                    txtVida1.Text = Convert.ToString(pv);
                    txtVida2.Text = Convert.ToString(pv);
                    if (pivotmain.jogador1 == null)
                    {
                        Btn_P1.Content = j;
                        Btn_P2.Content = j2;
                    }
                    else
                    {
                        Btn_P1.Content = pivotmain.jogador1;
                        Btn_P2.Content = pivotmain.jogador2;
                    }
                    pv = 0;
                }
            }
            else 
            {
                if (pivotmain != null)
                {
                  int pv = 8000;
                    txtVida1.Text = Convert.ToString(pv);
                    txtVida2.Text = Convert.ToString(pv);
                    if (pivotmain.jogador1 == null)
                    {
                        Btn_P1.Content = j;
                        Btn_P2.Content = j2;
                    }
                    else
                    {
                        Btn_P1.Content = pivotmain.jogador1;
                        Btn_P2.Content = pivotmain.jogador2;
                    }

                }
            }
            if (newYgo!=null)
            {
                txtVida1.Text = Convert.ToString(newYgo.pontosVida);
                txtVida2.Text = Convert.ToString(newYgo.pontosVida);
                    Btn_P1.Content = newYgo.jogador1;
                    Btn_P2.Content = newYgo.jogador2;
              
            }

           

        }

        private void Btn_7_Click(object sender, RoutedEventArgs e)
        {
            value1 = 7;


        }
        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            value1 = 8;

        }
        private void Btn_9_Click(object sender, RoutedEventArgs e)
        {
            value1 = 9;
        }
        private void Btn_4_Click(object sender, RoutedEventArgs e)
        {
            value1 = 4;

        }
        private void Btn_5_Click(object sender, RoutedEventArgs e)
        {
            value1 = 5;
        }
             private void Btn_6_Click(object sender, RoutedEventArgs e)
        {
            value1 = 6;
        }
        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            value1 = 1;
        }
        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            value1 = 2;
        }
        private void Btn_3_Click(object sender, RoutedEventArgs e)
        {
            value1 = 3;
        }
        private void Btn_Equal_Click(object sender, RoutedEventArgs e)
        {
           
               if (player == 0)
            {
                MessageBox.Show("Escolha um Player para poder calcular");
            }
            if (player==1)
            {
                if (operation==1)
                {
                    value2 = Int32.Parse(txtVida1.Text);
                    result = value2 - value1;
                    txtVida1.Text = Convert.ToString(result);
                    
                }
                else if (operation==2)
                {
                    value2 = Int32.Parse(txtVida1.Text);
                    result = value2 + value1;
                    txtVida1.Text = Convert.ToString(result);
                }

                else
                {
                    MessageBox.Show("Escolha uma operação para poder calcular");
                }
            }

            if (player == 2)
            {
                if (operation == 1)
                {
                    value2 = Int32.Parse(txtVida2.Text);
                    result = value2 - value1;
                    txtVida2.Text = Convert.ToString(result);

                }
                else if (operation == 2)
                {
                    value2 = Int32.Parse(txtVida2.Text);
                    result = value2 + value1;
                    txtVida2.Text = Convert.ToString(result);
                }
                else
                {
                    MessageBox.Show("Escolha uma operação para poder calcular");
                }
            }

          

            value1 = 0;
            value2 = 0;
            result = 0;
            operation = 0;
            player = 0;

        }
       
        private void Btn_Sub_Click(object sender, RoutedEventArgs e)
        {
            
            operation = 1;
        }
        private void Btn_P1_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Player 1 foi selecionado");
            player = 1;
        }
        private void Btn_P2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Player 2 foi selecionado");
            player = 2;
        }

        private void Btn_Sum_Click(object sender, RoutedEventArgs e)
        {

            operation = 2;
        }
        private void Btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (value1 == 0)
            {
                MessageBox.Show("Digite um valor diferente de 0 para poder concatenar!");
            }
            else
            {
                value1 = value1 * 10;
            }
        }
        private void Btn_00_Click(object sender, RoutedEventArgs e)
        {
            if (value1 == 0)
            {
                MessageBox.Show("Digite um valor diferente de 0 para poder concatenar!");
            }
            else 
            {
                value1=value1 * 100;
            }
        }
        private void Btn_000_Click(object sender, RoutedEventArgs e)
        {
            if (value1 == 0)
            {
                MessageBox.Show("Digite um valor diferente de 0 para poder concatenar!");
            }
            else
            {
                value1 = value1 * 1000;
               
            }
        }

        private void Btn_Setings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Setings.xaml", UriKind.Relative));
        }
    }

       

       
    
}