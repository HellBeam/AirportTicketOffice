﻿#pragma checksum "..\..\..\UI\PgAddCust.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "300AA4349D79BA66D3265E521404D7847EC9442BF7B4AA85F95DF9846414EF49"
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
    /// PgAddCust
    /// </summary>
    public partial class PgAddCust : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\UI\PgAddCust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtbSurnameCust;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\UI\PgAddCust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtbNameCust;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\UI\PgAddCust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtbPatronymicCust;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\UI\PgAddCust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtbPhone;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\UI\PgAddCust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtbEMail;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\UI\PgAddCust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DtpckBirthdayCust;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\UI\PgAddCust.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCust;
        
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
            System.Uri resourceLocater = new System.Uri("/AirportOfficeTicket;component/ui/pgaddcust.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\PgAddCust.xaml"
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
            this.TxtbSurnameCust = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtbNameCust = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtbPatronymicCust = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtbPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtbEMail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DtpckBirthdayCust = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.btnAddCust = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\UI\PgAddCust.xaml"
            this.btnAddCust.Click += new System.Windows.RoutedEventHandler(this.btnAddCust_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

