﻿#pragma checksum "..\..\..\..\Apresentacao\Adm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E3DF61566C3B0E80C0B851604761A9434D444C34"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Web.WebView2.Wpf;
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
using UniMarteWpf.ControleCustomizado;


namespace UniMarteWpf.Apresentacao {
    
    
    /// <summary>
    /// Adm
    /// </summary>
    public partial class Adm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\Apresentacao\Adm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRelatorio;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Apresentacao\Adm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGerenciadorUsuarios;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Apresentacao\Adm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFinalizarSoftware;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Apresentacao\Adm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdGerenciador;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Apresentacao\Adm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UniMarteWpf.ControleCustomizado.RelatorioAdm relatorioAdm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UniMarteWpf;V1.0.0.0;component/apresentacao/adm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Apresentacao\Adm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnRelatorio = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Apresentacao\Adm.xaml"
            this.btnRelatorio.Click += new System.Windows.RoutedEventHandler(this.Relatorio_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnGerenciadorUsuarios = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Apresentacao\Adm.xaml"
            this.btnGerenciadorUsuarios.Click += new System.Windows.RoutedEventHandler(this.Gerencia_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnFinalizarSoftware = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Apresentacao\Adm.xaml"
            this.btnFinalizarSoftware.Click += new System.Windows.RoutedEventHandler(this.FinalizarSoftware_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grdGerenciador = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.relatorioAdm = ((UniMarteWpf.ControleCustomizado.RelatorioAdm)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

