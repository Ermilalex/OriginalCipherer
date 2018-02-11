namespace Hope_I_can_do_this
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.originalText = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.alteredText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.eventLog = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.varOne = new System.Windows.Forms.RadioButton();
            this.varTwo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filePath = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.switchTable = new System.Windows.Forms.DataGridView();
            this.lastSymbols = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastOp = new System.Windows.Forms.TextBox();
            this.firstSymbols = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.forThatBox = new System.Windows.Forms.TextBox();
            this.swapThisBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filePickButton = new System.Windows.Forms.Button();
            this.filesGroup = new System.Windows.Forms.GroupBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.changedCounter = new System.Windows.Forms.Label();
            this.rarityQueue = new System.Windows.Forms.CheckBox();
            this.placeholder = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchTable)).BeginInit();
            this.filesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оригинальный текст";
            // 
            // originalText
            // 
            this.originalText.Location = new System.Drawing.Point(12, 29);
            this.originalText.Multiline = true;
            this.originalText.Name = "originalText";
            this.originalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.originalText.Size = new System.Drawing.Size(691, 160);
            this.originalText.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runButton.Location = new System.Drawing.Point(608, 528);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(95, 50);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Выполнить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // alteredText
            // 
            this.alteredText.Location = new System.Drawing.Point(12, 328);
            this.alteredText.Multiline = true;
            this.alteredText.Name = "alteredText";
            this.alteredText.ReadOnly = true;
            this.alteredText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alteredText.Size = new System.Drawing.Size(691, 97);
            this.alteredText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изменённый текст (предыдущий шаг)";
            // 
            // eventLog
            // 
            this.eventLog.Location = new System.Drawing.Point(12, 449);
            this.eventLog.Multiline = true;
            this.eventLog.Name = "eventLog";
            this.eventLog.ReadOnly = true;
            this.eventLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventLog.Size = new System.Drawing.Size(191, 225);
            this.eventLog.TabIndex = 5;
            // 
            // varOne
            // 
            this.varOne.AutoSize = true;
            this.varOne.Location = new System.Drawing.Point(6, 40);
            this.varOne.Name = "varOne";
            this.varOne.Size = new System.Drawing.Size(76, 17);
            this.varOne.TabIndex = 8;
            this.varOne.Text = "Вариант 1";
            this.varOne.UseVisualStyleBackColor = true;
            this.varOne.CheckedChanged += new System.EventHandler(this.varTwo_CheckedChanged);
            // 
            // varTwo
            // 
            this.varTwo.AutoSize = true;
            this.varTwo.Checked = true;
            this.varTwo.Location = new System.Drawing.Point(6, 19);
            this.varTwo.Name = "varTwo";
            this.varTwo.Size = new System.Drawing.Size(76, 17);
            this.varTwo.TabIndex = 9;
            this.varTwo.TabStop = true;
            this.varTwo.Text = "Вариант 2";
            this.varTwo.UseVisualStyleBackColor = true;
            this.varTwo.CheckedChanged += new System.EventHandler(this.varOne_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.varTwo);
            this.groupBox1.Controls.Add(this.varOne);
            this.groupBox1.Location = new System.Drawing.Point(608, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 63);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вариант";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(6, 48);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(488, 20);
            this.filePath.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Путь к файлу";
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(6, 19);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(174, 23);
            this.fileButton.TabIndex = 13;
            this.fileButton.Text = "Загрузить текстовый файл";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rarityQueue);
            this.groupBox2.Controls.Add(this.switchTable);
            this.groupBox2.Controls.Add(this.lastSymbols);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lastOp);
            this.groupBox2.Controls.Add(this.firstSymbols);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.forThatBox);
            this.groupBox2.Controls.Add(this.swapThisBox);
            this.groupBox2.Location = new System.Drawing.Point(209, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 157);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Замена";
            // 
            // switchTable
            // 
            this.switchTable.AllowUserToAddRows = false;
            this.switchTable.AllowUserToDeleteRows = false;
            this.switchTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.switchTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.switchTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.switchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.switchTable.ColumnHeadersVisible = false;
            this.switchTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.switchTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.switchTable.Location = new System.Drawing.Point(127, 66);
            this.switchTable.MultiSelect = false;
            this.switchTable.Name = "switchTable";
            this.switchTable.ReadOnly = true;
            this.switchTable.RowHeadersVisible = false;
            this.switchTable.Size = new System.Drawing.Size(260, 82);
            this.switchTable.TabIndex = 22;
            this.switchTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.switchTable_CellContentClick);
            // 
            // lastSymbols
            // 
            this.lastSymbols.AutoSize = true;
            this.lastSymbols.Location = new System.Drawing.Point(5, 111);
            this.lastSymbols.Name = "lastSymbols";
            this.lastSymbols.Size = new System.Drawing.Size(115, 17);
            this.lastSymbols.TabIndex = 23;
            this.lastSymbols.Text = "Кроме последних";
            this.lastSymbols.UseVisualStyleBackColor = true;
            this.lastSymbols.CheckedChanged += new System.EventHandler(this.lastSymbols_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Последняя операция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "На:";
            // 
            // lastOp
            // 
            this.lastOp.Location = new System.Drawing.Point(127, 31);
            this.lastOp.Name = "lastOp";
            this.lastOp.ReadOnly = true;
            this.lastOp.Size = new System.Drawing.Size(260, 20);
            this.lastOp.TabIndex = 20;
            // 
            // firstSymbols
            // 
            this.firstSymbols.AutoSize = true;
            this.firstSymbols.Location = new System.Drawing.Point(5, 92);
            this.firstSymbols.Name = "firstSymbols";
            this.firstSymbols.Size = new System.Drawing.Size(99, 17);
            this.firstSymbols.TabIndex = 22;
            this.firstSymbols.Text = "Кроме первых";
            this.firstSymbols.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Заменить:";
            // 
            // forThatBox
            // 
            this.forThatBox.Location = new System.Drawing.Point(5, 66);
            this.forThatBox.Name = "forThatBox";
            this.forThatBox.Size = new System.Drawing.Size(100, 20);
            this.forThatBox.TabIndex = 1;
            this.forThatBox.Click += new System.EventHandler(this.forThatBox_GotFocus);
            // 
            // swapThisBox
            // 
            this.swapThisBox.Location = new System.Drawing.Point(5, 31);
            this.swapThisBox.Name = "swapThisBox";
            this.swapThisBox.Size = new System.Drawing.Size(100, 20);
            this.swapThisBox.TabIndex = 0;
            this.swapThisBox.Click += new System.EventHandler(this.swapThisBox_GotFocus);
            this.swapThisBox.TextChanged += new System.EventHandler(this.swapThisBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(691, 97);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Изменённый текст (последний шаг)";
            // 
            // filePickButton
            // 
            this.filePickButton.Location = new System.Drawing.Point(189, 19);
            this.filePickButton.Name = "filePickButton";
            this.filePickButton.Size = new System.Drawing.Size(130, 23);
            this.filePickButton.TabIndex = 17;
            this.filePickButton.Text = "Просмотр файлов...";
            this.filePickButton.UseVisualStyleBackColor = true;
            this.filePickButton.Click += new System.EventHandler(this.filePickButton_Click);
            // 
            // filesGroup
            // 
            this.filesGroup.Controls.Add(this.fileButton);
            this.filesGroup.Controls.Add(this.filePickButton);
            this.filesGroup.Controls.Add(this.filePath);
            this.filesGroup.Controls.Add(this.label3);
            this.filesGroup.Location = new System.Drawing.Point(209, 606);
            this.filesGroup.Name = "filesGroup";
            this.filesGroup.Size = new System.Drawing.Size(502, 73);
            this.filesGroup.TabIndex = 18;
            this.filesGroup.TabStop = false;
            this.filesGroup.Text = "Работа с файлами";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(628, 3);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 19;
            this.restartButton.Text = "Сброс";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // changedCounter
            // 
            this.changedCounter.AutoSize = true;
            this.changedCounter.Location = new System.Drawing.Point(9, 428);
            this.changedCounter.Name = "changedCounter";
            this.changedCounter.Size = new System.Drawing.Size(191, 13);
            this.changedCounter.TabIndex = 20;
            this.changedCounter.Text = "Заменено 0% оригинального текста";
            // 
            // rarityQueue
            // 
            this.rarityQueue.AutoSize = true;
            this.rarityQueue.Location = new System.Drawing.Point(5, 134);
            this.rarityQueue.Name = "rarityQueue";
            this.rarityQueue.Size = new System.Drawing.Size(90, 17);
            this.rarityQueue.TabIndex = 24;
            this.rarityQueue.Text = "По редкости";
            this.rarityQueue.UseVisualStyleBackColor = true;
            this.rarityQueue.CheckedChanged += new System.EventHandler(this.rarityQueue_CheckedChanged);
            // 
            // placeholder
            // 
            this.placeholder.Location = new System.Drawing.Point(610, 581);
            this.placeholder.Mask = "00";
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(33, 20);
            this.placeholder.TabIndex = 21;
            this.placeholder.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Раз";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 682);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.changedCounter);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.filesGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.eventLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alteredText);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.originalText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Замена случайных символов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchTable)).EndInit();
            this.filesGroup.ResumeLayout(false);
            this.filesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox originalText;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox alteredText;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox eventLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton varOne;
        private System.Windows.Forms.RadioButton varTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox filePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox forThatBox;
        private System.Windows.Forms.TextBox swapThisBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filePickButton;
        private System.Windows.Forms.GroupBox filesGroup;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TextBox lastOp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox lastSymbols;
        private System.Windows.Forms.CheckBox firstSymbols;
        private System.Windows.Forms.DataGridView switchTable;
        private System.Windows.Forms.Label changedCounter;
        private System.Windows.Forms.CheckBox rarityQueue;
        private System.Windows.Forms.MaskedTextBox placeholder;
        private System.Windows.Forms.Label label8;
    }
}

