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
using System.Threading;
namespace GeneratorParol
{
    public partial class Form1 : Form
    {
        char[] newkey = new char[76];
        char[] RusSymbol = new char[76]
        { 'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О',
          'П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','ъ','Ы','Ь','Э','Ю',
          'Я','а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н',
          'о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э',
          'ю','я','1','2','5','6','7','8','9','0','3','4' };
        char[] Errorsymbol = new char[92]
        { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N',
          'O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d',
          'e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t',
          'u','v','w','x','y','z',',','.',':',';','!','?',' ','*','/','@',
          '|','~','#','[',']','{','}','<','>','^','(',')','-','+','=','\'',
          '"','\\','1','2','\n','\r','%','&','`','_','«','»','—','$'};
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(@"C:\Stels"))
            {
                Directory.CreateDirectory(@"C:\Stels");
            }
            string path = @"C:\Stels\AdressKeyParol.txt";
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
                for (int i = 0; i < 76; i++)
                {
                    if (p[ki] == RusSymbol[i])
                    {
                        n1 = i;
                    }
                    if (p[ki + 1] == RusSymbol[i])
                    {
                        n2 = i;
                    }
                }
                ost1 = n1 % 4;
                ost2 = n2 % 4;
                if (ost1 < ost2) { sp[ki] = newkey[n1 + (ost2 - ost1)]; sp[ki + 1] = newkey[n2 - (ost2 - ost1)]; }
                if (ost1 > ost2) { sp[ki] = newkey[n1 - (ost1 - ost2)]; sp[ki + 1] = newkey[n2 + (ost1 - ost2)]; }
                if (ost1 == ost2) { sp[ki] = newkey[n2]; sp[ki + 1] = newkey[n1]; }
                ki += 8;
            }
        }
        void Pleifer(int count, char[] p)
        {
            string path = Pouth.Text;
            using (var sw = new StreamWriter(@"C:\Stels\AdressKeyParol.txt"))
            {
                sw.Write(path);
            }
            path += ".txt";
            string key1;
            FileInfo file = new FileInfo(path);
            if (!IsFileinUse(file))
            {

                using (var rw = new StreamReader(path))
                {
                    key1 = rw.ReadToEnd();
                }
                succes.Text = "";
                newkey = key1.ToCharArray();
                if (newkey.Length == 76)
                {
                    int k1 = 0, k2 = 2, k3 = 4, k4 = 6;
                    char[] sp = new char[count];
                    int chet = count % 2;
                    if (chet == 1) { sp[count - 1] = newkey[0]; }
                    Thread th1 = new Thread(() => { Pleifer_Potok(count - chet, p, sp, k1); });
                    Thread th2 = new Thread(() => { Pleifer_Potok(count - chet, p, sp, k2); });
                    Thread th3 = new Thread(() => { Pleifer_Potok(count - chet, p, sp, k3); });
                    Thread th4 = new Thread(() => { Pleifer_Potok(count - chet, p, sp, k4); });
                    th1.Start(); th2.Start(); th3.Start(); th4.Start();
                    th1.Join(); th2.Join(); th3.Join(); th4.Join();
                    string s = new string(sp);
                    newparol.Text = s;
                    succes.Text = "Успешно!";
                }
                else
                    MessageBox.Show("Ключ не соответствует стандарту. Произведите повторную генерацию.");
            }
            else
                MessageBox.Show("Неправильно введен путь. Введите адрес файла с ключом без типа (fail.txt => fail).");
        }
        bool proverka(string s)
        {
            bool ind = true;
            int l = s.Length;
            char[] kill = s.ToCharArray();
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < 92; j++)
                {
                    if (kill[i] == Errorsymbol[j])
                        ind = false;
                }
            }
            return ind;
        }
        private void Shifr_Click(object sender, EventArgs e)
        {
            if (Pouth.Text != "" && oldparol.Text != "" && proverka(oldparol.Text))
            {
                newparol.Text = "";
                string text = Convert.ToString(oldparol.Text);
                char[] textchar = text.ToCharArray();
                int count = textchar.Length;
                Pleifer(count, textchar);
            }
            else
            {
                if (Pouth.Text == "")
                {
                    Pouth.BackColor = Color.Pink;
                    Pouth.Text = "Введите адрес файла с ключом без типа (fail.txt => fail).";
                }
                if (oldparol.Text == "")
                {
                    oldparol.BackColor = Color.Pink;
                    oldparol.Text = "Введите пароль!";
                }
                if (!proverka(oldparol.Text))
                {
                    oldparol.BackColor = Color.Pink;
                    MessageBox.Show("Введите пароль, используя буквы русского алфавита и цифры от 0 до 9");
                }
            }
        }
        private void Pouth_Click(object sender, EventArgs e)
        {
            if (Pouth.BackColor == Color.Pink)
            {
                Pouth.Text = "";
                Pouth.BackColor = Color.Azure;
            }
        }

        private void oldparol_Click(object sender, EventArgs e)
        {
            if (oldparol.BackColor == Color.Pink)
            {
                oldparol.Text = "";
                oldparol.BackColor = Color.Azure;
            }
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
                "  \"Парольник\" — приложение для шифрования паролей, работающее на основе " +
                "алгоритма Плейфера для шифрования текстов. Алгоритм имеет ключ в виде таблицы на 76 символов " +
                "19:4, включающий латинские символы в большом и малом регистре, а также цифры от 0 до 9. " +
                "Алгоритм использования выглядит следующим образом: \n" +
                "1) В графе \"Путь до ключа\" вводится путь к файлу .txt для считывания ключа. \n" +
                "2) В графе напротив надписи \"Новый/Старый пароль\" вводится текст из русских букв и цифр. \n" +
                "3) Далее при нажатии кнопки \"Зашифровать\" в 3 графу выводится зашифрованный текст из 2 графы. ",
                "Руководство по использованию!");
        }
    }
}
