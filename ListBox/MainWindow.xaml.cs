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
using System.Collections.ObjectModel;

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Color> Colores = new ObservableCollection<Color>();

        public MainWindow()
        {
           
            InitializeComponent();

            Colores.Add(new Color("rojo", "#FF000", "(255,0,0)"));
            Colores.Add(new Color("verde", "#00FF0", "(0,0,255)"));  
            Colores.Add(new Color("azul", "#000000ff", "(0,0,255)"));
            _1stcolores.ItemsSource = Colores;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Colores.Add(new Color(tb1colores.Text, tb2colores.Text, tb3colores.Text));
            tb1colores.Clear();
            tb2colores.Clear();
            tb3colores.Clear();

        }
    }
}
