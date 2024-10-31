using Cursac.temerev.model;
using Cursac.temerev.util;
using System;
using System.Drawing;
using System.Windows.Forms;
using Сursac.temerev.model;
using Сursac.temerev.util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace Cursac
{
    public partial class Form1 : Form
    {

        private MyDictionary dictionaryProb = new MyDictionary();
        private MyDictionary dictionaryPrefix = new MyDictionary();

        private MyHuffmanTree tree = new MyHuffmanTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataString = textBox1.Text;
            int Maxlen = 18;

            if (dataString.Length == 0)
            {
                return;
            }

            if (dataString.Length > Maxlen)
            {
                MessageBox.Show("Было введено больше 20 символов!", "Ошибка!");
                return;
            }

            WorkerWithFiles.WriteToFile(dataString);

            // Сжатие файла после записи данных
            WorkerWithFiles.CompressFile();

            label_amountOfCharacters.Text = Convert.ToString(dataString.Length);
            label_sizeOfFile.Text = Convert.ToString(WorkerWithFiles.GetSizeOfFile());

            // Остальной код остается без изменений
            WorkerWithDictionary.parseOfStingToDictionary(dataString, dictionaryProb.getDictionary());

            dataGridView1_probability.DataSource = new BindingSource(dictionaryProb.getDictionary(), null);
            dataGridView1_probability.AutoResizeColumns();

            tree.setFrequencies(dictionaryProb.getDictionary());
            tree.Build();

            string encode = "";
            string[] mass = tree.Encode(dataString, dictionaryProb.getDictionary());
            string decode = "";

            WorkerWithDictionary.FillingPrefixToDictionary(dataString, mass, dictionaryPrefix.getDictioinarySecond());

            dataGridView2_prefix.DataSource = new BindingSource(dictionaryPrefix.getDictioinarySecond(), null);
            dataGridView2_prefix.AutoResizeColumns();

            decode = tree.Decode(tree.FullCode(dataString));

            foreach (bool b in tree.FullCode(dataString))
            {
                encode += (b ? "1" : "0");
            }

            textBox2_Decode.Visible = false;
            textBox2_Decode.Text = decode;

            textBox2_encode.Visible = false;
            textBox2_encode.Text = encode;

            Graphics g = panel3.CreateGraphics();
            var obj = new Drawing();
            obj.Draw(g, mass, tree.GetRoot(), dictionaryProb.getDictionary());

            float encodeInt = encode.Length;
            float decodeInt = decode.Length;
            float kf = (decodeInt * 8) / encodeInt;

            label_after.Text = (encode.Length).ToString();
            label_coefficient.Text = kf.ToString();
            button1.Enabled = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            WorkerWithFiles.WriteToFile(textBox2_encode.Text);
            textBox2_encode.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkerWithFiles.WriteToFile(textBox2_Decode.Text);
            textBox2_Decode.Visible = true;

        }



        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1_probability.Visible = true;
            dataGridView2_prefix.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dictionaryProb = new MyDictionary();
            dictionaryPrefix = new MyDictionary();
            dataGridView1_probability.DataSource = null;
            dataGridView2_prefix.DataSource = null;
            panel3.Invalidate();
            textBox2_Decode.Visible = false;
            textBox2_Decode.Text = "";
            textBox2_encode.Visible = false;
            textBox2_encode.Text = "";
            label_amountOfCharacters.Text = "";
            label_sizeOfFile.Text = "";
            label_after.Text = "";
            label_coefficient.Text = "";
            tree = new MyHuffmanTree();
            panel1.Visible = false;
            dataGridView1_probability.Visible = false;
            dataGridView2_prefix.Visible = false;
            button1.Enabled = true;
        }

    }
}
