#pragma checksum "..\..\..\UI\WndLogon.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "554AA0DDAB6DC69CBA49BCCBFF30EDF15FB1C3A3250EA77898CE3AD661B1E0A6"
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
    /// WndLogon
    /// </summary>
    public partial class WndLogon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\UI\WndLogon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtbLogin;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\UI\WndLogon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Passbx;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\UI\WndLogon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtbPass;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\UI\WndLogon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChckbPass;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\UI\WndLogon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLog;
        
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
            System.Uri resourceLocater = new System.Uri("/AirportOfficeTicket;component/ui/wndlogon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\WndLogon.xaml"
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
            this.TxtbLogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\UI\WndLogon.xaml"
            this.TxtbLogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtbLogin_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Passbx = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.TxtbPass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ChckbPass = ((System.Windows.Controls.CheckBox)(target));
            
            #line 88 "..\..\..\UI\WndLogon.xaml"
            this.ChckbPass.Click += new System.Windows.RoutedEventHandler(this.ChckbPass_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnLog = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\UI\WndLogon.xaml"
            this.BtnLog.Click += new System.Windows.RoutedEventHandler(this.BtnLog_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

