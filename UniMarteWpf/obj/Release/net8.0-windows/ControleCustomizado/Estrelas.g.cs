﻿#pragma checksum "..\..\..\..\ControleCustomizado\Estrelas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E261FAB861CCFE5290612589EA017A0975D3C7E1"
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
using UniMarteWpf.ControleCustomizado;


namespace UniMarteWpf.ControleCustomizado {
    
    
    /// <summary>
    /// Estrelas
    /// </summary>
    public partial class Estrelas : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ctcPergunta;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox estrelaPessimo;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox estrelaRuim;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox estrelaRegular;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox estrelaBom;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox estrelaOtimo;
        
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
            System.Uri resourceLocater = new System.Uri("/UniMarte.Wpf;component/controlecustomizado/estrelas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
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
            this.ctcPergunta = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 2:
            this.estrelaPessimo = ((System.Windows.Controls.CheckBox)(target));
            
            #line 41 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaPessimo.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaPessimo.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.estrelaRuim = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaRuim.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaRuim.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.estrelaRegular = ((System.Windows.Controls.CheckBox)(target));
            
            #line 51 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaRegular.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaRegular.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.estrelaBom = ((System.Windows.Controls.CheckBox)(target));
            
            #line 55 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaBom.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaBom.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.estrelaOtimo = ((System.Windows.Controls.CheckBox)(target));
            
            #line 59 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaOtimo.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\..\ControleCustomizado\Estrelas.xaml"
            this.estrelaOtimo.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

