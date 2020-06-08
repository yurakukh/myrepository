using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files_lab
{
    public partial class Form1 : Form
    {
        DirectoryInfo dr = new DirectoryInfo(@"D:\");
        public Form1()
        {
            InitializeComponent();
        }

        private void create_directories_Click(object sender, EventArgs e)
        {
            string path;
            for (int i = 0; i < 100; i++)
            {
                path = @"D:\Folder_" + i;
                Directory.CreateDirectory(path);
            }
            (sender as Button).Enabled = false;
            this.remove_directories.Enabled = true;
            
        }

        private void remove_directories_Click(object sender, EventArgs e)
        {
            if((sender as Button).Enabled)
            {
                string path;
                for (int i = 0; i < 100; i++)
                {
                    path = @"D:\Folder_" + i;
                    Directory.Delete(path);
                }
                (sender as Button).Enabled = false;
                this.create_directories.Enabled = true;
            }
        }

        private void create_subdirectories_Click(object sender, EventArgs e)
        {
            string path = @"D:";
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    path += @"\" + i;
                    Directory.CreateDirectory(path);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + i + " directories were created. This is the maximum number of subfolders!");
                    break;
                }
            }

            (sender as Button).Enabled = false;
            this.remove_subdirectories.Enabled = true;
        }

        private void remove_subdirectories_Click(object sender, EventArgs e)
        {
            if((sender as Button).Enabled)
            {
                string path = @"D:\0";

                try
                {
                    Directory.Delete(path, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                (sender as Button).Enabled = false;
                this.create_subdirectories.Enabled = true;
            }
        }

        private void findFile_button_Click(object sender, EventArgs e)
        {
            var Y = 10;
            groupBox1.Controls.Clear();
            if (findFile_textBox.Text != "")
            {

                string catalog = Directory.GetCurrentDirectory();
                MessageBox.Show(catalog);

                string fileName = findFile_textBox.Text + ".txt";

                foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName, SearchOption.AllDirectories))
                {
                    MessageBox.Show(findedFile);

                    FileInfo FI;

                    try
                    {
                        FI = new FileInfo(findedFile);
                        


                        Button but = new Button();
                        but.Location = new Point(0, Y);
                        but.Text = FI.FullName;
                        but.TextAlign = ContentAlignment.MiddleLeft;
                        but.Width = groupBox1.Width;
                        Y += 20;
                        groupBox1.Controls.Add(but);

                        //binding a function
                        but.Click += new EventHandler(OpenFilePreview);

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        continue;
                    }

                }

            }
        }


        private void OpenFilePreview(object sender, EventArgs e)
        {
            string path = (sender as Button).Text;
            preview_textBox.Text = "";
            try
            {
                FileStream fstream = File.OpenRead(path);
                byte[] buffer = new byte[fstream.Length];
                fstream.Read(buffer, 0, buffer.Length);

                string text = Encoding.UTF8.GetString(buffer);
                preview_textBox.Text = text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }

        }

    }
}
