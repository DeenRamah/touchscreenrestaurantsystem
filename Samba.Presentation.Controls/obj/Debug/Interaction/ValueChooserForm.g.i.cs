﻿#pragma checksum "..\..\..\Interaction\ValueChooserForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EE80D17BD0A0DBD14D966532F78999F7F0372A2DC7FEE0835FC0BB6D83F3CC59"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GongSolutions.Wpf.DragDrop;
using Samba.Localization.Engine;
using Samba.Localization.Extensions;
using Samba.Presentation.Controls.UIControls;
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
    /// ValueChooserForm
    /// </summary>
    public partial class ValueChooserForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Interaction\ValueChooserForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Interaction\ValueChooserForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DescriptionLabel;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Interaction\ValueChooserForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ValuesLabel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Interaction\ValueChooserForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ValuesListBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Interaction\ValueChooserForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Samba.Presentation.Controls.UIControls.SearchTextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Interaction\ValueChooserForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedValuesLabel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Interaction\ValueChooserForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SelectedValuesListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Samba.Presentation.Controls;component/interaction/valuechooserform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Interaction\ValueChooserForm.xaml"
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
            
            #line 4 "..\..\..\Interaction\ValueChooserForm.xaml"
            ((Samba.Presentation.Controls.Interaction.ValueChooserForm)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Window_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\Interaction\ValueChooserForm.xaml"
            ((Samba.Presentation.Controls.Interaction.ValueChooserForm)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.DescriptionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ValuesLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ValuesListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 28 "..\..\..\Interaction\ValueChooserForm.xaml"
            this.ValuesListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ValuesListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 32 "..\..\..\Interaction\ValueChooserForm.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SearchTextBox = ((Samba.Presentation.Controls.UIControls.SearchTextBox)(target));
            return;
            case 8:
            this.SelectedValuesLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.SelectedValuesListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\..\Interaction\ValueChooserForm.xaml"
            this.SelectedValuesListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SelectedValuesListBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 44 "..\..\..\Interaction\ValueChooserForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 45 "..\..\..\Interaction\ValueChooserForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 49 "..\..\..\Interaction\ValueChooserForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 50 "..\..\..\Interaction\ValueChooserForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

