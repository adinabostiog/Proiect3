﻿#pragma checksum "..\..\..\Views\RestaurantNavbar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3CC029FFA8C15A57835DA1B4990185F109824C8EA6A50BBB0EA3E6A9C9A5A1C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SiCuAstaPasta.ViewModels;
using SiCuAstaPasta.Views;
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


namespace SiCuAstaPasta.Views {
    
    
    /// <summary>
    /// RestaurantNavbar
    /// </summary>
    public partial class RestaurantNavbar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Views\RestaurantNavbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SiCuAstaPasta.ViewModels.RestaurantViewModel ViewModel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\RestaurantNavbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NumeUtilizator;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\RestaurantNavbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButonComenzi;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\RestaurantNavbar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButonCarucior;
        
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
            System.Uri resourceLocater = new System.Uri("/SiCuAstaPasta;component/views/restaurantnavbar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\RestaurantNavbar.xaml"
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
            this.ViewModel = ((SiCuAstaPasta.ViewModels.RestaurantViewModel)(target));
            return;
            case 2:
            this.NumeUtilizator = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            
            #line 25 "..\..\..\Views\RestaurantNavbar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Deconectare_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButonComenzi = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Views\RestaurantNavbar.xaml"
            this.ButonComenzi.Click += new System.Windows.RoutedEventHandler(this.Comenzi_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButonCarucior = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Views\RestaurantNavbar.xaml"
            this.ButonCarucior.Click += new System.Windows.RoutedEventHandler(this.Carucior_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

