using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace NodePad
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbox_writing.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var font in FontFamily.Families)
                cbox_font.Items.Add(font.Name);
            cbox_font.Text = cbox_font.Items[0].ToString();
            for (int i = 8; i < 72; i++)
                cbox_size.Items.Add(i);
            cbox_size.Text = 12.ToString();
            foreach (PropertyInfo property in typeof(SystemColors).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    Color color = (Color)property.GetValue(null, null);
                    cbox_color.Items.Add(property.Name);
                }
            }
            cbox_color.Text = cbox_color.Items[0].ToString();
        }

        private void cbox_color_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_fontStyle_1_Click(object sender, EventArgs e)
        {
            tbox_writing.Font = new Font(tbox_writing.Font.FontFamily, tbox_writing.Font.Size, FontStyle.Bold);
        }

        private void btn_fontStyle_2_Click(object sender, EventArgs e)
        {
            tbox_writing.Font = new Font(tbox_writing.Font.FontFamily, tbox_writing.Font.Size, FontStyle.Underline);
        }

        private void btn_fontStyle_3_Click(object sender, EventArgs e)
        {
            tbox_writing.Font = new Font(tbox_writing.Font.FontFamily, tbox_writing.Font.Size, FontStyle.Italic);
        }

        private void cbox_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbox_writing.Font = new Font(cbox_font.SelectedItem.ToString(), tbox_writing.Font.Size, FontStyle.Italic);
        }

        private void cbox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbox_writing.Font = new Font(cbox_font.SelectedItem.ToString(), (int)cbox_size.SelectedItem, FontStyle.Italic);

        }

        private void btn_Aligment_right_Click(object sender, EventArgs e)
        {
            tbox_writing.RightToLeft = RightToLeft.No;
        }

        private void btn_Aligment_center_Click(object sender, EventArgs e)
        {
            tbox_writing.RightToLeft = RightToLeft.Yes;

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (File.Exists(tbox_load.Text.ToLower()))
            {
                tbox_writing.Text = File.ReadAllText(tbox_load.Text.ToString());
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText($"{tbox_save.Text}", tbox_writing.Text);
        }

        private void tbox_load_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbox_load_Click(object sender, EventArgs e)
        {
            tbox_load.Text = "";

        }

        private void tbox_save_Click(object sender, EventArgs e)
        {
            tbox_save.Text = "";

        }

        private void cbox_color_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbox_writing.ForeColor = Color.FromName(cbox_color.Text);
        }
    }
}
