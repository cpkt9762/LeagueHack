﻿#pragma checksum "..\..\..\..\Views\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9CC9F26F9D3F62D33650B7BFF94DFC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EloBuddy.Loader.Controls;
using EloBuddy.Loader.Converter;
using EloBuddy.Loader.Globals;
using EloBuddy.Loader.Types;
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


namespace Elobuddy.Loader.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : EloBuddy.Loader.Types.CustomChromeWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Elobuddy.Loader.Views.MainWindow mainWin;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image SupportUsButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GamesPlayedLabel;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GamesPlayedCountLabel;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EloBuddy.Loader.Controls.Separator StatsSeperator;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DaysLabel;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UpdateStatusLabel;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EloBuddy.Loader.Controls.UserNameControl uncUser;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EloBuddy.Loader.Controls.InstalledAddonsDataGrid InstalledAddonsGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/EloBuddy.Loader;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.mainWin = ((Elobuddy.Loader.Views.MainWindow)(target));
            return;
            case 2:
            
            #line 39 "..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SupportUsButton = ((System.Windows.Controls.Image)(target));
            
            #line 58 "..\..\..\..\Views\MainWindow.xaml"
            this.SupportUsButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SupportUsButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 63 "..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 76 "..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MaximizeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 80 "..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GamesPlayedLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.GamesPlayedCountLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.StatsSeperator = ((EloBuddy.Loader.Controls.Separator)(target));
            return;
            case 10:
            this.DaysLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.UpdateStatusLabel = ((System.Windows.Controls.Label)(target));
            
            #line 117 "..\..\..\..\Views\MainWindow.xaml"
            this.UpdateStatusLabel.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UpdateStatusLabel_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.uncUser = ((EloBuddy.Loader.Controls.UserNameControl)(target));
            return;
            case 13:
            this.InstalledAddonsGrid = ((EloBuddy.Loader.Controls.InstalledAddonsDataGrid)(target));
            return;
            case 14:
            
            #line 163 "..\..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SettingsButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

