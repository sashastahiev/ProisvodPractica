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

namespace GeneratorKey
{
    public partial class Form1 : Form
    {
        int k = 0;
        Random rand;
        char[] keyText = new char[166]
        { 'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О',
          'П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','ъ','Ы','Ь','Э','Ю',
          'Я','а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н',
          'о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э',
          'ю','я','A','B','C','D','E','F','G','H','I','J','K','L','M','N',
          'O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d',
          'e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t',
          'u','v','w','x','y','z',',','.',':',';','!','?',' ','*','/','@',
          '|','~','#','[',']','{','}','<','>','^','(',')','-','+','=','\'',
          '"','\\','1','2','\n','\r','5','6','7','8','9','0','%','&','`','_',
          '«','»','—','$','3','4'};
        char[] keyParol = new char[76]
        { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N',
          'O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d',
          'e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t',
          'u','v','w','x','y','z','1','2','5','6','7','8','9','0','3','4',
          'A','B','C','D','k','l','m','n','1','2','5','6','N','w'};
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            if (!Directory.Exists(@"C:\Stels"))
            {
                Directory.CreateDirectory(@"C:\Stels");
            }
            if (!File.Exists(@"C:\Stels\AdressKeyForText.txt"))
            {
                File.Create(@"C:\Stels\AdressKeyForText.txt");
            }
            if (!File.Exists(@"C:\Stels\AdressKeyForParol.txt"))
            {
                File.Create(@"C:\Stels\AdressKeyForParol.txt");
            }

            if (!File.Exists(@"C:\Stels\AdressKeyShifrator.txt"))
            {
                File.Create(@"C:\Stels\AdressKeyShifrator.txt");
            }
            if (!File.Exists(@"C:\Stels\AdressKeyParol.txt"))
            {
                File.Create(@"C:\Stels\AdressKeyParol.txt");
            }
        }
        bool independ(int[] mas, int r)
        {
            bool ind = false; for (int i = 0; i < r; i++) { if (mas[i] == mas[r]) ind = true; } return ind;
        }
        private void Generic_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && ((checkBoxParol.Checked == true && checkBoxText.Checked == false)
                || (checkBoxParol.Checked == false && checkBoxText.Checked == true)))
            {
                int o = 0;
                if (checkBoxParol.Checked == true && checkBoxText.Checked == false)
                    o = 76;
                else 
                    o = 166;
                succes.Text = "";
                int[] num = new int[o];
                for (int i = 0; i < o; i++)//генерация случайной последовательности.
                {
                    num[i] = rand.Next(o);
                    while (independ(num, i)) 
                        num[i] = rand.Next(o);
                }
                char[] newkey = new char[o];
                if (checkBoxParol.Checked == true && checkBoxText.Checked == false)
                {
                    for (int i = 0; i < o; i++)//Создание нового ключа
                    {
                        newkey[i] = keyParol[num[i]];
                    }
                }
                else 
                {
                    for (int i = 0; i < o; i++)
                    {
                        newkey[i] = keyText[num[i]];
                    }
                }
                string path = textBox1.Text;
                if (checkBoxParol.Checked == true && checkBoxText.Checked == false)
                {
                    StreamWriter sw1 = new StreamWriter(@"C:\Stels\AdressKeyForParol.txt");
                    sw1.Write(path);
                    sw1.Close();
                    StreamWriter sw2 = new StreamWriter(@"C:\Stels\AdressKeyParol.txt");
                    sw2.Write(path);
                    sw2.Close();
                }
                if (checkBoxParol.Checked == false && checkBoxText.Checked == true)
                {
                    StreamWriter sw4 = new StreamWriter(@"C:\Stels\AdressKeyForText.txt");
                    sw4.Write(path);
                    sw4.Close();
                    StreamWriter sw5 = new StreamWriter(@"C:\Stels\AdressKeyShifrator.txt");
                    sw5.Write(path);
                    sw5.Close();
                }
                path += ".txt";
                StreamWriter sw3 = new StreamWriter(path);
                sw3.Write(newkey);
                sw3.Close();
                if (k == 0) { 
                    succes.Text = "Успешно!"; k++; 
                }
                else { 
                    succes.Text = "Успешно! " + "(" + k + ")"; k++; 
                }
            }
            else
            {
                textBox1.BackColor = Color.Pink;
                textBox1.Text = "Выберите 1 из вариантов видов ключей и введите адрес загрузки ключа и !";
            }

        }

        private void Generic_MouseEnter(object sender, EventArgs e){ Generic.BackColor = Color.Azure; }

        private void Generic_MouseLeave(object sender, EventArgs e){ Generic.BackColor = Color.Transparent; }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.BackColor == Color.Pink)
            {
                textBox1.BackColor = Color.White;
                textBox1.Text = "";
            }
        }

        private void checkBoxParol_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxParol.Checked == true)
            {
                StreamReader rs = new StreamReader(@"C:\Stels\AdressKeyForParol.txt");
                string s;
                s = rs.ReadToEnd();
                rs.Close();
                textBox1.Text = "";
                textBox1.Text = s;
            }
            else
                textBox1.Text = "";
        }

        private void checkBoxText_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxText.Checked == true)
            {
                StreamReader rs2 = new StreamReader(@"C:\Stels\AdressKeyForText.txt");
                string s1;
                s1 = rs2.ReadToEnd();
                rs2.Close();
                textBox1.Text = "";
                textBox1.Text = s1;
            }
            else
                textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  \"Генератор\" — приложение для генерации ключей для алгоритма Плейфера. " + 
                "Алгоритм использования: \n" + 
                "1) Выберите предмет шифрования: \"Для паролей\" или \"Для текста\". \n" +
                "2) Введите адрес файла формата .txt, куда нужно записать ключ (формат писать не нужно). \n" +
                "3) Нажмите \"Генерировать\".","Руководство по использованию");
        }
    }
}
