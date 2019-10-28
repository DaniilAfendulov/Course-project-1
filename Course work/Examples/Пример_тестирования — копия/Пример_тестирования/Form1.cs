using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Пример_тестирования
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Тестируемый_класс
        {
            public void Квадрат_неотрицательных_четвертая_степень_отрицательных
                (double x0, double x1, double x2, out double y0, out double y1, out double y2)
            {
                //Даны три действительных числа. Возвести в квадрат те из них, 
                // значения которых неотрицательны, и в четвертую степень — отрицательные.
                if (x0 >= 0) y0 = x0 * x0;
                else y0 = x0 * x0 * x0 * x0;

                if (x1 >= 0) y1 = x1 * x1;
                else y1 = x1 * x1 * x1 * x1;

                if (x2 >= 0) y2 = x2 * x2;
                else y2 = x2 * x2 * x2 * x2;
            }

        }

        public class Тесты
        {
            public void Тест_метода_Квадрат_неотрицательных_четвертая_степень_отрицательных()
            {
                StreamReader sr = new StreamReader("../../Тесты/Тесты_метода_Квадрат_неотрицательных_четвертая_степень_отрицательных.txt");
                StreamWriter sw = new StreamWriter("../../Тесты/Результаты_тестирования_метода_Квадрат_неотрицательных_четвертая_степень_отрицательных.txt");
                double x0, x1, x2, y0, y1, y2;
                string[] delimeters_0 = { "  ", " ", "\t", "\n", "\r" };
                string строка;
                string[] слова;

                Тестируемый_класс тестируемый_класс = new Тестируемый_класс();
                               
                // Тест 1.
                строка = sr.ReadLine();
                слова = строка.Split(delimeters_0, StringSplitOptions.RemoveEmptyEntries);
                x0 = Convert.ToDouble(слова[0]);
                x1 = Convert.ToDouble(слова[1]);
                x2 = Convert.ToDouble(слова[2]);
                тестируемый_класс.Квадрат_неотрицательных_четвертая_степень_отрицательных(x0, x1, x2, out y0, out y1, out y2);
                sw.WriteLine("{0} {1} {2}", y0, y1, y2);

                // Тест 2.
                строка = sr.ReadLine();
                sr.Close();
                слова = строка.Split(delimeters_0, StringSplitOptions.RemoveEmptyEntries);
                x0 = Convert.ToDouble(слова[0]);
                x1 = Convert.ToDouble(слова[1]);
                x2 = Convert.ToDouble(слова[2]);
                тестируемый_класс.Квадрат_неотрицательных_четвертая_степень_отрицательных(x0, x1, x2, out y0, out y1, out y2);
                sw.WriteLine("{0} {1} {2}", y0, y1, y2);
                
                sw.Close();

                MessageBox.Show("OK");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Тесты тесты = new Тесты();
            тесты.Тест_метода_Квадрат_неотрицательных_четвертая_степень_отрицательных();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Пример передачи ссылки на файл в метод.
            StreamWriter sw = new StreamWriter("../../Тесты/Тест_передачи ссылки_на файл в метод.txt");
            Тестовый_класс_0 тестовый_класс_0 = new Тестовый_класс_0();
            sw.WriteLine("Тест передачи в метод 'Метод_выполняющий_вывод_в_файл' класса 'Тестовый_класс_0' ссылки на файл, содержащейся в объекте sw типа StreamWriter.");
            sw.WriteLine("Первые две строки выводятся вне вызываемого метода.");

            // Вызов метода и передача в него ссылки на файл для вывода в этот файл.
            тестовый_класс_0.Метод_выполняющий_вывод_в_файл(sw);
            
            sw.WriteLine("Эта строка выводится после выхода из метода 'Метод_выполняющий_вывод_в_файл'.");

            sw.Close();

            MessageBox.Show("OK");
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("../../Тесты/Тест_поле_класса_локальная_переменная_метода.txt");
            Тестовый_класс_0 тестовый_класс_0 = new Тестовый_класс_0();
            тестовый_класс_0.x = 1;
            sw.WriteLine("Находимся вне метода 'Метод_с_локальными_переменными', x = {0}", тестовый_класс_0.x);

            тестовый_класс_0.Метод_с_локальными_переменными(sw);

            sw.WriteLine("Находимся вне метода 'Метод_с_локальными_переменными', x = {0}", тестовый_класс_0.x);

            sw.Close();
            MessageBox.Show("OK");

        }
    }

    public class Тестовый_класс_0
    {
        public int x;

        public void Метод_выполняющий_вывод_в_файл(StreamWriter swrt)
        {
            swrt.WriteLine("Эта строка выводится в методе 'Метод_выполняющий_вывод_в_файл' класса 'Тестовый_класс_0'.");
        }

        public void Метод_с_локальными_переменными(StreamWriter swrt)
        {
            
            int x = 2;
            swrt.WriteLine("Находимся в методе 'Метод_с_локальными_переменными' x = {0}", x);
        }

    }

}
