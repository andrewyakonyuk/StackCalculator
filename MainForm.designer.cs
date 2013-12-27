namespace StackCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_pow = new System.Windows.Forms.Button();
            this.but_log = new System.Windows.Forms.Button();
            this.but_tg = new System.Windows.Forms.Button();
            this.but_cos = new System.Windows.Forms.Button();
            this.but_sin = new System.Windows.Forms.Button();
            this.but_result = new System.Windows.Forms.Button();
            this.but_znak = new System.Windows.Forms.Button();
            this.but_sqr = new System.Windows.Forms.Button();
            this.but_sqrt = new System.Windows.Forms.Button();
            this.but_divide = new System.Windows.Forms.Button();
            this.but_multiply = new System.Windows.Forms.Button();
            this.but_plus = new System.Windows.Forms.Button();
            this.but_minus = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_backspace = new System.Windows.Forms.Button();
            this.but_dot = new System.Windows.Forms.Button();
            this.but_0 = new System.Windows.Forms.Button();
            this.but_9 = new System.Windows.Forms.Button();
            this.but_8 = new System.Windows.Forms.Button();
            this.but_7 = new System.Windows.Forms.Button();
            this.but_6 = new System.Windows.Forms.Button();
            this.but_5 = new System.Windows.Forms.Button();
            this.but_4 = new System.Windows.Forms.Button();
            this.but_3 = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.but_1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постфикснаяВИнфикснуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфикснаяВПостфикснуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызватьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_display = new System.Windows.Forms.TextBox();
            this.left_bracket = new System.Windows.Forms.Button();
            this.right_bracket = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.addition_wizard = new System.Windows.Forms.TextBox();
            this.other_number = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_pow
            // 
            this.but_pow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_pow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_pow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_pow.Location = new System.Drawing.Point(12, 308);
            this.but_pow.Name = "but_pow";
            this.but_pow.Size = new System.Drawing.Size(35, 35);
            this.but_pow.TabIndex = 60;
            this.but_pow.Tag = "^";
            this.but_pow.Text = "x^n";
            this.but_pow.UseVisualStyleBackColor = true;
            this.but_pow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_log
            // 
            this.but_log.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_log.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_log.Location = new System.Drawing.Point(12, 348);
            this.but_log.Name = "but_log";
            this.but_log.Size = new System.Drawing.Size(35, 35);
            this.but_log.TabIndex = 58;
            this.but_log.Tag = "log";
            this.but_log.Text = "log";
            this.but_log.UseVisualStyleBackColor = true;
            this.but_log.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_tg
            // 
            this.but_tg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_tg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_tg.Location = new System.Drawing.Point(53, 348);
            this.but_tg.Name = "but_tg";
            this.but_tg.Size = new System.Drawing.Size(35, 35);
            this.but_tg.TabIndex = 57;
            this.but_tg.Tag = "tan";
            this.but_tg.Text = "tan";
            this.but_tg.UseVisualStyleBackColor = true;
            this.but_tg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_cos
            // 
            this.but_cos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_cos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cos.Location = new System.Drawing.Point(53, 308);
            this.but_cos.Name = "but_cos";
            this.but_cos.Size = new System.Drawing.Size(35, 35);
            this.but_cos.TabIndex = 56;
            this.but_cos.Tag = "cos";
            this.but_cos.Text = "cos";
            this.but_cos.UseVisualStyleBackColor = true;
            this.but_cos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_sin
            // 
            this.but_sin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_sin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_sin.Location = new System.Drawing.Point(94, 308);
            this.but_sin.Name = "but_sin";
            this.but_sin.Size = new System.Drawing.Size(35, 35);
            this.but_sin.TabIndex = 55;
            this.but_sin.Tag = "sin";
            this.but_sin.Text = "sin";
            this.but_sin.UseVisualStyleBackColor = true;
            this.but_sin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_result
            // 
            this.but_result.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_result.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_result.Location = new System.Drawing.Point(317, 307);
            this.but_result.Name = "but_result";
            this.but_result.Size = new System.Drawing.Size(33, 78);
            this.but_result.TabIndex = 54;
            this.but_result.Text = "=";
            this.but_result.UseVisualStyleBackColor = true;
            this.but_result.Click += new System.EventHandler(this.but_result_Click);
            // 
            // but_znak
            // 
            this.but_znak.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_znak.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_znak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_znak.Location = new System.Drawing.Point(233, 349);
            this.but_znak.Name = "but_znak";
            this.but_znak.Size = new System.Drawing.Size(35, 35);
            this.but_znak.TabIndex = 52;
            this.but_znak.Tag = "sign";
            this.but_znak.Text = "±";
            this.but_znak.UseVisualStyleBackColor = true;
            this.but_znak.MouseClick += new System.Windows.Forms.MouseEventHandler(this.but_znak_MouseClick);
            // 
            // but_sqr
            // 
            this.but_sqr.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_sqr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_sqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_sqr.Location = new System.Drawing.Point(12, 268);
            this.but_sqr.Name = "but_sqr";
            this.but_sqr.Size = new System.Drawing.Size(35, 35);
            this.but_sqr.TabIndex = 51;
            this.but_sqr.Tag = "^2";
            this.but_sqr.Text = "x^2";
            this.but_sqr.UseVisualStyleBackColor = true;
            this.but_sqr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_sqrt
            // 
            this.but_sqrt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_sqrt.Location = new System.Drawing.Point(316, 225);
            this.but_sqrt.Name = "but_sqrt";
            this.but_sqrt.Size = new System.Drawing.Size(35, 35);
            this.but_sqrt.TabIndex = 50;
            this.but_sqrt.Tag = "sqrt";
            this.but_sqrt.Text = "√";
            this.but_sqrt.UseVisualStyleBackColor = true;
            this.but_sqrt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_divide
            // 
            this.but_divide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_divide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_divide.Location = new System.Drawing.Point(275, 225);
            this.but_divide.Name = "but_divide";
            this.but_divide.Size = new System.Drawing.Size(35, 35);
            this.but_divide.TabIndex = 49;
            this.but_divide.Tag = "/";
            this.but_divide.Text = "/";
            this.but_divide.UseVisualStyleBackColor = true;
            this.but_divide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_multiply
            // 
            this.but_multiply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_multiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_multiply.Location = new System.Drawing.Point(274, 267);
            this.but_multiply.Name = "but_multiply";
            this.but_multiply.Size = new System.Drawing.Size(35, 35);
            this.but_multiply.TabIndex = 48;
            this.but_multiply.Tag = "*";
            this.but_multiply.Text = "*";
            this.but_multiply.UseVisualStyleBackColor = true;
            this.but_multiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_plus
            // 
            this.but_plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_plus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_plus.Location = new System.Drawing.Point(274, 348);
            this.but_plus.Name = "but_plus";
            this.but_plus.Size = new System.Drawing.Size(35, 35);
            this.but_plus.TabIndex = 47;
            this.but_plus.Tag = "+";
            this.but_plus.Text = "+";
            this.but_plus.UseVisualStyleBackColor = true;
            this.but_plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_minus
            // 
            this.but_minus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_minus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_minus.Location = new System.Drawing.Point(274, 307);
            this.but_minus.Name = "but_minus";
            this.but_minus.Size = new System.Drawing.Size(35, 35);
            this.but_minus.TabIndex = 46;
            this.but_minus.Tag = "-";
            this.but_minus.Text = "-";
            this.but_minus.UseVisualStyleBackColor = true;
            this.but_minus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_clear
            // 
            this.but_clear.BackColor = System.Drawing.Color.Silver;
            this.but_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_clear.Location = new System.Drawing.Point(12, 227);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(35, 35);
            this.but_clear.TabIndex = 45;
            this.but_clear.Text = "CE";
            this.but_clear.UseVisualStyleBackColor = false;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // but_backspace
            // 
            this.but_backspace.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_backspace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_backspace.Location = new System.Drawing.Point(53, 227);
            this.but_backspace.Name = "but_backspace";
            this.but_backspace.Size = new System.Drawing.Size(76, 35);
            this.but_backspace.TabIndex = 44;
            this.but_backspace.Text = "⇦";
            this.but_backspace.UseVisualStyleBackColor = true;
            this.but_backspace.Click += new System.EventHandler(this.but_backspace_Click);
            // 
            // but_dot
            // 
            this.but_dot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_dot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_dot.Location = new System.Drawing.Point(151, 348);
            this.but_dot.Name = "but_dot";
            this.but_dot.Size = new System.Drawing.Size(35, 35);
            this.but_dot.TabIndex = 43;
            this.but_dot.Tag = ".";
            this.but_dot.Text = ".";
            this.but_dot.UseVisualStyleBackColor = true;
            this.but_dot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_0
            // 
            this.but_0.BackColor = System.Drawing.Color.DimGray;
            this.but_0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_0.Location = new System.Drawing.Point(192, 348);
            this.but_0.Name = "but_0";
            this.but_0.Size = new System.Drawing.Size(35, 35);
            this.but_0.TabIndex = 42;
            this.but_0.Tag = "0";
            this.but_0.Text = "0";
            this.but_0.UseVisualStyleBackColor = false;
            this.but_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_9
            // 
            this.but_9.BackColor = System.Drawing.Color.DimGray;
            this.but_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_9.Location = new System.Drawing.Point(234, 227);
            this.but_9.Name = "but_9";
            this.but_9.Size = new System.Drawing.Size(35, 35);
            this.but_9.TabIndex = 41;
            this.but_9.Tag = "9";
            this.but_9.Text = "9";
            this.but_9.UseVisualStyleBackColor = false;
            this.but_9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_8
            // 
            this.but_8.BackColor = System.Drawing.Color.DimGray;
            this.but_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_8.Location = new System.Drawing.Point(193, 227);
            this.but_8.Name = "but_8";
            this.but_8.Size = new System.Drawing.Size(35, 35);
            this.but_8.TabIndex = 40;
            this.but_8.Tag = "8";
            this.but_8.Text = "8";
            this.but_8.UseVisualStyleBackColor = false;
            this.but_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_7
            // 
            this.but_7.BackColor = System.Drawing.Color.DimGray;
            this.but_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_7.Location = new System.Drawing.Point(153, 226);
            this.but_7.Name = "but_7";
            this.but_7.Size = new System.Drawing.Size(35, 35);
            this.but_7.TabIndex = 39;
            this.but_7.Tag = "7";
            this.but_7.Text = "7";
            this.but_7.UseVisualStyleBackColor = false;
            this.but_7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_6
            // 
            this.but_6.BackColor = System.Drawing.Color.DimGray;
            this.but_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_6.Location = new System.Drawing.Point(234, 268);
            this.but_6.Name = "but_6";
            this.but_6.Size = new System.Drawing.Size(35, 35);
            this.but_6.TabIndex = 38;
            this.but_6.Tag = "6";
            this.but_6.Text = "6";
            this.but_6.UseVisualStyleBackColor = false;
            this.but_6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_5
            // 
            this.but_5.BackColor = System.Drawing.Color.DimGray;
            this.but_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_5.Location = new System.Drawing.Point(193, 268);
            this.but_5.Name = "but_5";
            this.but_5.Size = new System.Drawing.Size(35, 35);
            this.but_5.TabIndex = 37;
            this.but_5.Tag = "5";
            this.but_5.Text = "5";
            this.but_5.UseVisualStyleBackColor = false;
            this.but_5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_4
            // 
            this.but_4.BackColor = System.Drawing.Color.DimGray;
            this.but_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_4.Location = new System.Drawing.Point(152, 267);
            this.but_4.Name = "but_4";
            this.but_4.Size = new System.Drawing.Size(35, 35);
            this.but_4.TabIndex = 36;
            this.but_4.Tag = "4";
            this.but_4.Text = "4";
            this.but_4.UseVisualStyleBackColor = false;
            this.but_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_3
            // 
            this.but_3.BackColor = System.Drawing.Color.DimGray;
            this.but_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_3.Location = new System.Drawing.Point(234, 309);
            this.but_3.Name = "but_3";
            this.but_3.Size = new System.Drawing.Size(35, 35);
            this.but_3.TabIndex = 35;
            this.but_3.Tag = "3";
            this.but_3.Text = "3";
            this.but_3.UseVisualStyleBackColor = false;
            this.but_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_2
            // 
            this.but_2.BackColor = System.Drawing.Color.DimGray;
            this.but_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_2.Location = new System.Drawing.Point(193, 309);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(35, 35);
            this.but_2.TabIndex = 34;
            this.but_2.Tag = "2";
            this.but_2.Text = "2";
            this.but_2.UseVisualStyleBackColor = false;
            this.but_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // but_1
            // 
            this.but_1.BackColor = System.Drawing.Color.DimGray;
            this.but_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_1.Location = new System.Drawing.Point(152, 309);
            this.but_1.Name = "but_1";
            this.but_1.Size = new System.Drawing.Size(35, 35);
            this.but_1.TabIndex = 33;
            this.but_1.Tag = "1";
            this.but_1.Text = "1";
            this.but_1.UseVisualStyleBackColor = false;
            this.but_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постфикснаяВИнфикснуюToolStripMenuItem,
            this.инфикснаяВПостфикснуюToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // постфикснаяВИнфикснуюToolStripMenuItem
            // 
            this.постфикснаяВИнфикснуюToolStripMenuItem.Name = "постфикснаяВИнфикснуюToolStripMenuItem";
            this.постфикснаяВИнфикснуюToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.постфикснаяВИнфикснуюToolStripMenuItem.Tag = "postfix";
            this.постфикснаяВИнфикснуюToolStripMenuItem.Text = "Постфиксная в инфиксную";
            this.постфикснаяВИнфикснуюToolStripMenuItem.Click += new System.EventHandler(this.changeWizard_ToolStripMenuItem_Click);
            // 
            // инфикснаяВПостфикснуюToolStripMenuItem
            // 
            this.инфикснаяВПостфикснуюToolStripMenuItem.Name = "инфикснаяВПостфикснуюToolStripMenuItem";
            this.инфикснаяВПостфикснуюToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.инфикснаяВПостфикснуюToolStripMenuItem.Tag = "infix";
            this.инфикснаяВПостфикснуюToolStripMenuItem.Text = "Инфиксная в постфиксную";
            this.инфикснаяВПостфикснуюToolStripMenuItem.Click += new System.EventHandler(this.changeWizard_ToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызватьСправкуToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // вызватьСправкуToolStripMenuItem
            // 
            this.вызватьСправкуToolStripMenuItem.Name = "вызватьСправкуToolStripMenuItem";
            this.вызватьСправкуToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.вызватьСправкуToolStripMenuItem.Text = "Вызвать справку";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // tb_display
            // 
            this.tb_display.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_display.Enabled = false;
            this.tb_display.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_display.Location = new System.Drawing.Point(12, 28);
            this.tb_display.Margin = new System.Windows.Forms.Padding(4);
            this.tb_display.Multiline = true;
            this.tb_display.Name = "tb_display";
            this.tb_display.ReadOnly = true;
            this.tb_display.ShortcutsEnabled = false;
            this.tb_display.Size = new System.Drawing.Size(338, 106);
            this.tb_display.TabIndex = 32;
            this.tb_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // left_bracket
            // 
            this.left_bracket.BackColor = System.Drawing.Color.Silver;
            this.left_bracket.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.left_bracket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.left_bracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left_bracket.Location = new System.Drawing.Point(53, 266);
            this.left_bracket.Name = "left_bracket";
            this.left_bracket.Size = new System.Drawing.Size(35, 35);
            this.left_bracket.TabIndex = 45;
            this.left_bracket.Tag = "(";
            this.left_bracket.Text = "(";
            this.left_bracket.UseVisualStyleBackColor = false;
            this.left_bracket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // right_bracket
            // 
            this.right_bracket.BackColor = System.Drawing.Color.Silver;
            this.right_bracket.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.right_bracket.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.right_bracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right_bracket.Location = new System.Drawing.Point(94, 266);
            this.right_bracket.Name = "right_bracket";
            this.right_bracket.Size = new System.Drawing.Size(35, 35);
            this.right_bracket.TabIndex = 45;
            this.right_bracket.Tag = ")";
            this.right_bracket.Text = ")";
            this.right_bracket.UseVisualStyleBackColor = false;
            this.right_bracket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // percent
            // 
            this.percent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent.Location = new System.Drawing.Point(316, 266);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(35, 35);
            this.percent.TabIndex = 50;
            this.percent.Tag = "%";
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // addition_wizard
            // 
            this.addition_wizard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addition_wizard.Enabled = false;
            this.addition_wizard.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition_wizard.Location = new System.Drawing.Point(12, 142);
            this.addition_wizard.Margin = new System.Windows.Forms.Padding(4);
            this.addition_wizard.Multiline = true;
            this.addition_wizard.Name = "addition_wizard";
            this.addition_wizard.ReadOnly = true;
            this.addition_wizard.ShortcutsEnabled = false;
            this.addition_wizard.Size = new System.Drawing.Size(338, 76);
            this.addition_wizard.TabIndex = 32;
            this.addition_wizard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // other_number
            // 
            this.other_number.BackColor = System.Drawing.Color.DimGray;
            this.other_number.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.other_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.other_number.Location = new System.Drawing.Point(94, 348);
            this.other_number.Name = "other_number";
            this.other_number.Size = new System.Drawing.Size(35, 35);
            this.other_number.TabIndex = 55;
            this.other_number.Tag = "";
            this.other_number.Text = "N";
            this.other_number.UseVisualStyleBackColor = false;
            this.other_number.Click += new System.EventHandler(this.other_number_Click);
            this.other_number.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputButtons_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 391);
            this.Controls.Add(this.but_pow);
            this.Controls.Add(this.but_log);
            this.Controls.Add(this.but_tg);
            this.Controls.Add(this.but_cos);
            this.Controls.Add(this.other_number);
            this.Controls.Add(this.but_sin);
            this.Controls.Add(this.but_result);
            this.Controls.Add(this.but_znak);
            this.Controls.Add(this.but_sqr);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.but_sqrt);
            this.Controls.Add(this.but_divide);
            this.Controls.Add(this.but_multiply);
            this.Controls.Add(this.but_plus);
            this.Controls.Add(this.but_minus);
            this.Controls.Add(this.right_bracket);
            this.Controls.Add(this.left_bracket);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_backspace);
            this.Controls.Add(this.but_dot);
            this.Controls.Add(this.but_0);
            this.Controls.Add(this.but_9);
            this.Controls.Add(this.but_8);
            this.Controls.Add(this.but_7);
            this.Controls.Add(this.but_6);
            this.Controls.Add(this.but_5);
            this.Controls.Add(this.but_4);
            this.Controls.Add(this.but_3);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_1);
            this.Controls.Add(this.addition_wizard);
            this.Controls.Add(this.tb_display);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стековый калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_pow;
        private System.Windows.Forms.Button but_log;
        private System.Windows.Forms.Button but_tg;
        private System.Windows.Forms.Button but_cos;
        private System.Windows.Forms.Button but_sin;
        private System.Windows.Forms.Button but_result;
        private System.Windows.Forms.Button but_znak;
        private System.Windows.Forms.Button but_sqr;
        private System.Windows.Forms.Button but_sqrt;
        private System.Windows.Forms.Button but_divide;
        private System.Windows.Forms.Button but_multiply;
        private System.Windows.Forms.Button but_plus;
        private System.Windows.Forms.Button but_minus;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_backspace;
        private System.Windows.Forms.Button but_dot;
        private System.Windows.Forms.Button but_0;
        private System.Windows.Forms.Button but_9;
        private System.Windows.Forms.Button but_8;
        private System.Windows.Forms.Button but_7;
        private System.Windows.Forms.Button but_6;
        private System.Windows.Forms.Button but_5;
        private System.Windows.Forms.Button but_4;
        private System.Windows.Forms.Button but_3;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.Button but_1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызватьСправкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_display;
        private System.Windows.Forms.Button left_bracket;
        private System.Windows.Forms.Button right_bracket;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.TextBox addition_wizard;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постфикснаяВИнфикснуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инфикснаяВПостфикснуюToolStripMenuItem;
        private System.Windows.Forms.Button other_number;
    }
}

