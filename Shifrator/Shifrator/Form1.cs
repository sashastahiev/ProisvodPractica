using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace Shifrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(@"C:\Stels"))
            {
                Directory.CreateDirectory(@"C:\Stels");
            }
            string path = @"C:\Stels\AdressKeyShifrator.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.OpenRead(path);
            string s = "";
            StreamReader sw = new StreamReader(path);
            s = sw.ReadToEnd();
            Pouth.Text = s;
            sw.Close();
        }
        char[] key = new char[166];
        //{ 'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О',
        //  'П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','ъ','Ы','Ь','Э','Ю',
        //  'Я','а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н',
        //  'о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э',
        //  'ю','я','A','B','C','D','E','F','G','H','I','J','K','L','M','N',
        //  'O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d',
        //  'e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t',
        //  'u','v','w','x','y','z',',','.',':',';','!','?',' ','*','/','@',
        //  '|','~','#','[',']','{','}','<','>','^','(',')','-','+','=','\'',
        //  '"','\\','1','2','\n','\r','5','6','7','8','9','0','%','&','`','_',
        //  '«','»','—','$','3','4'};

        protected virtual bool IsFileinUse(FileInfo file)
        {
            FileStream stream = null;
            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }
        void Pleifer_Potok(int count, char[] p, char[] sp, int ki)
        {
            int n1 = -1, n2 = -1, ost1 = 0, ost2 = 0;
            while (ki < count)
            {
                for (int i = 0; i < 166; i++){if (p[ki] == key[i]) { n1 = i; }if (p[ki + 1] == key[i]) { n2 = i; }}
                ost1 = n1 % 2;
                ost2 = n2 % 2;
                if (ost1 < ost2){sp[ki] = key[n1 + (ost2 - ost1)];sp[ki + 1] = key[n2 - (ost2 - ost1)];}
                if (ost1 > ost2){sp[ki] = key[n1 - (ost1 - ost2)];sp[ki + 1] = key[n2 + (ost1 - ost2)];}
                if (ost1 == ost2){sp[ki] = key[n2];sp[ki + 1] = key[n1];}
                ki += 8;
            }
        }
        void Pleifer(int count, char[] p)
        {
            string path = Pouth.Text;
            using (var sw = new StreamWriter(@"C:\Stels\AdressKeyShifrator.txt"))
            {
                sw.Write(path); 
            }
            path += ".txt";
            string key1;
            FileInfo file1 = new FileInfo(path);
            if (!IsFileinUse(file1))
            {
                using (var rw = new StreamReader(path))
                {
                    key1 = rw.ReadToEnd();
                }
                key = key1.ToCharArray();
                if (key.Length == 166)
                {
                    int k1 = 0, k2 = 2, k3 = 4, k4 = 6;
                    char[] sp = new char[count];
                    int chet = count % 2;
                    if (chet == 1) { sp[count - 1] = p[count - 1]; }
                    Thread th1 = new Thread(() => { Pleifer_Potok(count - chet, p, sp, k1); });
                    Thread th2 = new Thread(() => { Pleifer_Potok(count - chet, p, sp, k2); });
                    Thread th3 = new Thread(() => { Pleifer_Potok(count - chet, p, sp, k3); });
                    Thread th4 = new Thread(() => { Pleifer_Potok(count - chet, p, sp, k4); });
                    th1.Start(); th2.Start(); th3.Start(); th4.Start();
                    th1.Join(); th2.Join(); th3.Join(); th4.Join();
                    string s = new string(sp);
                    textbox2.Text = s;
                }
                else
                    MessageBox.Show("Ключ не соответствует стандарту. Произведите повторную генерацию.");
                
            }
            else
                MessageBox.Show("Адрес файла с ключом введен неверно (формат файла без типа)");
        }
        private void Kodirovka_Click(object sender, EventArgs e)
        {
            if (textbox1.Text != "" && Pouth.Text != "")
            {
                Stopwatch dt = new Stopwatch();
                dt.Start();
                textbox2.Text = ""; words.Text = ""; symbol.Text = ""; tim.Text = "";
                string text = Convert.ToString(textbox1.Text);
                char[] textchar = text.ToCharArray();
                int count = textchar.Length;
                int w = 0, b = 0;
                for (int i = 0; i < count; i++) 
                { 
                    if (textchar[i] == ' ') { 
                        w++; 
                    }
                    if (textchar[i] == '—')
                        w--;
                    b++; 
                }
                w++; words.Text = Convert.ToString(w); symbol.Text = Convert.ToString(b);
                Pleifer(count, textchar);
                dt.Stop();
                double a = Convert.ToDouble(dt.ElapsedMilliseconds); a /= 1000;
                tim.Text = Convert.ToString(a) + " s";
            }
            else
            {
                if (textbox1.Text == "") { textbox1.Text = "Введите текст!"; textbox1.BackColor = Color.Pink;}
                if (Pouth.Text == "") { Pouth.Text = "Введите адрес ключа!"; Pouth.BackColor = Color.Pink; }

            }

        }
        private void button2_Click(object sender, EventArgs e){textbox1.Text = "";}
        private void button3_Click(object sender, EventArgs e){textbox2.Text = "";}
        private void Kodirovka_MouseEnter(object sender, EventArgs e){Kodirovka.BackColor = Color.Aqua;}
        private void Kodirovka_MouseLeave(object sender, EventArgs e){Kodirovka.BackColor = Color.MintCream; }
        private void button3_MouseEnter(object sender, EventArgs e){button3.BackColor = Color.Aqua;}
        private void button3_MouseLeave(object sender, EventArgs e){button3.BackColor = Color.MintCream; }
        private void button2_MouseEnter(object sender, EventArgs e){button2.BackColor = Color.Aqua; }
        private void button2_MouseLeave(object sender, EventArgs e){button2.BackColor = Color.MintCream; }
        private void Pouth_Click(object sender, EventArgs e)
        {
            if (Pouth.BackColor == Color.Pink) { Pouth.BackColor = Color.Azure; Pouth.Text = ""; }
        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            if (textbox1.BackColor == Color.Pink) { textbox1.BackColor = Color.Azure; textbox1.Text = ""; }
            if (textbox1.Text == "Box1") { textbox1.Text = ""; };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Перед 1 использованием \"Шифратора\" и \"Парольника\" " +
                "откройте приложение \"Генератор\" и сгенерируйте 2 ключа шифрования: " +
                "1 для паролей, другой — для текста. Генерация ключей происходит следующим образом: \n " +
                "1) Создайте текстовый файл формата .txt для каждого ключа. \n " +
                "2) Выберите один из вариантов генерации: \"Для паролей\" или \"Для текста\". \n" +
                "3) В строку \"Адрес загрузки ключа\" введите путь к файлу без обозначения его типа (без .txt). \n" +
                "4) Нажмите на кнопку \"Генерировать\". \n" +
                "5) Повторите действия с 2 по 4 с другим вариантом генерации. \n " +
                "  После этого оба приложения \"Шифратор\" и \"Парольник\" будут использовать эти ключи для " +
                "шифрования своих данных. \n \n" +
                "\"Шифратор\" — приложение для защиты данных от посторонних лиц, работающее на основе " +
                "алгоритма Плейфера для шифрования текстов. Алгоритм имеет ключ в виде таблицы на 166 символов " +
                "83:2. Алгоритм использования выглядит следующим образом: в графе \"Путь до ключа\" " +
                "вводится путь к файлу .txt для считывания ключа, после в Box1 вводится текст. " +
                "При нажатии кнопки \"Шифровать/Расшифровать\" в Box2 выводится " +
                "отшифрованный текст из Box1. Кнопки \"Очистить\" стирают информацию соответствующих над " +
                "ними Box1 и Box2.", "Руководство по использованию!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s1 = Convert.ToString(textbox1.Text);
            string s2 = Convert.ToString(textbox2.Text);
            textbox1.Text = "";
            textbox2.Text = "";
            textbox1.Text = s2;
            textbox2.Text = s1;
        }
    }
}
