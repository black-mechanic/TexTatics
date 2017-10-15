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

namespace TeXtatics
{
    public partial class Form1 : Form
    {
        const int MAX_LENGTH_OF_WORD = 21;
        string s_path_Source;
        string s_short_path_source;
        int[] ar_word_counter = new int[MAX_LENGTH_OF_WORD];

        char[] charSeparators = new char[] { ',','.', ' ', '-', '?', '\n', '\r', '\b', '\t', '\0', ']', '[', '*', ')', '(', '}', '{', '\"', '~', '@', '$', '%', '^', '&', '+', ':', ';', '\\', '/', '<', '>', '!', '№', '_', '…'};
        // '\'', 
        string[] result;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    s_short_path_source = openFileDialog1.SafeFileName;
                    s_path_Source = openFileDialog1.FileName;
                    btn_SaveResults.Visible = true;
//  Весь файл прочитать в объект byte[] ar_sourceText                     
                    using (FileStream fs_source_file = new FileStream(s_path_Source, FileMode.Open, FileAccess.Read))
                    {
                        int i_file_Length = (int)fs_source_file.Length;
                        byte[] ar_sourceText = new byte[i_file_Length + 1];
                        int i_read_result_File_Length = 0;
                        while (i_file_Length > 0)
                        {
                            int n = fs_source_file.Read(ar_sourceText, i_read_result_File_Length, i_file_Length);
                            if (n == 0)
                                break;
                            i_read_result_File_Length += n;
                            i_file_Length -= n;
                        }
//
                        i_read_result_File_Length = ar_sourceText.Length;
//  Данные преобразованы из byte в string предполагая что данные Unicode
                        string resultString = Encoding.UTF8.GetString(ar_sourceText);

//  Данные из единой строки разбиты на массив строк состоящих из одного слова каждая. Все символы кроме апострофа удалены
                        result = resultString.Split(charSeparators, StringSplitOptions.None);

                        int i_example_cnt = 8;
                        lv_example.Clear();
//  Удалить апостроф ' из слов. Он не учавствует в подсчете букв в слове
                        for (int index = 0; index < result.Length; index++)
                        {
                            if(result[index].Contains("\'") == true)
                            {
                                int sym_pos = result[index].IndexOf('\'');
                                result[index] = result[index].Remove(sym_pos, 1);
                            }
//  Удалить апостроф ’ из слов. Он не учавствует в подсчете букв в слове
                            if (result[index].Contains("’") == true)
                            {
                                int sym_pos = result[index].IndexOf('’');
                                result[index] = result[index].Remove(sym_pos, 1);
                            }
//  Добавить на форму несколько слов для контроля. Количество определяется переменной i_example_cnt
                            if (i_example_cnt > 0)
                            {
                                if(result[index].Length > 4)
                                {
                                    ListViewItem lvi_words = new ListViewItem(result[index]);
                                    lv_example.Items.Add(lvi_words);
                                    i_example_cnt--;
                                }
                            }
                        }
                        

                        //  Очистить массив заранее под конечные результаты
                        for (int index = 1; index < MAX_LENGTH_OF_WORD; index++)
                        {
                            ar_word_counter[index] = 0;
                        }
// Подсчет статистики
                        foreach (string s_res in result)
                        {
                            ar_word_counter[s_res.Length]++;
                        }

                        int totalword = 0;

//  Сколько всего слов в тексте
                        for(int index = 1; index < MAX_LENGTH_OF_WORD; index ++)
                        {
                            totalword += ar_word_counter[index];
                        }
//  Вывести результаты на UI форму
                        label000.Text = totalword.ToString();
                        label01.Text = ar_word_counter[1].ToString();
                        label02.Text = ar_word_counter[2].ToString();
                        label03.Text = ar_word_counter[3].ToString();
                        label04.Text = ar_word_counter[4].ToString();
                        label05.Text = ar_word_counter[5].ToString();
                        label06.Text = ar_word_counter[6].ToString();
                        label07.Text = ar_word_counter[7].ToString();
                        label08.Text = ar_word_counter[8].ToString();
                        label09.Text = ar_word_counter[9].ToString();
                        label010.Text = ar_word_counter[10].ToString();
                        label011.Text = ar_word_counter[11].ToString();
                        label012.Text = ar_word_counter[12].ToString();
                        label013.Text = ar_word_counter[13].ToString();
                        label014.Text = ar_word_counter[14].ToString();
                        label015.Text = ar_word_counter[15].ToString();
                        label016.Text = ar_word_counter[16].ToString();
                        label017.Text = ar_word_counter[17].ToString();
                        label018.Text = ar_word_counter[18].ToString();
                        label019.Text = ar_word_counter[19].ToString();
                        label020.Text = ar_word_counter[20].ToString();

                        label_status.Text = " Файл " + s_short_path_source + " обработан.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void btn_ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         private void btn_SaveResults_Click(object sender, EventArgs e)
        {
            string s_path_Result = s_path_Source + ".csv";

            using (StreamWriter sw = new StreamWriter(s_path_Result, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(s_path_Source + "\n");
                for (int index = 1; index < MAX_LENGTH_OF_WORD; index++)
                {
                    sw.WriteLine(index.ToString() + "," + ar_word_counter[index].ToString());
                    //sw.WriteLine(ar_word_counter[index].ToString() + "\n");
                }

                label_status.Text = " Файл " + s_path_Result + " сохранён.";
            }

        }
    }
}
