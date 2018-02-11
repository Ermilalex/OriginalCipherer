using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Hope_I_can_do_this
{
    public partial class Form1 : Form
    {
        static string TextChange(string someText, int randomIntOrig, int randomIntNew)
        {
            int charCodeOrig = randomIntOrig + 1072;
            int charCodeNew = randomIntNew + 1072;
            string workingString = someText.Replace('Ё', 'Е');
            workingString = someText.Replace('ё', 'е');
            Debug.WriteLine(workingString);
            string changedText = workingString.Replace(Convert.ToChar(charCodeOrig), Convert.ToChar(charCodeNew));
            charCodeOrig = randomIntOrig + 1040;
            charCodeNew = randomIntNew + 1040;
            changedText = changedText.Replace(Convert.ToChar(charCodeOrig), Convert.ToChar(charCodeNew));
            return changedText;
        }

        bool firstTime = true;
        int[] usedInts;
        int[] usedSwaps;
        int origNumber = 0, newNumber = 0;
        char ch1 = 'А', ch2 = 'а', ch3 = ' ';
        int counter = 0, unique = 0, help = 0, yetAnotherCounter = 0, tooManyCounters = 0;
        List<char> symbolsOrig = new List<char>();
        char [] symbolsNew;
        string textBuffer = "";
        string[] letters = new string[] { "о", "а", "е", "и", "н", "т", "р", "с", "л", "в", "к", "п", "м", "у", "д", "я", "ы", "ь", "з", "б", "г", "й", "ч", "ю", "х", "ж", "ш", "ц", "щ", "ф", "э", "ъ" };

        private void varTwo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void swapThisBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void filePickButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                originalText.Text = sr.ReadToEnd();
                filePath.Text = openFileDialog1.FileName;
                sr.Close();
            }
        }

        private void varOne_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filePath.Text.Length != 0)
            {
                StreamReader sr = new StreamReader(filePath.Text);
                originalText.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                MessageBox.Show("Неверный путь", "Ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void switchTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void swapThisBox_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= swapThisBox_GotFocus;
        }

        private void lastSymbols_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rarityQueue_CheckedChanged(object sender, EventArgs e)
        {
            if(rarityQueue.Checked == true)
            {
                swapThisBox.Text = "";
                swapThisBox.Enabled = false;
                forThatBox.Text = "";
                forThatBox.Enabled = false;
            }
            else
            {
                swapThisBox.Enabled = true;
                forThatBox.Enabled = true;
            }
        }

        public void forThatBox_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= forThatBox_GotFocus;
        }

        private void calculate(string str="")
        {
            if (str != "") { swapThisBox.Text = str; }
            bool check = true;
            char r = ' ', changeFor = ' ', buffer = ' ';
            System.Text.StringBuilder newText;
            if (firstTime == true) { newText = new System.Text.StringBuilder(originalText.Text); }
            else { newText = new System.Text.StringBuilder(alteredText.Text); }
            if (firstTime == true)
            {
                textBuffer = originalText.Text;
                for (int i = 0; i < originalText.Text.Length; i++)
                {
                    char ch = originalText.Text[i];
                    if (!symbolsOrig.Contains(ch))
                    {
                        symbolsOrig.Add(ch);
                    }
                }
                symbolsNew = new char[symbolsOrig.Count()];
                usedInts = new int[symbolsOrig.Count()];
                usedSwaps = new int[symbolsOrig.Count()];
                eventLog.Text += "Количество оригинальных символов: " + symbolsOrig.Count() + "\r\n";
                label1.Text += "Общее количество символов: " + originalText.Text.Length;
                /*int s = 0;
                for (int j = 0; j < symbolsOrig.Count(); j++)
                {
                    while (s == j || symbolsNew.Contains(symbolsOrig[s]))
                    {
                        s = q.Next(symbolsOrig.Count());
                    }
                    symbolsNew.Add(symbolsOrig[s]);
                }*/
                firstTime = false;
            }
            else { textBox1.Text = alteredText.Text; };

            switchTable.ColumnCount = symbolsOrig.Count;
            switchTable.RowCount = 3;

            if (swapThisBox.Text.Length == 1)
            {
                if (textBuffer.Contains(Convert.ToChar(swapThisBox.Text)))
                {
                    r = Convert.ToChar(swapThisBox.Text);
                    if (usedInts[symbolsOrig.IndexOf(r)] == 1)
                    {
                        check = false;
                        MessageBox.Show("Данный символ уже был заменён", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    check = false;
                    MessageBox.Show("В исходном тексте нет указанного символа", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (swapThisBox.Text.Length == 0)
            {
                int s = q.Next(symbolsOrig.Count());
                while (usedInts[s] == 1)
                {
                    s = q.Next(symbolsOrig.Count());
                }
                r = symbolsOrig[s];
                //usedInts[s] = 1;
                /*for (int f = 0; f < symbolsOrig.Count; f++)
                {
                    if (usedInts[f] != 1)
                    {
                        r = symbolsOrig[f];
                        break;
                    }
                }*/
                swapThisBox.Text = Convert.ToString(r);
            }

            if (forThatBox.Text.Length == 1)
            {
                changeFor = Convert.ToChar(forThatBox.Text);
                if (symbolsOrig.Contains(changeFor) && !symbolsNew.Contains(changeFor) && check == true)
                {
                    buffer = changeFor;
                }
                else if (symbolsNew.Contains(changeFor))
                {
                    check = false;
                    MessageBox.Show("Данный символ уже использовался для замены", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    check = false;
                    MessageBox.Show("В исходном тексте нет указанного символа", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (swapThisBox.Text.Length > 1 || forThatBox.Text.Length > 1)
            {
                check = false;
                MessageBox.Show("Пожалуйста, введите один символ", "Ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (check == true)
            {
                int w = symbolsOrig.IndexOf(r);
                if (usedInts[w] != 1)
                {
                    if (buffer == ' ')
                    {
                        int s = q.Next(symbolsOrig.Count());
                        while (symbolsNew.Contains(symbolsOrig[s]))
                        {
                            s = q.Next(symbolsOrig.Count());
                        }
                        symbolsNew[w] = symbolsOrig[s];
                        usedSwaps[s] = 1;
                    }
                    else symbolsNew[w] = buffer;
                    for (int i = 0; i < textBuffer.Length; i++)
                    {
                        if (textBuffer[i] == r)
                        {
                            if (lastSymbols.Checked == true && textBuffer[i + 1] == ' ') { }
                            else if (firstSymbols.Checked == true && textBuffer[i - 1] == ' ') { }
                            else
                            {
                                newText[i] = symbolsNew[w];
                                tooManyCounters++;
                            }
                        }
                    }
                    counter++;
                    usedInts[w] = 1;
                    switchTable[counter - 1, 0].Value = counter;
                    switchTable[counter - 1, 1].Value = symbolsOrig[w];
                    switchTable[counter - 1, 2].Value = symbolsNew[w];

                }
                else eventLog.Text += "Указанная замена уже была произведена!\r\n";

                float f = tooManyCounters / (float)textBuffer.Length * 100;
                alteredText.Text = newText.ToString();
                eventLog.AppendText (counter + ") Произведена замена " + r + " -> " + symbolsNew[w] + "\r\n");
                lastOp.Text = "Произведена замена " + r + " -> " + symbolsNew[w];
                changedCounter.Text = "Количество оригинальных символов: " + symbolsOrig.Count() + "; произведено " + counter + " замен; заменено " + tooManyCounters + " символов (" + String.Format("{0:0.0}", f) + "% оригинального текста)";
                swapThisBox.Text = string.Empty;
                forThatBox.Text = string.Empty;
                if (counter >= symbolsOrig.Count())
                {
                    MessageBox.Show("Произведено максимально возможное количество замен", "Удачное завершение работы",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    runButton.Enabled = false;
                }
            }
            else { }
        }

        /*private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }*/

        Random q = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            varOne.Enabled = false;
            varTwo.Enabled = false;
            originalText.ReadOnly = true;
            filesGroup.Enabled = false;

            if (varOne.Checked)
            {
                if (firstTime == true)
                {
                    firstTime = false;
                }
                else originalText.Text = alteredText.Text;
                while (usedInts[origNumber] == 1 || (originalText.Text.IndexOf(ch1) < 0 && originalText.Text.IndexOf(ch2) < 0))
                {
                    help++;
                    origNumber = q.Next(32);
                    ch1 = Convert.ToChar(origNumber + 1040);
                    ch2 = Convert.ToChar(origNumber + 1072);
                    if (help > 50) break;
                }
                usedInts[origNumber] = 1;
                unique++;
                while ((usedSwaps[newNumber] == 1 || newNumber == origNumber) && help <= 50)
                {
                    newNumber = q.Next(32);
                    ch3 = Convert.ToChar(newNumber + 1040);
                }
                if (help>50)
                {
                    MessageBox.Show("Каждая из встречающихся букв уже была заменена хотя бы единожды!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    runButton.Enabled = false;
                    //Application.Exit();
                }
                usedSwaps[newNumber] = 1;

                alteredText.Text = TextChange(originalText.Text, origNumber, newNumber);
                eventLog.Text += "Произведена замена " + ch1 + "->" + ch3 + '\n';
            }

            if (varTwo.Checked)
            {
                if (rarityQueue.Checked == true && yetAnotherCounter < 32)
                {
                    for (int i = yetAnotherCounter; i < yetAnotherCounter + Convert.ToInt16(placeholder.Text); i++)
                    {
                        if (i == 32)
                        {
                            MessageBox.Show("Все буквы русского языка уже были заменены!", "Ошибка!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        else { calculate(letters[i]); }
                    }
                    yetAnotherCounter += Convert.ToInt16(placeholder.Text);
                }
                else
                {
                    for (int i = 0; i < Convert.ToInt16(placeholder.Text); i++)
                    {
                        calculate();
                    }
                }
            }
            placeholder.Text = "1";
        }
    }
}
