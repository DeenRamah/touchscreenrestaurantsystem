﻿#pragma checksum "..\..\..\Interaction\KeyboardWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "591739C77E34545DCFF986889FE20D394679B18828F9DD79A90B7DABEA879601"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PropertyTools.Wpf;
using Samba.Presentation.Controls.VirtualKeyboard;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Samba.Presentation.Controls.Interaction {
    
    
    /// <summary>
    /// KeyboardWindow
    /// </summary>
    public partial class KeyboardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Interaction\KeyboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Interaction\KeyboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Samba.Presentation.Controls.VirtualKeyboard.KeyboardView Keyb;
        
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
            System.Uri resourceLocater = new System.Uri("/Samba.Presentation.Controls;component/interaction/keyboardwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Interaction\KeyboardWindow.xaml"
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
            
            #line 9 "..\..\..\Interaction\KeyboardWindow.xaml"
            ((Samba.Presentation.Controls.Interaction.KeyboardWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Interaction\KeyboardWindow.xaml"
            ((Samba.Presentation.Controls.Interaction.KeyboardWindow)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Window_Unloaded);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Interaction\KeyboardWindow.xaml"
            ((Samba.Presentation.Controls.Interaction.KeyboardWindow)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Interaction\KeyboardWindow.xaml"
            ((Samba.Presentation.Controls.Interaction.KeyboardWindow)(target)).Deactivated += new System.EventHandler(this.Window_Deactivated);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\Interaction\KeyboardWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\..\Interaction\KeyboardWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 28 "..\..\..\Interaction\KeyboardWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Interaction\KeyboardWindow.xaml"
            this.TextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Keyb = ((Samba.Presentation.Controls.VirtualKeyboard.KeyboardView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

