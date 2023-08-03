using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileInputOutput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder is already exists:");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\doc1.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File is already Exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File is created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.dat";

                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(textpid.Text));
                binaryWriter.Write(textpname.Text);
                binaryWriter.Write(Convert.ToDouble(textpprice.Text));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Done");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
         }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DP4-2-August\Product.dat";

                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                textpid.Text = binaryReader.ReadInt32().ToString();
                textpname.Text = binaryReader.ToString();
                textpprice.Text=binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();
              //  MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

