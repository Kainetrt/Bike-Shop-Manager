﻿#pragma checksum "..\..\GestionStock.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1692561B56C7CEC4EB4B14BBF6171163E8B3FBA16E7CFB2F73158E032FC5BC2B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Probleme;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace Probleme {
    
    
    /// <summary>
    /// GestionStock
    /// </summary>
    public partial class GestionStock : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\GestionStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewPiece;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\GestionStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewVelo;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\GestionStock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Probleme;component/gestionstock.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GestionStock.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PieceTriPiece);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FournisseurTriPiece);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.VeloTriPiece);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListViewPiece = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.ListViewVelo = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 36 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PieceTriVelo);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 37 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FournisseurTriVelo);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 38 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.VeloTriVelo);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 39 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CategorieTriVelo);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 40 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GrandeurTriVelo);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 41 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrixTriPiece);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 42 "..\..\GestionStock.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrixTriVelo);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
