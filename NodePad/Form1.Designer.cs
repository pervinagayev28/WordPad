namespace NodePad
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
            panel1 = new Panel();
            cbox_color = new ComboBox();
            btn_load = new Button();
            btn_save = new Button();
            tbox_load = new TextBox();
            tbox_save = new TextBox();
            cbox_size = new ComboBox();
            cbox_font = new ComboBox();
            label5 = new Label();
            btn_Aligment_left = new Button();
            btn_Aligment_center = new Button();
            btn_Aligment_right = new Button();
            label4 = new Label();
            btn_fontStyle_2 = new Button();
            btn_fontStyle_3 = new Button();
            btn_fontStyle_1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbox_writing = new RichTextBox();
            fontDialog1 = new FontDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(cbox_color);
            panel1.Controls.Add(btn_load);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(tbox_load);
            panel1.Controls.Add(tbox_save);
            panel1.Controls.Add(cbox_size);
            panel1.Controls.Add(cbox_font);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_Aligment_left);
            panel1.Controls.Add(btn_Aligment_center);
            panel1.Controls.Add(btn_Aligment_right);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_fontStyle_2);
            panel1.Controls.Add(btn_fontStyle_3);
            panel1.Controls.Add(btn_fontStyle_1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 105);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cbox_color
            // 
            cbox_color.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbox_color.BackColor = Color.Silver;
            cbox_color.DropDownHeight = 120;
            cbox_color.FormattingEnabled = true;
            cbox_color.IntegralHeight = false;
            cbox_color.ItemHeight = 20;
            cbox_color.Location = new Point(462, 48);
            cbox_color.Name = "cbox_color";
            cbox_color.Size = new Size(118, 28);
            cbox_color.TabIndex = 20;
            cbox_color.SelectedIndexChanged += cbox_color_SelectedIndexChanged_1;
            // 
            // btn_load
            // 
            btn_load.BackColor = Color.LightGray;
            btn_load.Location = new Point(1093, 47);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(94, 29);
            btn_load.TabIndex = 19;
            btn_load.Text = "LOAD";
            btn_load.UseVisualStyleBackColor = false;
            btn_load.Click += btn_load_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.LightGray;
            btn_save.Location = new Point(1093, 10);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 18;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // tbox_load
            // 
            tbox_load.Location = new Point(679, 47);
            tbox_load.Name = "tbox_load";
            tbox_load.Size = new Size(403, 27);
            tbox_load.TabIndex = 17;
            tbox_load.Text = "enter name to load";
            tbox_load.Click += tbox_load_Click;
            tbox_load.TextChanged += tbox_load_TextChanged;
            // 
            // tbox_save
            // 
            tbox_save.Location = new Point(679, 12);
            tbox_save.Name = "tbox_save";
            tbox_save.Size = new Size(403, 27);
            tbox_save.TabIndex = 1;
            tbox_save.Text = "enter name to save";
            tbox_save.Click += tbox_save_Click;
            tbox_save.TextChanged += textBox1_TextChanged;
            // 
            // cbox_size
            // 
            cbox_size.BackColor = Color.LightGray;
            cbox_size.DropDownHeight = 120;
            cbox_size.FormattingEnabled = true;
            cbox_size.IntegralHeight = false;
            cbox_size.Location = new Point(136, 46);
            cbox_size.Name = "cbox_size";
            cbox_size.Size = new Size(77, 28);
            cbox_size.TabIndex = 15;
            cbox_size.SelectedIndexChanged += cbox_size_SelectedIndexChanged;
            // 
            // cbox_font
            // 
            cbox_font.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbox_font.BackColor = Color.Silver;
            cbox_font.DropDownHeight = 120;
            cbox_font.FormattingEnabled = true;
            cbox_font.IntegralHeight = false;
            cbox_font.ItemHeight = 20;
            cbox_font.Location = new Point(12, 47);
            cbox_font.Name = "cbox_font";
            cbox_font.Size = new Size(118, 28);
            cbox_font.TabIndex = 14;
            cbox_font.SelectedIndexChanged += cbox_font_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(462, 11);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 12;
            label5.Text = "Color";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // btn_Aligment_left
            // 
            btn_Aligment_left.BackColor = Color.LightGray;
            btn_Aligment_left.Location = new Point(349, 46);
            btn_Aligment_left.Name = "btn_Aligment_left";
            btn_Aligment_left.Size = new Size(29, 29);
            btn_Aligment_left.TabIndex = 11;
            btn_Aligment_left.Text = "L";
            btn_Aligment_left.UseVisualStyleBackColor = false;
            btn_Aligment_left.Click += btn_Aligment_right_Click;
            // 
            // btn_Aligment_center
            // 
            btn_Aligment_center.BackColor = Color.LightGray;
            btn_Aligment_center.Location = new Point(384, 46);
            btn_Aligment_center.Name = "btn_Aligment_center";
            btn_Aligment_center.Size = new Size(29, 29);
            btn_Aligment_center.TabIndex = 10;
            btn_Aligment_center.Text = "C";
            btn_Aligment_center.UseVisualStyleBackColor = false;
            btn_Aligment_center.Click += button6_Click;
            // 
            // btn_Aligment_right
            // 
            btn_Aligment_right.BackColor = Color.LightGray;
            btn_Aligment_right.Location = new Point(420, 46);
            btn_Aligment_right.Name = "btn_Aligment_right";
            btn_Aligment_right.Size = new Size(29, 29);
            btn_Aligment_right.TabIndex = 9;
            btn_Aligment_right.Text = "R";
            btn_Aligment_right.UseVisualStyleBackColor = false;
            btn_Aligment_right.Click += btn_Aligment_center_Click;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(349, 11);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 8;
            label4.Text = "Aligment";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_fontStyle_2
            // 
            btn_fontStyle_2.BackColor = Color.LightGray;
            btn_fontStyle_2.Location = new Point(266, 46);
            btn_fontStyle_2.Name = "btn_fontStyle_2";
            btn_fontStyle_2.Size = new Size(29, 29);
            btn_fontStyle_2.TabIndex = 7;
            btn_fontStyle_2.Text = "_";
            btn_fontStyle_2.UseVisualStyleBackColor = false;
            btn_fontStyle_2.Click += btn_fontStyle_2_Click;
            // 
            // btn_fontStyle_3
            // 
            btn_fontStyle_3.BackColor = Color.LightGray;
            btn_fontStyle_3.Location = new Point(297, 46);
            btn_fontStyle_3.Name = "btn_fontStyle_3";
            btn_fontStyle_3.Size = new Size(29, 29);
            btn_fontStyle_3.TabIndex = 6;
            btn_fontStyle_3.Text = "/";
            btn_fontStyle_3.UseVisualStyleBackColor = false;
            btn_fontStyle_3.Click += btn_fontStyle_3_Click;
            // 
            // btn_fontStyle_1
            // 
            btn_fontStyle_1.BackColor = Color.LightGray;
            btn_fontStyle_1.Location = new Point(231, 46);
            btn_fontStyle_1.Name = "btn_fontStyle_1";
            btn_fontStyle_1.Size = new Size(29, 29);
            btn_fontStyle_1.TabIndex = 5;
            btn_fontStyle_1.Text = "B";
            btn_fontStyle_1.UseVisualStyleBackColor = false;
            btn_fontStyle_1.Click += btn_fontStyle_1_Click;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(226, 11);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 4;
            label3.Text = "FontStyle";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "Size";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Font";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbox_writing
            // 
            tbox_writing.Location = new Point(3, 80);
            tbox_writing.Name = "tbox_writing";
            tbox_writing.Size = new Size(1206, 595);
            tbox_writing.TabIndex = 0;
            tbox_writing.Text = "";
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1199, 695);
            Controls.Add(tbox_writing);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox tbox_writing;
        private Label label1;
        private FontDialog fontDialog1;
        private Label label2;
        private Button btn_fontStyle_2;
        private Button btn_fontStyle_3;
        private Button btn_fontStyle_1;
        private Label label3;
        private Button btn_Aligment_left;
        private Button btn_Aligment_center;
        private Button btn_Aligment_right;
        private Label label4;
        private Label label5;
        private ComboBox cbox_size;
        private ComboBox cbox_font;
        private TextBox tbox_load;
        private TextBox tbox_save;
        private Button btn_save;
        private Button btn_load;
        private ComboBox cbox_color;
    }
}