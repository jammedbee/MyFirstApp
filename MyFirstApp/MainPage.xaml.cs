using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyFirstApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageTextBlock.Text = "Hello";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (5 == (int)MyEnum.Value1)
            {

            }
        }

        public enum MyEnum : int
        {
            Value1 = 1,
            Value2 = 2,
            Value3 = 3,
            Value4 = 4
        }
    }
}
