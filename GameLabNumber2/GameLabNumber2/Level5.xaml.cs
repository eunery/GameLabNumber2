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
using System.Windows.Shapes;

namespace GameLabNumber2
{
    public partial class Level5 : Window
    {
        private int count = 0;
        public Level5()
        {
            InitializeComponent();
            answerButton.Click += answerButton_Click;
        }
        private void answerButton_Click(object sender, RoutedEventArgs e)
        {
            if (tbAnswer.Text == "") tbAnswer.Clear();
            string[] str = tbAnswer.Text.Split(' ');
            string str0 = str[0];
            string str1 = str[1];
            switch (str0)
            {
                case "1":
                    if (str[1] == "4")
                    {
                        count++;
                        logLabel.Content = logLabel.Content + "1 = Правильно";
                    }
                    break;
                case "2":
                    if (str[1] == "7")
                    {
                        count++;
                        logLabel.Content = logLabel.Content + "2 = Правильно";
                    }
                        break;
            }
            if (count == 2)
            {
                Level6 lvl6 = new Level6();
                lvl6.Show();
                LevelFive.Close();
            }
            tbAnswer.Clear();
        }
    }
}
