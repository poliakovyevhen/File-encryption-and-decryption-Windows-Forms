namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fileKey = new System.Windows.Forms.TextBox();
            this.button_fileKey_out = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.checkBox_hand = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_viewPassWord = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_fileSave = new System.Windows.Forms.Label();
            this.button_fileSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label_fileCipher = new System.Windows.Forms.Label();
            this.button_fileCipher = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label_openFile = new System.Windows.Forms.Label();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_passWord = new System.Windows.Forms.RadioButton();
            this.radioButton_keyGen = new System.Windows.Forms.RadioButton();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.label_bits = new System.Windows.Forms.Label();
            this.comboBox_keyLength_byte = new System.Windows.Forms.ComboBox();
            this.linkLabel_author = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 102);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_fileKey);
            this.tabPage1.Controls.Add(this.button_fileKey_out);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 76);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Файл з ключем";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Шлях до файлу:";
            // 
            // textBox_fileKey
            // 
            this.textBox_fileKey.Location = new System.Drawing.Point(32, 38);
            this.textBox_fileKey.Name = "textBox_fileKey";
            this.textBox_fileKey.Size = new System.Drawing.Size(379, 20);
            this.textBox_fileKey.TabIndex = 1;
            // 
            // button_fileKey_out
            // 
            this.button_fileKey_out.Location = new System.Drawing.Point(434, 38);
            this.button_fileKey_out.Name = "button_fileKey_out";
            this.button_fileKey_out.Size = new System.Drawing.Size(75, 23);
            this.button_fileKey_out.TabIndex = 0;
            this.button_fileKey_out.Text = "...";
            this.button_fileKey_out.UseVisualStyleBackColor = true;
            this.button_fileKey_out.Click += new System.EventHandler(this.button_fileKey_out_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.textBox_Key);
            this.tabPage2.Controls.Add(this.checkBox_hand);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 76);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ключ у HEX форматі";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(32, 38);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(380, 20);
            this.textBox_Key.TabIndex = 2;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Key_KeyPress);
            // 
            // checkBox_hand
            // 
            this.checkBox_hand.AutoSize = true;
            this.checkBox_hand.Location = new System.Drawing.Point(448, 40);
            this.checkBox_hand.Name = "checkBox_hand";
            this.checkBox_hand.Size = new System.Drawing.Size(26, 17);
            this.checkBox_hand.TabIndex = 1;
            this.checkBox_hand.Text = "\r\n";
            this.checkBox_hand.UseVisualStyleBackColor = true;
            this.checkBox_hand.CheckedChanged += new System.EventHandler(this.checkBox_hand_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ключ(HEX формат):";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox_password);
            this.tabPage3.Controls.Add(this.checkBox_viewPassWord);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(535, 76);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Власний пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Придумайтен свій пароль \r\nі запишіть його сюди:\r\n";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(158, 26);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(255, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // checkBox_viewPassWord
            // 
            this.checkBox_viewPassWord.AutoSize = true;
            this.checkBox_viewPassWord.Location = new System.Drawing.Point(434, 29);
            this.checkBox_viewPassWord.Name = "checkBox_viewPassWord";
            this.checkBox_viewPassWord.Size = new System.Drawing.Size(15, 14);
            this.checkBox_viewPassWord.TabIndex = 0;
            this.checkBox_viewPassWord.UseVisualStyleBackColor = true;
            this.checkBox_viewPassWord.CheckedChanged += new System.EventHandler(this.checkBox_viewPassWord_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.label_fileSave);
            this.tabPage4.Controls.Add(this.button_fileSave);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label_fileCipher);
            this.tabPage4.Controls.Add(this.button_fileCipher);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label_openFile);
            this.tabPage4.Controls.Add(this.button_fileOpen);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(535, 76);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Файл XOR Ключ";
            // 
            // label_fileSave
            // 
            this.label_fileSave.AutoSize = true;
            this.label_fileSave.Location = new System.Drawing.Point(375, 36);
            this.label_fileSave.Name = "label_fileSave";
            this.label_fileSave.Size = new System.Drawing.Size(45, 13);
            this.label_fileSave.TabIndex = 8;
            this.label_fileSave.Text = "(немає)";
            // 
            // button_fileSave
            // 
            this.button_fileSave.Location = new System.Drawing.Point(444, 18);
            this.button_fileSave.Name = "button_fileSave";
            this.button_fileSave.Size = new System.Drawing.Size(75, 31);
            this.button_fileSave.TabIndex = 7;
            this.button_fileSave.UseVisualStyleBackColor = true;
            this.button_fileSave.Click += new System.EventHandler(this.button_fileSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 26);
            this.label12.TabIndex = 6;
            this.label12.Text = "3.\r\nЗберегти файл:";
            // 
            // label_fileCipher
            // 
            this.label_fileCipher.AutoSize = true;
            this.label_fileCipher.Location = new System.Drawing.Point(195, 37);
            this.label_fileCipher.Name = "label_fileCipher";
            this.label_fileCipher.Size = new System.Drawing.Size(45, 13);
            this.label_fileCipher.TabIndex = 5;
            this.label_fileCipher.Text = "(немає)";
            // 
            // button_fileCipher
            // 
            this.button_fileCipher.Location = new System.Drawing.Point(262, 19);
            this.button_fileCipher.Name = "button_fileCipher";
            this.button_fileCipher.Size = new System.Drawing.Size(75, 31);
            this.button_fileCipher.TabIndex = 4;
            this.button_fileCipher.UseVisualStyleBackColor = true;
            this.button_fileCipher.Click += new System.EventHandler(this.button_fileCipher_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "2.\r\nШифрування:";
            // 
            // label_openFile
            // 
            this.label_openFile.AutoSize = true;
            this.label_openFile.Location = new System.Drawing.Point(32, 37);
            this.label_openFile.Name = "label_openFile";
            this.label_openFile.Size = new System.Drawing.Size(45, 13);
            this.label_openFile.TabIndex = 2;
            this.label_openFile.Text = "(немає)";
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Location = new System.Drawing.Point(93, 20);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(75, 30);
            this.button_fileOpen.TabIndex = 1;
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.button_fileOpen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "1.\r\nВідкрити файл:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Тривалість розрахунків (мін.:сек.):)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Довжина ключа (біти):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Довжина ключа (байти):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ключ";
            // 
            // radioButton_passWord
            // 
            this.radioButton_passWord.AutoSize = true;
            this.radioButton_passWord.Location = new System.Drawing.Point(325, 188);
            this.radioButton_passWord.Name = "radioButton_passWord";
            this.radioButton_passWord.Size = new System.Drawing.Size(229, 17);
            this.radioButton_passWord.TabIndex = 18;
            this.radioButton_passWord.TabStop = true;
            this.radioButton_passWord.Text = "Ключ генерується розширенням пароля";
            this.radioButton_passWord.UseVisualStyleBackColor = true;
            this.radioButton_passWord.CheckedChanged += new System.EventHandler(this.radioButton_passWord_CheckedChanged);
            // 
            // radioButton_keyGen
            // 
            this.radioButton_keyGen.AutoSize = true;
            this.radioButton_keyGen.Location = new System.Drawing.Point(325, 152);
            this.radioButton_keyGen.Name = "radioButton_keyGen";
            this.radioButton_keyGen.Size = new System.Drawing.Size(217, 30);
            this.radioButton_keyGen.TabIndex = 17;
            this.radioButton_keyGen.TabStop = true;
            this.radioButton_keyGen.Text = "Ключ з криптографічного генератора \r\nпсевдопослідовних послідовностей";
            this.radioButton_keyGen.UseVisualStyleBackColor = true;
            this.radioButton_keyGen.CheckedChanged += new System.EventHandler(this.radioButton_keyGen_CheckedChanged);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(449, 284);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(99, 48);
            this.button_OK.TabIndex = 16;
            this.button_OK.Text = "Згенерувати ключ";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(258, 319);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(49, 13);
            this.label_time.TabIndex = 15;
            this.label_time.Text = "00:00.00";
            // 
            // label_bits
            // 
            this.label_bits.AutoSize = true;
            this.label_bits.Location = new System.Drawing.Point(183, 188);
            this.label_bits.Name = "label_bits";
            this.label_bits.Size = new System.Drawing.Size(38, 13);
            this.label_bits.TabIndex = 14;
            this.label_bits.Text = "text bit";
            // 
            // comboBox_keyLength_byte
            // 
            this.comboBox_keyLength_byte.FormattingEnabled = true;
            this.comboBox_keyLength_byte.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32",
            "12500000"});
            this.comboBox_keyLength_byte.Location = new System.Drawing.Point(186, 160);
            this.comboBox_keyLength_byte.Name = "comboBox_keyLength_byte";
            this.comboBox_keyLength_byte.Size = new System.Drawing.Size(121, 21);
            this.comboBox_keyLength_byte.TabIndex = 13;
            this.comboBox_keyLength_byte.TextChanged += new System.EventHandler(this.comboBox_keyLength_byte_TextChanged);
            this.comboBox_keyLength_byte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_keyLength_byte_KeyPress);
            // 
            // linkLabel_author
            // 
            this.linkLabel_author.AutoSize = true;
            this.linkLabel_author.Location = new System.Drawing.Point(451, 8);
            this.linkLabel_author.Name = "linkLabel_author";
            this.linkLabel_author.Size = new System.Drawing.Size(37, 13);
            this.linkLabel_author.TabIndex = 23;
            this.linkLabel_author.TabStop = true;
            this.linkLabel_author.Text = "Автор";
            this.linkLabel_author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_author_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 348);
            this.Controls.Add(this.linkLabel_author);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_passWord);
            this.Controls.Add(this.radioButton_keyGen);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_bits);
            this.Controls.Add(this.comboBox_keyLength_byte);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_fileKey;
        private System.Windows.Forms.Button button_fileKey_out;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_passWord;
        private System.Windows.Forms.RadioButton radioButton_keyGen;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_bits;
        private System.Windows.Forms.ComboBox comboBox_keyLength_byte;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.CheckBox checkBox_hand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_viewPassWord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_openFile;
        private System.Windows.Forms.Button button_fileOpen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_fileSave;
        private System.Windows.Forms.Button button_fileSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_fileCipher;
        private System.Windows.Forms.Button button_fileCipher;
        private System.Windows.Forms.LinkLabel linkLabel_author;
    }
}

