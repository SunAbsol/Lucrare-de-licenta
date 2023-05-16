﻿#pragma checksum "..\..\..\..\View\SettingsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72EA2667E1680322D4647D173AB885537A9D708A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NewBank2.View;
using NewBank2.ViewModel;
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


namespace NewBank2.View {
    
    
    /// <summary>
    /// SettingsView
    /// </summary>
    public partial class SettingsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ButtonsStackPanel;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateAccount;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnActivateDeactivateAccount;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteAccount;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAccountSettingsBank;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\..\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStatementBank;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\..\View\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NewBank2;component/view/settingsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\SettingsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ButtonsStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.btnCreateAccount = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\View\SettingsView.xaml"
            this.btnCreateAccount.Click += new System.Windows.RoutedEventHandler(this.btnCreateAccount_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnActivateDeactivateAccount = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\View\SettingsView.xaml"
            this.btnActivateDeactivateAccount.Click += new System.Windows.RoutedEventHandler(this.btnActivateDeactivateAccount_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDeleteAccount = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\..\View\SettingsView.xaml"
            this.btnDeleteAccount.Click += new System.Windows.RoutedEventHandler(this.btnDeleteAccount_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAccountSettingsBank = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\..\..\View\SettingsView.xaml"
            this.btnAccountSettingsBank.Click += new System.Windows.RoutedEventHandler(this.btnAccountSettingsBank_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnStatementBank = ((System.Windows.Controls.Button)(target));
            
            #line 187 "..\..\..\..\View\SettingsView.xaml"
            this.btnStatementBank.Click += new System.Windows.RoutedEventHandler(this.btnStatementBank_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 220 "..\..\..\..\View\SettingsView.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

