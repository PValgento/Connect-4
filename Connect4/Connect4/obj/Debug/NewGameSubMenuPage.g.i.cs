﻿#pragma checksum "..\..\NewGameSubMenuPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2301B4C9EF7D6E39C91D6C8179EB54B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Connect4;
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


namespace Connect4 {
    
    
    /// <summary>
    /// NewGameSubMenuPage
    /// </summary>
    public partial class NewGameSubMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\NewGameSubMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txtb_Player1Name;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\NewGameSubMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txtb_Player2Name;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\NewGameSubMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lbl_Player1Name;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\NewGameSubMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lbl_Player2Name;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\NewGameSubMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChBx_AIPlayer1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\NewGameSubMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChBx_AIPlayer2;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\NewGameSubMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_StartGame;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\NewGameSubMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lbl_Title;
        
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
            System.Uri resourceLocater = new System.Uri("/Connect4;component/newgamesubmenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewGameSubMenuPage.xaml"
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
            this.Txtb_Player1Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Txtb_Player2Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Lbl_Player1Name = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Lbl_Player2Name = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ChBx_AIPlayer1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.ChBx_AIPlayer2 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.Btn_StartGame = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\NewGameSubMenuPage.xaml"
            this.Btn_StartGame.Click += new System.Windows.RoutedEventHandler(this.Btn_StartGame_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Lbl_Title = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

