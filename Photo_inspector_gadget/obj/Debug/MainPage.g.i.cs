﻿#pragma checksum "C:\Users\Guillaume\Documents\Visual Studio 2013\Projects\Photo_inspector_gadget\Photo_inspector_gadget\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "22EC63BF375DD26D7648373E9D356725"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18449
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Photo_inspector_gadget {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid Container;
        
        internal System.Windows.VisualStateGroup SettingsStateGroup;
        
        internal System.Windows.VisualState SettingsOpenState;
        
        internal System.Windows.VisualState SettingsClosedState;
        
        internal System.Windows.Controls.ScrollViewer SettingsPane;
        
        internal System.Windows.Controls.StackPanel ListPicture;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Canvas Canvas;
        
        internal System.Windows.Media.VideoBrush ViewfinderVideoBrush;
        
        internal System.Windows.Controls.Border FocusBracket;
        
        internal System.Windows.Controls.Image FreezeImage;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Photo_inspector_gadget;component/MainPage.xaml", System.UriKind.Relative));
            this.Container = ((System.Windows.Controls.Grid)(this.FindName("Container")));
            this.SettingsStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("SettingsStateGroup")));
            this.SettingsOpenState = ((System.Windows.VisualState)(this.FindName("SettingsOpenState")));
            this.SettingsClosedState = ((System.Windows.VisualState)(this.FindName("SettingsClosedState")));
            this.SettingsPane = ((System.Windows.Controls.ScrollViewer)(this.FindName("SettingsPane")));
            this.ListPicture = ((System.Windows.Controls.StackPanel)(this.FindName("ListPicture")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Canvas = ((System.Windows.Controls.Canvas)(this.FindName("Canvas")));
            this.ViewfinderVideoBrush = ((System.Windows.Media.VideoBrush)(this.FindName("ViewfinderVideoBrush")));
            this.FocusBracket = ((System.Windows.Controls.Border)(this.FindName("FocusBracket")));
            this.FreezeImage = ((System.Windows.Controls.Image)(this.FindName("FreezeImage")));
        }
    }
}

