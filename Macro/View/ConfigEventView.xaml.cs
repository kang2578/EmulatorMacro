﻿using Macro.Extensions;
using Macro.Models;
using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Macro.View
{
    /// <summary>
    /// ConfigEventView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ConfigEventView : UserControl
    {
        public event SelectConfigDataHandler SelectData;
        public delegate void SelectConfigDataHandler(ConfigEventModel model);

        private void ConfigEventView_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                grdSaves.SelectedItem = null;
                Model = _dummy;
                SelectData(null);
                e.Handled = true;
            }
            base.OnPreviewKeyDown(e);
        }

        private void GrdSaves_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as DataGrid).SelectedItem is ConfigEventModel item)
            {
                Model = new ConfigEventModel(item);
                SelectData(item);
                if(Model.EventType == EventType.Keyboard)
                {
                    btnMouseCoordinate.Visibility = Visibility.Collapsed;
                    txtKeyboardCmd.Visibility = Visibility.Visible;
                }
                else if(Model.EventType == EventType.Mouse)
                {
                    btnMouseCoordinate.Visibility = Visibility.Visible;
                    txtKeyboardCmd.Visibility = Visibility.Collapsed;
                }
                e.Handled = true;
            }
        }
        private void ConfigEventView_Loaded(object sender, RoutedEventArgs e)
        {
            EventInit();
            Init();
        }
        
        private void EventInit()
        {
            var radioButtons = this.FindChildren<RadioButton>();
            foreach (var button in radioButtons)
            {
                button.Click += RadioButton_Click;
            }

            btnMouseCoordinate.Click += Button_Click;
            grdSaves.SelectionChanged += GrdSaves_SelectionChanged;
            PreviewKeyDown += ConfigEventView_PreviewKeyDown;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(btnMouseCoordinate))
            {
                ShowMousePoisitionView();
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (Model == _dummy)
            {
                Model = new ConfigEventModel();
            }

            if (sender.Equals(rbMouse))
            {
                btnMouseCoordinate.Visibility = Visibility.Visible;
                txtKeyboardCmd.Visibility = Visibility.Collapsed;

                Model.EventType = EventType.Mouse;
            }
            else if (sender.Equals(rbKeyboard))
            {
                btnMouseCoordinate.Visibility = Visibility.Collapsed;
                txtKeyboardCmd.Visibility = Visibility.Visible;

                Model.EventType = EventType.Keyboard;
            }
        }
    }
}