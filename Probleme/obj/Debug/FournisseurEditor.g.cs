#pragma checksum "..\..\FournisseurEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1344A3B0B684E07B33715C57D21865EBE079EFEA1E2E23A2255B98F713C91C01"
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
    /// FournisseurEditor
    /// </summary>
    public partial class FournisseurEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\FournisseurEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ValiderButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\FournisseurEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnnulerButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\FournisseurEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ContactTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\FournisseurEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AdresseTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\FournisseurEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SiretTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FournisseurEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomEntrepriseTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\FournisseurEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NoteTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Probleme;component/fournisseureditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FournisseurEditor.xaml"
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
            this.ValiderButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\FournisseurEditor.xaml"
            this.ValiderButton.Click += new System.Windows.RoutedEventHandler(this.Valider);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AnnulerButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\FournisseurEditor.xaml"
            this.AnnulerButton.Click += new System.Windows.RoutedEventHandler(this.Annuler);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ContactTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AdresseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SiretTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.NomEntrepriseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.NoteTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

