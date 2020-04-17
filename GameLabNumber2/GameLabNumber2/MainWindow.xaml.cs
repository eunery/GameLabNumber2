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

namespace GameLabNumber2
{
    public partial class MainWindow : Window
    {
        private int namer = 0;
        private string answerTrue = "01371349";
        List<int> listCheckBox = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
            dpMain.Children.Add(dPanel);
            rbOne.Click += rbOne_Click;
            rbTwo.Click += rbTwo_Click;
            clearingButton.Click += clearingButton_Click;
            buttonAnswer.Click += buttonAnswer_Click;
        }
        DockPanel dPanel = new DockPanel()
        {
            Name = "dPanel",
            Margin = new Thickness(5, 0, 5, 0),
            HorizontalAlignment = HorizontalAlignment.Center,
        };
        private void buttonAnswer_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rbOne.IsChecked)
            {
                foreach (var obj in dPanel.Children)
                {
                    CheckBox chBox = (CheckBox)obj;
                    if ((bool)chBox.IsChecked)
                    {
                        listCheckBox.Add(Convert.ToInt32(chBox.Content));
                    }
                }
            }
            if ((bool)rbTwo.IsChecked)
            {
                foreach (var obj in dPanel.Children)
                {
                    CheckBox chBox = (CheckBox)obj;
                    if ((bool)chBox.IsChecked)
                    {
                        listCheckBox.Add(Convert.ToInt32(chBox.Content));
                    }
                }
            }
            string str = "";
            if (listCheckBox.Count == 8) // 01371349
            {
                foreach (var item in listCheckBox)
                {
                    str += item;
                }
            }
            if (str.Equals(answerTrue))
            {
                Level5 lvl5 = new Level5();
                lvl5.Show();
                Level4.Close();
            }
        }
        private void rbOne_Click(object sender, RoutedEventArgs e)
        {
            namer = 0;
            dPanel.Children.Clear();
            for (int i = 0; i <= 9; i++)
            {
                CheckBox chBox = new CheckBox()
                {
                    Name = "chBox" + namer,
                    Content = namer,
                    Margin = new Thickness(5, 0, 5, 0),
                };
                namer++;
                dPanel.Children.Add(chBox);
            }
        }
        private void rbTwo_Click(object sender, RoutedEventArgs e)
        {
            namer = 0;
            dPanel.Children.Clear();
            for (int i = 0; i <= 9; i++)
            {
                namer++;
                CheckBox chBox = new CheckBox()
                {
                    Name = "chBox" + namer,
                    Content = namer,
                    Margin = new Thickness(5, 0, 5, 0),
                };
                dPanel.Children.Add(chBox);
            }   
        }
        private void clearingButton_Click(object sender, RoutedEventArgs e)
        {
            listCheckBox.Clear();
        }
    }
}