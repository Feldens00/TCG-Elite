﻿#pragma checksum "C:\Users\Artur\Desktop\Ulbra\Linguagem de Programação Comercial\TCG Elite\TCG Elite\PivotTCG.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3FEA3BEDBB053953924735881AC2B77A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace TCG_Elite {
    
    
    public partial class PivotTCG : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.PivotItem jogadores;
        
        internal System.Windows.Controls.ListBox lstJogadores;
        
        internal Microsoft.Phone.Controls.PivotItem pokemon;
        
        internal System.Windows.Controls.ListBox lstpok;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/TCG%20Elite;component/PivotTCG.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.jogadores = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("jogadores")));
            this.lstJogadores = ((System.Windows.Controls.ListBox)(this.FindName("lstJogadores")));
            this.pokemon = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("pokemon")));
            this.lstpok = ((System.Windows.Controls.ListBox)(this.FindName("lstpok")));
        }
    }
}

