﻿#pragma checksum "..\..\..\..\Apresentacao\Cadastro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9FA422F5B77523E20D359C360EFAA5CAB25235A8"
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
using UniMarte.Wpf.ControleCustomizado;


namespace UniMarte.Wpf.Apresentacao {
    
    
    /// <summary>
    /// Cadastro
    /// </summary>
    public partial class Cadastro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Apresentacao\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdm;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Apresentacao\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Apresentacao\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNome;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Apresentacao\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpDataNascimento;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Apresentacao\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UniMarte.Wpf.ControleCustomizado.TecladoVirtual Teclado;
        
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
            System.Uri resourceLocater = new System.Uri("/UniMarte.Wpf;V1.0.0.0;component/apresentacao/cadastro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Apresentacao\Cadastro.xaml"
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
            this.btnAdm = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Apresentacao\Cadastro.xaml"
            this.btnAdm.Click += new System.Windows.RoutedEventHandler(this.btnAdm_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Apresentacao\Cadastro.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.PaginaInicial_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbNome = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\..\Apresentacao\Cadastro.xaml"
            this.txbNome.GotFocus += new System.Windows.RoutedEventHandler(this.Control_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dtpDataNascimento = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            
            #line 100 "..\..\..\..\Apresentacao\Cadastro.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cadastrar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Teclado = ((UniMarte.Wpf.ControleCustomizado.TecladoVirtual)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

