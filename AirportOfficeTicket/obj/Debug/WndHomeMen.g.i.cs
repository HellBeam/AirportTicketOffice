﻿#pragma checksum "..\..\WndHomeMen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "36003ACC4CD01F8D74EFD08D66F0C3594909FEE6A6880461870D9967A9E6E9FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AirportOfficeTicket;
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


namespace AirportOfficeTicket {
    
    
    /// <summary>
    /// WndHomeMen
    /// </summary>
    public partial class WndHomeMen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\WndHomeMen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiRegistr;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\WndHomeMen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiSearch;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WndHomeMen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiReserve;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WndHomeMen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiHelp;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WndHomeMen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrmHome;
        
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
            System.Uri resourceLocater = new System.Uri("/AirportOfficeTicket;component/wndhomemen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WndHomeMen.xaml"
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
            this.MiRegistr = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\WndHomeMen.xaml"
            this.MiRegistr.Click += new System.Windows.RoutedEventHandler(this.MiRegistr_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MiSearch = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\WndHomeMen.xaml"
            this.MiSearch.Click += new System.Windows.RoutedEventHandler(this.MiSearch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MiReserve = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\WndHomeMen.xaml"
            this.MiReserve.Click += new System.Windows.RoutedEventHandler(this.MiReserve_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MiHelp = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\WndHomeMen.xaml"
            this.MiHelp.Click += new System.Windows.RoutedEventHandler(this.MiHelp_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FrmHome = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

