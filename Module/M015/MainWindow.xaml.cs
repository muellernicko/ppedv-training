using System;
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

namespace M015;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public int Counter;
    public MainWindow()
    {
        InitializeComponent();

        CB.ItemsSource = new List<string>() { "T1", "T2", "T3" };
   }

    private void button_click(object sender, RoutedEventArgs e)
    {
        //Events:
        //Errmöglichen die Verbindung von GUI und Backend
        //In der GUI wird das Event angehängt and die entsprechende Komponente
        //Im Backende wird dann der Code festegelegt, der bei dem Event passieren soll
        Counter++;
        TB.Text = "Zähler: " + Counter;
    }

    private void CB_SelectionChanged()
    {
        TB.Text = CB.SelectedItem + " ausgewählt";
    }
}
