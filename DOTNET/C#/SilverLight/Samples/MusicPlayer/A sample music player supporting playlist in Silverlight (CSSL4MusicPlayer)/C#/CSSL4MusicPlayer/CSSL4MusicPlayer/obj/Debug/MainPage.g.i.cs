﻿#pragma checksum "D:\MyPractices\DOTNET\C#\SilverLight\Samples\MusicPlayer\A sample music player supporting playlist in Silverlight (CSSL4MusicPlayer)\C#\CSSL4MusicPlayer\CSSL4MusicPlayer\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5FD332B6C7F9C55C3F6E2A60C235E7BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace CSSL4MusicPlayer {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.MediaElement mediaElement;
        
        internal System.Windows.Controls.Button btnStop;
        
        internal System.Windows.Controls.Button btnPlay;
        
        internal System.Windows.Controls.Button btnPause;
        
        internal System.Windows.Controls.Button btnMuted;
        
        internal System.Windows.Controls.Button btnFullScreen;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.DataGrid girdList;
        
        internal System.Windows.Controls.TextBlock tbTitle;
        
        internal System.Windows.Controls.Slider sliderProcess;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBlock tbTag1;
        
        internal System.Windows.Controls.Slider sliderBalance;
        
        internal System.Windows.Controls.TextBlock tbTag2;
        
        internal System.Windows.Controls.TextBlock tbTag;
        
        internal System.Windows.Controls.TextBlock tbStatus;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/CSSL4MusicPlayer;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.mediaElement = ((System.Windows.Controls.MediaElement)(this.FindName("mediaElement")));
            this.btnStop = ((System.Windows.Controls.Button)(this.FindName("btnStop")));
            this.btnPlay = ((System.Windows.Controls.Button)(this.FindName("btnPlay")));
            this.btnPause = ((System.Windows.Controls.Button)(this.FindName("btnPause")));
            this.btnMuted = ((System.Windows.Controls.Button)(this.FindName("btnMuted")));
            this.btnFullScreen = ((System.Windows.Controls.Button)(this.FindName("btnFullScreen")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.girdList = ((System.Windows.Controls.DataGrid)(this.FindName("girdList")));
            this.tbTitle = ((System.Windows.Controls.TextBlock)(this.FindName("tbTitle")));
            this.sliderProcess = ((System.Windows.Controls.Slider)(this.FindName("sliderProcess")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.tbTag1 = ((System.Windows.Controls.TextBlock)(this.FindName("tbTag1")));
            this.sliderBalance = ((System.Windows.Controls.Slider)(this.FindName("sliderBalance")));
            this.tbTag2 = ((System.Windows.Controls.TextBlock)(this.FindName("tbTag2")));
            this.tbTag = ((System.Windows.Controls.TextBlock)(this.FindName("tbTag")));
            this.tbStatus = ((System.Windows.Controls.TextBlock)(this.FindName("tbStatus")));
        }
    }
}
