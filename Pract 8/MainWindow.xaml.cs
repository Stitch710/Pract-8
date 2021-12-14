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

namespace Pract_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<IHuman> humans = new List<IHuman>();
        Guy firstGuy = new Guy("Пичугин", "Дмитрий", 18);  //добавление людей
        Guy secondGuy = new Guy("Обухов", "Сергей", 18);
        Guy thirdGuy = new Guy("Бандуркин", "Дмитрий", 18);
        Girl firstGirl = new Girl("Васинкина", "Анастасия", 18);
        Girl secondGirl = new Girl("Баева", "Ирина", 18);
        Girl thirdGirl = new Girl("Митрохина", "Ксения", 18);
         
        public MainWindow()
        {
            InitializeComponent(); //инициализация людей
            humans.Add(firstGuy);
            humans.Add(secondGuy);
            humans.Add(thirdGuy);
            humans.Add(firstGirl);
            humans.Add(secondGirl);
            humans.Add(thirdGirl);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IHuman first; //реализация интерфейса
            IHuman second;
            var filtered = humans.Where(human => human.IsSelected == true); //какой человек выбран в интерфейсе
            var list = filtered.ToList();
            if (list.Count >= 2) //встреча
            {
                first = list[0];
                second = list[1];
                first.Meeting(second);
                second.Meeting(first);
            }
        }

        private void CheckBoxCheck(object sender, RoutedEventArgs e) //выделение людей
        {
            switch (((CheckBox)sender).Name)
            {
                case "firstHuman":
                    firstGuy.IsSelected = (bool)firstHuman.IsChecked;
                    break;
                case "secondHuman":
                    secondGuy.IsSelected = (bool)secondHuman.IsChecked;
                    break;
                case "thirdHuman":
                    thirdGuy.IsSelected = (bool)thirdHuman.IsChecked;
                    break;
                case "fourthHuman":
                    firstGirl.IsSelected = (bool)fourthHuman.IsChecked;
                    break;
                case "fifthHuman":
                    secondGirl.IsSelected = (bool)fifthHuman.IsChecked;
                    break;
                case "sixthHuman":
                    thirdGirl.IsSelected = (bool)sixthHuman.IsChecked;
                    break;
            }

        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик - Пичугин Дмитрий ИСП-31\n\n Вариант 9: Создать интерфейс - человек. Создать классы – девушка и парень. Классы должны включать конструкторы, функцию для формирования строки информации очеловеке.Определить функцию реакции человека на вновь увиденного другогочеловека.Сравнение производить по фамилии", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
