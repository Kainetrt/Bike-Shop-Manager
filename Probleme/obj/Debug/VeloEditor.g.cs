﻿#pragma checksum "..\..\VeloEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E8C2BC0393D5592E8536BF62523EB1D8D04DCE9F9301126B4D6AD0B9175C7839"
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
    /// VeloEditor
    /// </summary>
    public partial class VeloEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\VeloEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GrixVelo;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\VeloEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ValiderButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\VeloEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnnulerButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\VeloEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumeroTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\VeloEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\VeloEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrixTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\VeloEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GammeTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\VeloEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GrandeurTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Probleme;component/veloeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VeloEditor.xaml"
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
            this.GrixVelo = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ValiderButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\VeloEditor.xaml"
            this.ValiderButton.Click += new System.Windows.RoutedEventHandler(this.Valider);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AnnulerButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\VeloEditor.xaml"
            this.AnnulerButton.Click += new System.Windows.RoutedEventHandler(this.Annuler);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NumeroTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NomTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PrixTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.GammeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.GrandeurTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

