

namespace Sabaydash_331_num14
{

    public partial class Form1 : Form
    {
        string value_hei, value_len, mess_xml, res_text = "", hesh_text;
        int int_height, int_lenght, enc_text, sum_1, a;
        Color color_p;
        

        public Form1()
        {
            InitializeComponent();
        }
        

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            value_hei = f2.height;
            value_len = f2.lenght;
            color_p = f2.col_p;
            int_height = Convert.ToInt32(value_hei);
            int_lenght = Convert.ToInt32(value_len);
            paintToolStripMenuItem.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int_height > this.Height || int_lenght > this.Width)
                MessageBox.Show("Фигура выходит за пределы окна!", "Ошибка!");
            else
            {
                Graphics g = this.CreateGraphics();
                g.Clear(Color.White);
                Pen pen = new Pen(Form2.col, 5);
                g.DrawRectangle(pen, 40, 40, int_lenght, int_height);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
