﻿#pragma checksum "..\..\ManagerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6BC531B692EE915BF99FD0092CEE867E355F362C4BAC7458398B3C07C9A3B4B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Aplikasi_ProyekSDP;
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


namespace Aplikasi_ProyekSDP {
    
    
    /// <summary>
    /// ManagerWindow
    /// </summary>
    public partial class ManagerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profile;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button product_btn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sales_btn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search_btn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearall_btn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button remove_btn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pay_btn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout_btn;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profile1;
        
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
            System.Uri resourceLocater = new System.Uri("/Aplikasi_ProyekSDP;component/managerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManagerWindow.xaml"
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
            this.profile = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\ManagerWindow.xaml"
            this.profile.Click += new System.Windows.RoutedEventHandler(this.profile_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.product_btn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\ManagerWindow.xaml"
            this.product_btn.Click += new System.Windows.RoutedEventHandler(this.product_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sales_btn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ManagerWindow.xaml"
            this.sales_btn.Click += new System.Windows.RoutedEventHandler(this.sales_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.search_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.clearall_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.remove_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.pay_btn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\ManagerWindow.xaml"
            this.pay_btn.Click += new System.Windows.RoutedEventHandler(this.pay_btn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.logout_btn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\ManagerWindow.xaml"
            this.logout_btn.Click += new System.Windows.RoutedEventHandler(this.logout_btn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.profile1 = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\ManagerWindow.xaml"
            this.profile1.Click += new System.Windows.RoutedEventHandler(this.profile_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

