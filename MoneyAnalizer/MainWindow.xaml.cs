﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoneyAnalizer
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int i = 0;

        private void ChangeAwatar(int j)
        {
            BitmapImage User = new BitmapImage();
            switch (j)
            {
                case 1:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 2:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_women2.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 3:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_waiter2.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 4:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_women.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 5:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_accountant.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 6:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_cook.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 7:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_doctor.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 8:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_girl.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 9:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_girl2.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 10:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_grandpa.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 11:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_solider.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 12:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_thief.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;

                case 13:
                    User.BeginInit();
                    User.UriSource = new Uri(@"icons/user_waiter.png", UriKind.Relative);
                    User.EndInit();
                    img_avatar.Source = User;
                    break;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            i = Properties.Settings.Default.AwatarID;
            ChangeAwatar(i);
        }


        int k = 0;
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            k++;
            ChangeAwatar(k);
            Properties.Settings.Default.AwatarID = k;
            Properties.Settings.Default.Save();
            if (k >= 13) k = 0;
        }
    }
}
