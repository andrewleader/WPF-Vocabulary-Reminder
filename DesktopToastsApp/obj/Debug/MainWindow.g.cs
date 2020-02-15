﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B9B04530394789275B6BC433DC0CB439CCDA40AA6CA9EABC0B2642FE9E01601"
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
using VocabularyReminderApp;


namespace VocabularyReminderApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Inp_ListWord;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Import;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_ProcessCrawl;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_ProcessDeleteData;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_StartLearning;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Status_ProgessBar;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Status_Message;
        
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
            System.Uri resourceLocater = new System.Uri("/Vocabulary Reminder;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Inp_ListWord = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Btn_Import = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.Btn_Import.Click += new System.Windows.RoutedEventHandler(this.Btn_Import_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_ProcessCrawl = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.Btn_ProcessCrawl.Click += new System.Windows.RoutedEventHandler(this.Btn_ProcessCrawl_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_ProcessDeleteData = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.Btn_ProcessDeleteData.Click += new System.Windows.RoutedEventHandler(this.Btn_ProcessDeleteData_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btn_StartLearning = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.Btn_StartLearning.Click += new System.Windows.RoutedEventHandler(this.Btn_StartLearning_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Status_ProgessBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 7:
            this.Status_Message = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

