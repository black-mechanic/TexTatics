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
                
        int[] ar_word_counter = new int[MAX_LENGTH_OF_WORD];

        char[] charSeparators = new char[] { ',','.', ' ', '-', '?', '\n', '\r', '\b', '\t', ']', '[', '*', ')', '(', '}', '{', '\"', '\'', '~', '@', '$', '%', '^', '&', '+', ':', ';', '\\', '/', '<', '>', '!' };
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
                    string s_path_Source = openFileDialog1.FileName;
                    btn_SaveResults.Visible = true;
                    //                    if ((source_file =  File.Open(path_Source, FileMode.Open)) != null)
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
                        i_read_result_File_Length = ar_sourceText.Length;

                        string resultString = Encoding.UTF8.GetString(ar_sourceText);

                        result = resultString.Split(charSeparators, StringSplitOptions.None);

                        foreach (string s_res in result)
                        {
                            ar_word_counter[s_res.Length]++;
                        }

                        int totalword = 0;

                        for(int index = 1; index < MAX_LENGTH_OF_WORD; index ++)
                        {
                            totalword += ar_word_counter[index];
                        }

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

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
