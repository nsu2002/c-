using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Product_Management_Project.models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Product_Management_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Item> items;
        public MainPage()
        {
            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/carmauden.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/carmauvang.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/carmauxanhh.jpg" });

            items = new ObservableCollection<Item>();
            items.Add(new Item { Pruduct = "xe ô tô ", Description = "Nó là xe ô tô màu xanh", ImgPath = "Assets/carmauxanhh.jpg" });
            this.InitializeComponent();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            string imgpath = ((Icon)MyCombobox.SelectedValue).IconPath;
            items.Add(new Item { Pruduct = ProductReults.Text, Description = DescriptionReults.Text, ImgPath = imgpath });

            ProductReults.Text = "";
            DescriptionReults.Text = "";
            MyCombobox.SelectedIndex = -1;

            ProductReults.Focus(FocusState.Programmatic);


        }
    }
}