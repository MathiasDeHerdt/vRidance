﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159CF663CA9772CD3A0EBD3B1CC66EB354B366B6"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal vRidance.MainWindow wdwVRidance;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdMain;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rctTop;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstItems;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectClose;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectDark;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectMode;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectUpload;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectNext;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rectNextDis;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblvRidance;
        
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
            System.Uri resourceLocater = new System.Uri("/vRidance;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            this.wdwVRidance = ((vRidance.MainWindow)(target));
            return;
            case 2:
            this.grdMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.rctTop = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 16 "..\..\..\MainWindow.xaml"
            this.rctTop.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.rctTop_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lstItems = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.rectClose = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.rectClose.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectClose_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rectDark = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.rectDark.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectDark_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rectMode = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 28 "..\..\..\MainWindow.xaml"
            this.rectMode.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectMode_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rectUpload = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 33 "..\..\..\MainWindow.xaml"
            this.rectUpload.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectUpload_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rectNext = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 38 "..\..\..\MainWindow.xaml"
            this.rectNext.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.rectNext_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rectNextDis = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 11:
            this.lblvRidance = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

