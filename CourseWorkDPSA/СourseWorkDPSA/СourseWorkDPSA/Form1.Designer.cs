namespace Cursac
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1_probability = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2_prefix = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label_countSymbols = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_beforeSize = new System.Windows.Forms.Label();
            this.label_sizeOfFile = new System.Windows.Forms.Label();
            this.label_after = new System.Windows.Forms.Label();
            this.textBox2_Decode = new System.Windows.Forms.TextBox();
            this.label6_fullCode = new System.Windows.Forms.Label();
            this.label6_decode = new System.Windows.Forms.Label();
            this.textBox2_encode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_coefficient = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_afterSize = new System.Windows.Forms.Label();
            this.label_amountOfCharacters = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_probability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_prefix)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите информацию: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(844, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 34);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 2;
            // 
            // dataGridView1_probability
            // 
            this.dataGridView1_probability.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1_probability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_probability.Location = new System.Drawing.Point(80, 111);
            this.dataGridView1_probability.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1_probability.Name = "dataGridView1_probability";
            this.dataGridView1_probability.RowHeadersWidth = 51;
            this.dataGridView1_probability.RowTemplate.Height = 24;
            this.dataGridView1_probability.Size = new System.Drawing.Size(361, 201);
            this.dataGridView1_probability.TabIndex = 4;
            this.dataGridView1_probability.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1637, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Оптимальные  префиксые коды";
            // 
            // dataGridView2_prefix
            // 
            this.dataGridView2_prefix.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2_prefix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_prefix.Location = new System.Drawing.Point(1680, 111);
            this.dataGridView2_prefix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2_prefix.Name = "dataGridView2_prefix";
            this.dataGridView2_prefix.RowHeadersWidth = 51;
            this.dataGridView2_prefix.RowTemplate.Height = 24;
            this.dataGridView2_prefix.Size = new System.Drawing.Size(332, 236);
            this.dataGridView2_prefix.TabIndex = 6;
            this.dataGridView2_prefix.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(916, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Построение дерева";
            // 
            // label_countSymbols
            // 
            this.label_countSymbols.AutoSize = true;
            this.label_countSymbols.BackColor = System.Drawing.Color.White;
            this.label_countSymbols.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countSymbols.Location = new System.Drawing.Point(28, 96);
            this.label_countSymbols.Name = "label_countSymbols";
            this.label_countSymbols.Size = new System.Drawing.Size(249, 26);
            this.label_countSymbols.TabIndex = 10;
            this.label_countSymbols.Text = "Количество символов: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1200, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ввести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(860, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Вероятность появления символов";
            // 
            // label_beforeSize
            // 
            this.label_beforeSize.AutoSize = true;
            this.label_beforeSize.BackColor = System.Drawing.Color.White;
            this.label_beforeSize.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_beforeSize.Location = new System.Drawing.Point(23, 14);
            this.label_beforeSize.Name = "label_beforeSize";
            this.label_beforeSize.Size = new System.Drawing.Size(284, 26);
            this.label_beforeSize.TabIndex = 18;
            this.label_beforeSize.Text = "Размер файла до сжатия:";
            // 
            // label_sizeOfFile
            // 
            this.label_sizeOfFile.AutoSize = true;
            this.label_sizeOfFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_sizeOfFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_sizeOfFile.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sizeOfFile.Location = new System.Drawing.Point(369, 14);
            this.label_sizeOfFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sizeOfFile.Name = "label_sizeOfFile";
            this.label_sizeOfFile.Size = new System.Drawing.Size(2, 28);
            this.label_sizeOfFile.TabIndex = 20;
            // 
            // label_after
            // 
            this.label_after.AutoSize = true;
            this.label_after.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_after.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_after.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_after.Location = new System.Drawing.Point(376, 57);
            this.label_after.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_after.Name = "label_after";
            this.label_after.Size = new System.Drawing.Size(2, 28);
            this.label_after.TabIndex = 22;
            // 
            // textBox2_Decode
            // 
            this.textBox2_Decode.BackColor = System.Drawing.Color.White;
            this.textBox2_Decode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_Decode.Enabled = false;
            this.textBox2_Decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2_Decode.Location = new System.Drawing.Point(788, 247);
            this.textBox2_Decode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Decode.Multiline = true;
            this.textBox2_Decode.Name = "textBox2_Decode";
            this.textBox2_Decode.Size = new System.Drawing.Size(396, 34);
            this.textBox2_Decode.TabIndex = 23;
            // 
            // label6_fullCode
            // 
            this.label6_fullCode.AutoSize = true;
            this.label6_fullCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6_fullCode.Location = new System.Drawing.Point(483, 204);
            this.label6_fullCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6_fullCode.Name = "label6_fullCode";
            this.label6_fullCode.Size = new System.Drawing.Size(277, 26);
            this.label6_fullCode.TabIndex = 24;
            this.label6_fullCode.Text = "Закодированный текст : ";
            // 
            // label6_decode
            // 
            this.label6_decode.AutoSize = true;
            this.label6_decode.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6_decode.Location = new System.Drawing.Point(483, 252);
            this.label6_decode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6_decode.Name = "label6_decode";
            this.label6_decode.Size = new System.Drawing.Size(279, 26);
            this.label6_decode.TabIndex = 25;
            this.label6_decode.Text = "Декодированный текст : ";
            // 
            // textBox2_encode
            // 
            this.textBox2_encode.BackColor = System.Drawing.Color.White;
            this.textBox2_encode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_encode.Enabled = false;
            this.textBox2_encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2_encode.Location = new System.Drawing.Point(773, 204);
            this.textBox2_encode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_encode.Multiline = true;
            this.textBox2_encode.Name = "textBox2_encode";
            this.textBox2_encode.Size = new System.Drawing.Size(824, 31);
            this.textBox2_encode.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "Коэффициент сжатия:";
            // 
            // label_coefficient
            // 
            this.label_coefficient.AutoSize = true;
            this.label_coefficient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_coefficient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_coefficient.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coefficient.Location = new System.Drawing.Point(331, 164);
            this.label_coefficient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_coefficient.Name = "label_coefficient";
            this.label_coefficient.Size = new System.Drawing.Size(2, 28);
            this.label_coefficient.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(773, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 36);
            this.button2.TabIndex = 31;
            this.button2.Text = "Закодировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1009, 159);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 36);
            this.button3.TabIndex = 32;
            this.button3.Text = "Раскодировать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(773, 123);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 28);
            this.button4.TabIndex = 33;
            this.button4.Text = "Показать таблицы";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1009, 123);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 28);
            this.button5.TabIndex = 34;
            this.button5.Text = "Показать информацию";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(493, 328);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1989, 1127);
            this.panel3.TabIndex = 36;
            // 
            // label_afterSize
            // 
            this.label_afterSize.AutoSize = true;
            this.label_afterSize.BackColor = System.Drawing.Color.White;
            this.label_afterSize.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_afterSize.Location = new System.Drawing.Point(23, 57);
            this.label_afterSize.Name = "label_afterSize";
            this.label_afterSize.Size = new System.Drawing.Size(317, 26);
            this.label_afterSize.TabIndex = 21;
            this.label_afterSize.Text = "Размер файла после сжатия:";
            // 
            // label_amountOfCharacters
            // 
            this.label_amountOfCharacters.AutoSize = true;
            this.label_amountOfCharacters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_amountOfCharacters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_amountOfCharacters.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amountOfCharacters.Location = new System.Drawing.Point(331, 96);
            this.label_amountOfCharacters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_amountOfCharacters.Name = "label_amountOfCharacters";
            this.label_amountOfCharacters.Size = new System.Drawing.Size(2, 28);
            this.label_amountOfCharacters.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_amountOfCharacters);
            this.panel1.Controls.Add(this.label_afterSize);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_countSymbols);
            this.panel1.Controls.Add(this.label_coefficient);
            this.panel1.Controls.Add(this.label_after);
            this.panel1.Controls.Add(this.label_sizeOfFile);
            this.panel1.Controls.Add(this.label_beforeSize);
            this.panel1.Location = new System.Drawing.Point(45, 328);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 229);
            this.panel1.TabIndex = 37;
            this.panel1.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1200, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 34);
            this.button6.TabIndex = 38;
            this.button6.Text = "Очистить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2_encode);
            this.Controls.Add(this.label6_decode);
            this.Controls.Add(this.label6_fullCode);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox2_Decode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2_prefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1_probability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Солдатов Никита Работа:Дерево Хаффмана";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_probability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_prefix)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_probability;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2_prefix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_countSymbols;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_beforeSize;
        private System.Windows.Forms.Label label_sizeOfFile;
        private System.Windows.Forms.Label label_after;
        private System.Windows.Forms.TextBox textBox2_Decode;
        private System.Windows.Forms.Label label6_fullCode;
        private System.Windows.Forms.Label label6_decode;
        private System.Windows.Forms.TextBox textBox2_encode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_coefficient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_afterSize;
        private System.Windows.Forms.Label label_amountOfCharacters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
    }
}

