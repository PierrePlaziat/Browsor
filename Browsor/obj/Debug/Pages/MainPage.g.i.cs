﻿#pragma checksum "..\..\..\Pages\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A17073A56707EBB0FCA34D5630B3A1E2E8B981AF8B4A160AA512BF176F095201"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Browsor;
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


namespace Browsor {
    
    
    /// <summary>
    /// Files
    /// </summary>
    public partial class Files : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List0;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List2;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox List3;
        
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
            System.Uri resourceLocater = new System.Uri("/Browsor;component/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MainPage.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.List0 = ((System.Windows.Controls.ListBox)(target));
            
            #line 22 "..\..\..\Pages\MainPage.xaml"
            this.List0.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.List1 = ((System.Windows.Controls.ListBox)(target));
            
            #line 27 "..\..\..\Pages\MainPage.xaml"
            this.List1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.List2 = ((System.Windows.Controls.ListBox)(target));
            
            #line 32 "..\..\..\Pages\MainPage.xaml"
            this.List2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.List3 = ((System.Windows.Controls.ListBox)(target));
            
            #line 37 "..\..\..\Pages\MainPage.xaml"
            this.List3.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.List_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

