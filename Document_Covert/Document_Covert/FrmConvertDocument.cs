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

        Boolean Valid = false;
        String Path = "";

        private void Bt_Convert_Click(object sender, EventArgs e)
        {

            Path = Tb_FilePath.Text;
            
            Lv_Modificated.Items.Clear();

            ValidData(Path, Valid);
            if (Valid == false) return;

            if(Directory.Exists(Path))
            {
                Encrypth(Path);

            }
            else
            {
                Ep_Path.SetError(Tb_FilePath, "Invalidated file path. Select a validated file path");
                return;
            }
            Valid = false;
        }

        private void Encrypth(string Directorys)
        {
            String[] File = Directory.GetFiles(Directorys);

            foreach (string FilePath in File)
            {
                string Content = "";

                ReadTypeEncrypt(FilePath, Content);

                WriteTypeEncrypt(FilePath, Content);

                ListViewItem item = new ListViewItem(Content);
                Lv_Modificated.Items.Add(item);
                Content = "";
                //Preciso mudar o Content para Global dentro desse FORM
            }
        }

        private void ReadTypeEncrypt(string filePath, string content)
        {
            if (Cb_To.Text == "ANSI")
            { 
                //Code of Read "ANSI" Encrypt
                using (StreamReader stream = new StreamReader(filePath, Encoding.Default))
                {
                    content = stream.ReadToEnd();
                }
               
            }
            if (Cb_To.Text == "UTF-8")
            {
                //Code of Read "UTF-8" Encrypt
                using (StreamReader stream = new StreamReader(filePath, Encoding.UTF8))
                {
                    content = stream.ReadToEnd();
                }
            }
        }

        //Method for identify type of Encrypth
        private void WriteTypeEncrypt(string filePath, string content)
        {
            if (Cb_From.Text == "ANSI")
            {
                //Code of Write "ANSI" Encrypt
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.Default))
                {
                    writer.Write(content);
                }

            }
            if (Cb_From.Text == "UTF-8")
            {
                //Code of Write "UTF-8" Encrypt
                using (StreamWriter writer = new StreamWriter(filePath,false, Encoding.UTF8))
                {
                    writer.Write(content);
                }
            }
        }


        private void ValidData(String path, Boolean valid)
        {
        
            if(Cb_From.Text == "")
            {
                Ep_From.SetError(Cb_From, "Select Encrypth");
            }
            if(Cb_To.Text == "")
            {
                Ep_To.SetError(Cb_To, "Select Encrypth");
            }
            else if(Tb_FilePath.Text == "")
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    Path = folderBrowser.SelectedPath;
                    Tb_FilePath.Text = Path;
                    Valid = true;
                    return;
                }
                Valid = false;
                return;
            }
            Valid = true;
            return;
        }
    }
}
