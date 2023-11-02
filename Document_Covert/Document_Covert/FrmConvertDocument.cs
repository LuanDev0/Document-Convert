using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Document_Covert
{
    public partial class Frm_DocumentConvert : Form
    {
        public Frm_DocumentConvert()
        {
            InitializeComponent();
        }

        private void Bt_Convert_Click(object sender, EventArgs e)
        {
            String Path = "";

            Path = Tb_FilePath.Text;

            //Code of validation from Tb_FilePath


            string[] arquivos = Directory.GetFiles(Path);

            //Code from Foreach



            ListViewItem item = new ListViewItem(Tb_FilePath.Text);
            listView1.Items.Add(item);

        }

        private void ValidatEncrypt(String path, String arquivos)
        {
            String TypeFrom, TypeTo;

            if(Cb_From.Text == "ANSI")
            {
                TypeFrom = File.ReadAllText(Cb_From.Text, Encoding.Default);
            }
            if(Cb_From.Text == "UTF-16 LE")
            {
                TypeFrom = File.ReadAllText(Cb_From.Text, Encoding.Unicode);
            }
            if (Cb_From.Text == "UTF-8 with BOM")
            {
                TypeFrom = File.ReadAllText(arquivos, new UTF8Encoding(true));
            }
            if (Cb_From.Text == "UTF-8")
            {
                TypeFrom = File.ReadAllText(Cb_From.Text, Encoding.UTF8);
            }

        }

            




    }
}
