using Student_Manager.models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Student_Manager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<studentlist> Studentlists;
        public MainPage()
        {
            this.InitializeComponent();
            Studentlists = new ObservableCollection<studentlist>();
            Studentlists.Add(new studentlist { Name = "Nguyễn Sử", YearofBirth = "2001", AvatarPath = "Assets/mixi.jpg" });
            Studentlists.Add(new studentlist { Name = "Nguyễn Sử", YearofBirth = "2002", AvatarPath = "Assets/mixi.jpg" });
            Studentlists.Add(new studentlist { Name = "Nguyễn Sử", YearofBirth = "2003", AvatarPath = "Assets/mixi.jpg" });
            Studentlists.Add(new studentlist { Name = "Nguyễn Sử", YearofBirth = "2004", AvatarPath = "Assets/mixi.jpg" });

        }
    }
}
