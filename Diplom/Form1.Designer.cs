using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Diplom
{
    partial class Analiser
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analiser));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_console = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.Description6 = new System.Windows.Forms.Label();
            this.bt_Erase = new System.Windows.Forms.Button();
            this.Descripton5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Description1 = new System.Windows.Forms.Label();
            this.Description4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Description2 = new System.Windows.Forms.Label();
            this.bt_Start = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.tb_console);
            this.tabPage2.Controls.Add(this.bt_Save);
            this.tabPage2.Controls.Add(this.Description6);
            this.tabPage2.Controls.Add(this.bt_Erase);
            this.tabPage2.Controls.Add(this.Descripton5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1099, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Результаты анализа:";
            // 
            // tb_console
            // 
            this.tb_console.Location = new System.Drawing.Point(9, 50);
            this.tb_console.Multiline = true;
            this.tb_console.Name = "tb_console";
            this.tb_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_console.Size = new System.Drawing.Size(793, 469);
            this.tb_console.TabIndex = 5;
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Save.Location = new System.Drawing.Point(888, 72);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(120, 40);
            this.bt_Save.TabIndex = 8;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // Description6
            // 
            this.Description6.AutoSize = true;
            this.Description6.Cursor = System.Windows.Forms.Cursors.Help;
            this.Description6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description6.Location = new System.Drawing.Point(876, 256);
            this.Description6.Margin = new System.Windows.Forms.Padding(3);
            this.Description6.Name = "Description6";
            this.Description6.Size = new System.Drawing.Size(217, 64);
            this.Description6.TabIndex = 13;
            this.Description6.Text = "Шаг 5:\r\n Для очистки поля результатов \r\nнажмите\" Erase \",\r\n для сохранения нажмит" +
    "е \" Save \"";
            this.Description6.UseCompatibleTextRendering = true;
            // 
            // bt_Erase
            // 
            this.bt_Erase.BackColor = System.Drawing.Color.Aquamarine;
            this.bt_Erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Erase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Erase.Location = new System.Drawing.Point(888, 411);
            this.bt_Erase.Name = "bt_Erase";
            this.bt_Erase.Size = new System.Drawing.Size(120, 40);
            this.bt_Erase.TabIndex = 7;
            this.bt_Erase.Text = "Erase";
            this.bt_Erase.UseVisualStyleBackColor = false;
            this.bt_Erase.Click += new System.EventHandler(this.bt_Erase_Click);
            // 
            // Descripton5
            // 
            this.Descripton5.AutoSize = true;
            this.Descripton5.Cursor = System.Windows.Forms.Cursors.Help;
            this.Descripton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Descripton5.Location = new System.Drawing.Point(6, 19);
            this.Descripton5.Name = "Descripton5";
            this.Descripton5.Size = new System.Drawing.Size(149, 16);
            this.Descripton5.TabIndex = 12;
            this.Descripton5.Text = "Результаты анализа:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.trackBar5);
            this.tabPage1.Controls.Add(this.trackBar4);
            this.tabPage1.Controls.Add(this.trackBar3);
            this.tabPage1.Controls.Add(this.trackBar2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox9);
            this.tabPage1.Controls.Add(this.pictureBox10);
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Controls.Add(this.pictureBox8);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.Description1);
            this.tabPage1.Controls.Add(this.Description4);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.Description2);
            this.tabPage1.Controls.Add(this.bt_Start);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1099, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ввод данных:";
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.Color.Lavender;
            this.trackBar5.Location = new System.Drawing.Point(910, 384);
            this.trackBar5.Maximum = 300;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(156, 45);
            this.trackBar5.TabIndex = 28;
            this.trackBar5.TickFrequency = 25;
            this.trackBar5.Value = 75;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.Color.Lavender;
            this.trackBar4.Location = new System.Drawing.Point(683, 384);
            this.trackBar4.Maximum = 300;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(156, 45);
            this.trackBar4.TabIndex = 27;
            this.trackBar4.TickFrequency = 25;
            this.trackBar4.Value = 75;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.Color.Lavender;
            this.trackBar3.Location = new System.Drawing.Point(464, 384);
            this.trackBar3.Maximum = 300;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(156, 45);
            this.trackBar3.TabIndex = 26;
            this.trackBar3.TickFrequency = 25;
            this.trackBar3.Value = 75;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.Lavender;
            this.trackBar2.Location = new System.Drawing.Point(242, 384);
            this.trackBar2.Maximum = 300;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(156, 45);
            this.trackBar2.TabIndex = 25;
            this.trackBar2.TickFrequency = 25;
            this.trackBar2.Value = 75;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(954, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Мизинец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Безымянный палец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Средний палец";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Указательный палец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Большой палец";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox9.Location = new System.Drawing.Point(907, 33);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(159, 148);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            this.pictureBox9.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox9_Paint);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox10.Location = new System.Drawing.Point(907, 228);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(159, 150);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox10_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox7.Location = new System.Drawing.Point(680, 33);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(159, 148);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox7_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox8.Location = new System.Drawing.Point(680, 228);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(159, 150);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox8_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox5.Location = new System.Drawing.Point(461, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(159, 148);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox5_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox6.Location = new System.Drawing.Point(461, 228);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(159, 150);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox6_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox3.Location = new System.Drawing.Point(239, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 148);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Location = new System.Drawing.Point(239, 228);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(159, 150);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(17, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(17, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 150);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // Description1
            // 
            this.Description1.AutoSize = true;
            this.Description1.Cursor = System.Windows.Forms.Cursors.Help;
            this.Description1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description1.Location = new System.Drawing.Point(6, 3);
            this.Description1.Name = "Description1";
            this.Description1.Size = new System.Drawing.Size(655, 16);
            this.Description1.TabIndex = 0;
            this.Description1.Text = "Шаг 1: Для загрузки изображения нажмите на левую область выберете  изображение дл" +
    "я анализа";
            // 
            // Description4
            // 
            this.Description4.AutoSize = true;
            this.Description4.Cursor = System.Windows.Forms.Cursors.Help;
            this.Description4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description4.Location = new System.Drawing.Point(14, 496);
            this.Description4.Name = "Description4";
            this.Description4.Size = new System.Drawing.Size(381, 16);
            this.Description4.TabIndex = 11;
            this.Description4.Text = "Шаг 4: Нажмите \" Start \" для начала анализа изображения";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Lavender;
            this.trackBar1.Location = new System.Drawing.Point(20, 384);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.Value = 75;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Description2
            // 
            this.Description2.AutoSize = true;
            this.Description2.Cursor = System.Windows.Forms.Cursors.Help;
            this.Description2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description2.Location = new System.Drawing.Point(11, 432);
            this.Description2.Name = "Description2";
            this.Description2.Size = new System.Drawing.Size(609, 16);
            this.Description2.TabIndex = 9;
            this.Description2.Text = "Шаг 2: При необходимости сдвигайте ползунок для изменения контрастности изображен" +
    "ия";
            // 
            // bt_Start
            // 
            this.bt_Start.BackColor = System.Drawing.Color.Orange;
            this.bt_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Start.Location = new System.Drawing.Point(575, 496);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(75, 23);
            this.bt_Start.TabIndex = 6;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = false;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1107, 565);
            this.tabControl1.TabIndex = 14;
            // 
            // Analiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 566);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Analiser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ ГРВграмм по методу Мандела";
            this.Load += new System.EventHandler(this.Analiser_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion
        private TabPage tabPage2;
        private TextBox tb_console;
        private Button bt_Save;
        private Label Description6;
        private Button bt_Erase;
        private Label Descripton5;
        private TabPage tabPage1;
        private TrackBar trackBar5;
        private TrackBar trackBar4;
        private TrackBar trackBar3;
        private TrackBar trackBar2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Description1;
        private Label Description4;
        private TrackBar trackBar1;
        private Label Description2;
        private Button bt_Start;
        private TabControl tabControl1;
    }
}

