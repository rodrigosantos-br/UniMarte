﻿#pragma checksum "..\..\..\..\Apresentacao\Obras.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5DD2CE60D95A7D6D6EED5C110EC5A787160B9034"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using UniMarteWpf.Apresentacao;


namespace UniMarteWpf.Apresentacao {
    
    
    /// <summary>
    /// Obras
    /// </summary>
    public partial class Obras : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Apresentacao\Obras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImagemAnterior;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Apresentacao\Obras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImagemAtual;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Apresentacao\Obras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TituloObra;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Apresentacao\Obras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HistoricoObra;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Apresentacao\Obras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImagemPosterior;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Apresentacao\Obras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BotaoAnterior;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Apresentacao\Obras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BotaoProximo;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\Apresentacao\Obras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UniMarte.Wpf;component/apresentacao/obras.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Apresentacao\Obras.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ImagemAnterior = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.ImagemAtual = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.TituloObra = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.HistoricoObra = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ImagemPosterior = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.BotaoAnterior = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\Apresentacao\Obras.xaml"
            this.BotaoAnterior.Click += new System.Windows.RoutedEventHandler(this.BotaoAnterior_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BotaoProximo = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\..\Apresentacao\Obras.xaml"
            this.BotaoProximo.Click += new System.Windows.RoutedEventHandler(this.BotaoProximo_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\..\..\Apresentacao\Obras.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.PaginaInicial_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

