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

namespace gamelibr
{
    /// <summary>
    /// Логика взаимодействия для addgame.xaml
    /// </summary>
    public partial class addgame : Window
    {
        public addgame()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Назад"
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Перейти в библиотеку"
            // Вставьте здесь логику перехода в библиотеку
        }

        private void AddToLibraryButton_Click(object sender, RoutedEventArgs e)
        {
            // Обработка нажатия кнопки "Добавить в библиотеку"
            string title = TitleTextBox.Text;
            string genre = GenreTextBox.Text;
            string platform = PlatformTextBox.Text;
            string year = YearTextBox.Text;

            // Вставьте здесь логику добавления игры в библиотеку
            // Например, вывод сообщения об успешном добавлении
            MessageBox.Show($"Игра \"{title}\" успешно добавлена в библиотеку!");
        }
    }
}