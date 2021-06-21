using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace Cities
{
    public partial class Cities : Form
    {
        public Cities()
        {
            InitializeComponent();
        }

        static class GlobalVars
        {
            public static List<string> Cit_Arr = new();
            public static List<string> Cit_Arr_Use = new();
            public static List<string> Cit_Arr_Used = new();
            public static int count = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void start_stop_Click(object sender, EventArgs e)
        {

            service.ForeColor = Color.DarkRed;

            StreamReader Sr = new(@"D:\cities.txt", System.Text.Encoding.Default);

            while (!Sr.EndOfStream)
            {
                GlobalVars.Cit_Arr.Add(Sr.ReadLine());
            }
            GlobalVars.Cit_Arr_Used.Clear();
            Random rnd = new();
            int random_index = rnd.Next(0, GlobalVars.Cit_Arr.Count);

            answer_txt.Clear();
            service.Text = "Это — сервисное поле. Оно нужно для вывода ошибок и объявления победы";
            switch (GlobalVars.count)
            {
                case 0:
                    question_txt.Text = GlobalVars.Cit_Arr[random_index];
                    GlobalVars.count++;
                    start_stop.Text = "Сдаться";
                    break;

                case 1:
                    GlobalVars.count = 0;
                    start_stop.Text = "Начать";
                    question_txt.Clear();
                    service.Text = "Осталось " + ((GlobalVars.Cit_Arr.Count - GlobalVars.Cit_Arr_Used.Count) / (GlobalVars.Cit_Arr.Count / 100)) + "% городов";
                    break;
            }

        }

        private void answer_butt_Click(object sender, EventArgs e)
        {
            string answer, question, answerl, questionl, questionbuf;

            service.Text = "";

            answer = answer_txt.Text;
            question = question_txt.Text;
            answer = answer.Trim();
            questionbuf = question;
            questionbuf = questionbuf.Replace("ь", "");
            questionbuf = questionbuf.Replace("ы", "");
            answerl = answer.ToLower();
            questionl = question.ToLower();


            if (answer == "")
            {
                service.Text = "Введите ответ";
            }

            else
            {
                answer = answerl.Substring(0, 1).ToUpper() + answerl.Substring(1, answerl.Length - 1);

                if (Equals(answerl[0], questionbuf[questionl.Length - 1]) == false)
                {
                    service.Text = "Вы ввели город с неправильной буквы";
                    answer_txt.Clear();
                }

                else
                {
                    if (GlobalVars.Cit_Arr_Used.Contains(answer))
                    {
                        service.Text = "Этот город уже был";
                        answer_txt.Clear();
                    }

                    else
                    {
                        GlobalVars.Cit_Arr_Used.Add(answer);
                        if (!GlobalVars.Cit_Arr.Contains(answer))
                        {
                            service.Text = "Такого города в базе не нашлось";
                            answer_txt.Clear();
                        }

                        else
                        {
                            GlobalVars.Cit_Arr_Use.Clear();
                            answer = answer.Replace("ь", "");
                            answer = answer.Replace("ы", "");
                            answer = answer.Substring(0, answer.Length - 1) + answer.Substring(answer.Length - 1, 1).ToUpper();

                            question = GlobalVars.Cit_Arr.Find(x => { return x[0] == answer[answer.Length - 1] && !GlobalVars.Cit_Arr_Used.Contains(x); });

                            if (question == null)
                            {
                                service.ForeColor = Color.Magenta;
                                service.Text = "Вы победили";
                            }

                            else
                            {
                                question_txt.Text = question;
                            }
                            GlobalVars.Cit_Arr_Used.Add(question);
                            answer_txt.Clear();
                        }
                    }
                }
            }
        }

        private void question_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void history_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer_txt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
