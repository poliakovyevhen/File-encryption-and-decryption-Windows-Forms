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
using System.Collections;
using System.Media; //для SystemSounds потрібно


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        byte[] fileArray = new byte[0];//тут зберігаю байти файлу, який шифрую
        byte[] randomArray = new byte[0];//тут зберігаю байти ключа для шифрування
        byte[] resultArray = new byte[0];//тут зберігаю результати шифрування (Файл XOR Ключ)

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_keyLength_byte.SelectedItem = "8";
            checkBox_viewPassWord.Checked = false;
        }

        

        private void comboBox_keyLength_byte_TextChanged(object sender, EventArgs e)
        {
            string str = comboBox_keyLength_byte.Text;
            if (str != "")
            {
                label_bits.Text = Convert.ToString(Convert.ToInt32(str) * 8);
            }
        }

        private void comboBox_keyLength_byte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox_hand_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hand.Checked) textBox_Key.ReadOnly = false;
            else
            {
                textBox_Key.ReadOnly = true;

                string pathFileKey = textBox_fileKey.Text;

                if (pathFileKey == "")
                {
                    MessageBox.Show("Вкажіть шлях до файлу з ключем", "Помилка в textBox_fileKey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox_hand.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    textBox_fileKey.Focus();
                    return;
                }
                if (!File.Exists(pathFileKey))
                {
                    MessageBox.Show("Файл з ключем не існує, створіть файл", "Помилка файлу з ключем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox_hand.Checked = true;
                    tabControl1.SelectedIndex = 0;
                    button_fileKey_out.Focus();
                    return;
                }

                this.randomArray = stringToByteArray(textBox_Key.Text);

                File.WriteAllBytes(pathFileKey, this.randomArray);
            }

        }

        private void textBox_Key_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f') || (c >= 'a' && c <= 'f') || c == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        public byte[] stringToByteArray(string textHEX) // stringHEX -> byte[]
        {
            //textHEX = textHEX.Replace(" - ", "");

            // https://pcheruku.wordpress.com/2008/10/21/sample-c-code-to-convert-hexadecimal-string-to-bytes/
            int len = textHEX.Length;
            if (len % 2 == 1)
            {
                textHEX = "0" + textHEX;
                textBox_Key.Text = textHEX; //це зовсім не Фен-Шуй!!! Але, зараз мені ліньки писати нормальний код.
                len++;
            }
            int len_half = len / 2;
            byte[] bs = new byte[len_half];
            //convert the hexstring to bytes
            for (int i = 0; i != len_half; i++)
            {
                bs[i] = (byte)Int32.Parse(textHEX.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return bs;
        }

        private void button_fileOpen_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.FileName = "Key";
            openFileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathFileLoad = openFileDialog.FileName;

                this.fileArray = File.ReadAllBytes(pathFileLoad);

                label_openFile.Text = "файл";
                label_openFile.ForeColor = Color.Green;
                label_fileCipher.Text = "(нема)";
                label_fileCipher.ForeColor = Color.Red;
                label_fileSave.Text = "(нема)";
                label_fileSave.ForeColor = Color.Red;
                SystemSounds.Beep.Play();
            }
            this.Cursor = Cursors.Default;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string pathFileKey = textBox_fileKey.Text;
            DateTime timeStart;
            DateTime timeFinish;
            TimeSpan timeAll;
            label_time.Text = "00:00.00";
            
            if (pathFileKey == "")
            {
                MessageBox.Show("Вкажіть шлях до файлу з ключем", "Помилка в textBox_fileKey", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_fileKey.Focus();
                return;
            }

            if (!File.Exists(pathFileKey))
            {
                MessageBox.Show("Файл з ключем не існує, створіть файл", "Помилка файлу з ключем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_fileKey_out.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            timeStart = DateTime.Now;

            //byte[] randomArray = null;
            if (radioButton_keyGen.Checked)
            {
                this.randomArray = KeyGen.generator_Key(int.Parse(comboBox_keyLength_byte.Text));
            }
            if (radioButton_passWord.Checked)
            {
                PassWordGen pass = new PassWordGen(textBox_password.Text, comboBox_keyLength_byte.Text);
                this.randomArray = pass.Result;
            }

            File.WriteAllBytes(pathFileKey, this.randomArray);

            textBox_Key.Text = stringHEX(this.randomArray);

            timeFinish = DateTime.Now;
            timeAll = timeFinish - timeStart;
            label_time.Text = timeAll.ToString(@"hh\:mm\:ss");

            this.Cursor = Cursors.Default;
            //SystemSounds.Beep.Play();
            //SystemSounds.Asterisk.Play();
            //SystemSounds.Exclamation.Play();
            SystemSounds.Hand.Play();
            //SystemSounds.Question.Play();
        }

        #region для виконання цього коду: string digits = ToDigitString(randomBitArray); // bits -> string (в BIN форматы)
        private string ToDigitString(BitArray array)
        {
            var builder = new StringBuilder();
            foreach (var bit in array.Cast<bool>())
                builder.Append(bit ? "1" : "0");
            return builder.ToString();
        }
        #endregion

        private void button_fileCipher_Click(object sender, EventArgs e)
        {
            int lenFile = this.fileArray.Length;
            if (lenFile == 0)
            {
                MessageBox.Show("Щось не те з файлом", "Застереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int lenKey = this.randomArray.Length;
            if (lenKey == 0)
            {
                MessageBox.Show("Щось не те з ключем", "Застереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            this.resultArray = new byte[lenFile];
            for (int i = 0; i < lenFile; i++)
            {
                this.resultArray[i] = (byte)(this.fileArray[i] ^ this.randomArray[i % lenKey]); //або можна використовувати BitArray.Xor
            }
            label_fileCipher.Text = "файл";
            label_fileCipher.ForeColor = Color.Green;
            label_fileSave.Text = "(нема)";
            label_fileSave.ForeColor = Color.Red;
            SystemSounds.Beep.Play();
            this.Cursor = Cursors.Default;
        }

        private void button_fileSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //if (saveFileDialog.ShowDialog() == true)
            //    File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);

            saveFileDialog.FileName = "Файл після шифрування";
            saveFileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathKeySave = saveFileDialog.FileName;

                File.WriteAllBytes(pathKeySave, this.resultArray);
                if (this.resultArray.Length == 0)
                {
                    MessageBox.Show("Щось не те з шифруванням" + Environment.NewLine
                                    + "файл створено, але його розмір" + "\r\n"
                                    + "0 байт", //можна по різному переносити строку
                                    "Застереження",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }

                label_fileSave.Text = "файл";
                label_fileSave.ForeColor = Color.Green;
                SystemSounds.Beep.Play();
            }
            this.Cursor = Cursors.Default;
        }

        private void radioButton_keyGen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_keyGen.Checked)
            {
                button_OK.ImageIndex = 0;
                button_fileCipher.ImageIndex = 0;
                textBox_password.ForeColor = SystemColors.WindowText;
            }
        }

        private void radioButton_passWord_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_passWord.Checked)
            {
                button_OK.ImageIndex = 1;
                button_fileCipher.ImageIndex = 1;
                //tabControl1.SelectedIndex = 2;
                textBox_password.ForeColor = Color.DarkGreen;
            }
        }

        private void linkLabel_author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Polikov Y.V.",
                            "Реквізити автора:",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

        }

        private void checkBox_viewPassWord_CheckedChanged(object sender, EventArgs e)
        {
            //char c = textBox_password.PasswordChar;
            if (checkBox_viewPassWord.Checked) textBox_password.PasswordChar = '\0';
            else textBox_password.PasswordChar = '*';
        }

        private string stringHEX(byte[] randomArray)
        {
            BitArray randomBitArray = new BitArray(randomArray); // byte[] -> bits
            // Перевірка  randomBitArray.CopyTo(randomArray, 0); // bits -> byte[]
            //    string digits = ToDigitString(randomBitArray); // bits -> string (в BIN форматы)
            string textHEX = BitConverter.ToString(randomArray); // byte[] -> string (в HEX форматі)
            return textHEX.Replace("-", "");
        }

        private void button_fileKey_out_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "MyKey";
            saveFileDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_fileKey.Text = saveFileDialog.FileName; // шлях до файлу, де буде зберігатись ключ

                try
                {
                    // читаєм те що у файлі вже є і виводимо в поле ключа
                    string pathFileSave = textBox_fileKey.Text;
                    this.randomArray = File.ReadAllBytes(pathFileSave);
                    textBox_Key.Text = stringHEX(this.randomArray);
                    comboBox_keyLength_byte.Text = this.randomArray.Length.ToString();
                }
                catch (Exception)
                {
                    //this.randomArray = null;
                    this.randomArray = new byte[0];
                    File.Create(textBox_fileKey.Text);
                }
            }
        }

    }
}

