﻿#pragma checksum "..\..\..\EndScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B37B80FDFC8A4E755E316605FDAEB6ADA74B158D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using vRidance;


namespace vRidance {
    
    
    /// <summary>
    /// EndScreen
    /// </summary>
    public partial class EndScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal vRidance.EndScreen wdwEndScreen;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdMain;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rctTop;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectClose;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectDark;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectMode;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblvRidance;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\EndScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblExplanation;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/vRidance;component/endscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EndScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.wdwEndScreen = ((vRidance.EndScreen)(target));
            return;
            case 2:
            this.grdMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.rctTop = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 13 "..\..\..\EndScreen.xaml"
            this.rctTop.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.rctTop_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rectClose = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 14 "..\..\..\EndScreen.xaml"
            this.rectClose.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectClose_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rectDark = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 19 "..\..\..\EndScreen.xaml"
            this.rectDark.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectDark_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rectMode = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 24 "..\..\..\EndScreen.xaml"
            this.rectMode.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectMode_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblvRidance = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblExplanation = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

