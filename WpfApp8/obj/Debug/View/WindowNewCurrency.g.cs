﻿#pragma checksum "..\..\..\View\WindowNewCurrency.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ADA27B42EFA10F17ED5862D74DBE887168F0975A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp8.View;


namespace WpfApp8.View {
    
    
    /// <summary>
    /// WindowNewCurrency
    /// </summary>
    public partial class WindowNewCurrency : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\View\WindowNewCurrency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbId;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\WindowNewCurrency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbRole;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\WindowNewCurrency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbRole2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\WindowNewCurrency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtSave;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\WindowNewCurrency.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtCansel;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp8;component/view/windownewcurrency.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\WindowNewCurrency.xaml"
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
            this.TbId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TbRole = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TbRole2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtSave = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\WindowNewCurrency.xaml"
            this.BtSave.Click += new System.Windows.RoutedEventHandler(this.BtSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtCansel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

