namespace dictionary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            save = new Button();
            load = new Button();
            panel2 = new Panel();
            label3 = new Label();
            loaded = new ListView();
            qwe = new ColumnHeader();
            asd = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            addto = new Button();
            texteng = new TextBox();
            textru = new TextBox();
            panel3 = new Panel();
            takeit = new ComboBox();
            seacheng = new TextBox();
            comeback = new Button();
            label4 = new Label();
            seach = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // save
            // 
            save.Location = new Point(456, 21);
            save.Name = "save";
            save.Size = new Size(124, 38);
            save.TabIndex = 8;
            save.Text = "Сохранить список";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click_1;
            // 
            // load
            // 
            load.BackColor = SystemColors.ButtonHighlight;
            load.Location = new Point(456, 79);
            load.Name = "load";
            load.Size = new Size(124, 38);
            load.TabIndex = 9;
            load.Text = "Загрузить список";
            load.UseVisualStyleBackColor = false;
            load.Click += load_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(loaded);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(addto);
            panel2.Controls.Add(load);
            panel2.Controls.Add(save);
            panel2.Controls.Add(texteng);
            panel2.Controls.Add(textru);
            panel2.Location = new Point(327, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 525);
            panel2.TabIndex = 15;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ScrollBar;
            label3.Location = new Point(44, 168);
            label3.Name = "label3";
            label3.Size = new Size(544, 6);
            label3.TabIndex = 11;
            // 
            // loaded
            // 
            loaded.Columns.AddRange(new ColumnHeader[] { qwe, asd });
            loaded.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loaded.GridLines = true;
            loaded.Location = new Point(44, 142);
            loaded.Name = "loaded";
            loaded.Size = new Size(544, 332);
            loaded.TabIndex = 10;
            loaded.UseCompatibleStateImageBehavior = false;
            loaded.View = View.Details;
            // 
            // qwe
            // 
            qwe.Text = "                               eng ";
            qwe.Width = 270;
            // 
            // asd
            // 
            asd.Tag = "";
            asd.Text = "                                ru";
            asd.Width = 270;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveBorder;
            label2.Location = new Point(30, 76);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "слово(RU)";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.InactiveBorder;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 3;
            label1.Text = "слово(ENG)";
            // 
            // addto
            // 
            addto.BackColor = Color.FromArgb(15, 125, 238);
            addto.BackgroundImageLayout = ImageLayout.None;
            addto.FlatAppearance.BorderSize = 0;
            addto.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 240, 14);
            addto.FlatStyle = FlatStyle.Flat;
            addto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addto.ForeColor = SystemColors.ButtonHighlight;
            addto.Location = new Point(242, 64);
            addto.Name = "addto";
            addto.Size = new Size(104, 27);
            addto.TabIndex = 0;
            addto.Text = "Добавить";
            addto.UseVisualStyleBackColor = false;
            addto.Click += addto_Click;
            // 
            // texteng
            // 
            texteng.Font = new Font("Microsoft Sans Serif", 8.25F);
            texteng.Location = new Point(30, 39);
            texteng.Name = "texteng";
            texteng.Size = new Size(200, 20);
            texteng.TabIndex = 1;
            // 
            // textru
            // 
            textru.Location = new Point(30, 94);
            textru.Name = "textru";
            textru.Size = new Size(200, 23);
            textru.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(takeit);
            panel3.Controls.Add(seacheng);
            panel3.Controls.Add(comeback);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(seach);
            panel3.Location = new Point(-4, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 525);
            panel3.TabIndex = 16;
            // 
            // takeit
            // 
            takeit.DropDownStyle = ComboBoxStyle.DropDownList;
            takeit.FormattingEnabled = true;
            takeit.Items.AddRange(new object[] { "English", "Russian" });
            takeit.Location = new Point(92, 37);
            takeit.Name = "takeit";
            takeit.Size = new Size(138, 23);
            takeit.TabIndex = 14;
            // 
            // seacheng
            // 
            seacheng.Location = new Point(92, 60);
            seacheng.Name = "seacheng";
            seacheng.Size = new Size(138, 23);
            seacheng.TabIndex = 12;
            // 
            // comeback
            // 
            comeback.Location = new Point(168, 95);
            comeback.Name = "comeback";
            comeback.Size = new Size(81, 22);
            comeback.TabIndex = 11;
            comeback.Text = "Вернуть";
            comeback.UseVisualStyleBackColor = true;
            comeback.Click += comeback_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.InactiveBorder;
            label4.Location = new Point(92, 20);
            label4.Name = "label4";
            label4.Size = new Size(97, 18);
            label4.TabIndex = 13;
            label4.Text = "Выберите язык";
            // 
            // seach
            // 
            seach.Location = new Point(50, 95);
            seach.Name = "seach";
            seach.Size = new Size(81, 22);
            seach.TabIndex = 10;
            seach.Text = "Искать";
            seach.UseVisualStyleBackColor = true;
            seach.Click += seach_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(949, 525);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Button save;
        private Button load;
        private Panel panel2;
        private Panel panel3;
        private TextBox seacheng;
        private Button comeback;
        private Label label4;
        private Button seach;
        private Button addto;
        private TextBox texteng;
        private TextBox textru;
        private Label label1;
        private Label label2;
        private ListView loaded;
        private ColumnHeader qwe;
        private ColumnHeader asd;
        private ColumnHeader eng;
        private Label label3;
        private ComboBox takeit;
    }
}
