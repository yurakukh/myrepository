using System;
using System.Xml.Linq;
using System.Drawing;
using System.IO;

using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Runtime.CompilerServices;

namespace work_with_the_register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (radioButton1.Checked) SaveToXML();
            else if (radioButton2.Checked) SaveToTxt();
            else if (radioButton3.Checked) SaveToBinary();
            else SaveToRegistry();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //different ways to read params
            //ReadFromXML();
            //ReadFromTxt();
            //ReadFromBinary();
            ReadFromRegistry();
        }



        //functions to save and restore parameters
        private void SaveToTxt()
        {
            string writePath = @".\params.txt";


            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(this.Location.X);
                    sw.WriteLine(this.Location.Y);
                    sw.WriteLine(this.Width);
                    sw.WriteLine(this.Height);
                    sw.WriteLine(this.textBox1.Text);
                    sw.WriteLine(this.checkBox1.Checked);
                    sw.WriteLine(this.checkBox2.Checked);
                    sw.WriteLine(this.radioButton1.Checked);
                    sw.WriteLine(this.radioButton2.Checked);
                    sw.WriteLine(this.radioButton3.Checked);
                    sw.WriteLine(this.radioButton4.Checked);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadFromTxt()
        {
            string readPath = @".\params.txt";
            var file = new FileInfo(readPath);
            if (file.Exists && file.Length != 0)
            {


                try
                {
                    using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                    {
                        this.Location = new Point(Convert.ToInt32(sr.ReadLine()), Convert.ToInt32(sr.ReadLine()));
                        this.Width = Convert.ToInt32(sr.ReadLine());
                        this.Height = Convert.ToInt32(sr.ReadLine());
                        this.textBox1.Text = sr.ReadLine();
                        this.checkBox1.Checked = Convert.ToBoolean(sr.ReadLine());
                        this.checkBox2.Checked = Convert.ToBoolean(sr.ReadLine());

                        this.radioButton1.Checked = Convert.ToBoolean(sr.ReadLine());
                        this.radioButton2.Checked = Convert.ToBoolean(sr.ReadLine());
                        this.radioButton3.Checked = Convert.ToBoolean(sr.ReadLine());
                        this.radioButton4.Checked = Convert.ToBoolean(sr.ReadLine());

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

     
        private void SaveToXML()
        {
            

            try
            {

                var xmlDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("Parameters",
                        new XElement("X", this.Location.X),
                        new XElement("Y", this.Location.Y),
                        new XElement("Width", this.Width),
                        new XElement("Height", this.Height),
                        new XElement("Text", this.textBox1.Text),
                        new XElement("checkBox_1", this.checkBox1.Checked),
                        new XElement("checkBox_2", this.checkBox2.Checked),
                        new XElement("rb_1", this.radioButton1.Checked),
                        new XElement("rb_2", this.radioButton2.Checked),
                        new XElement("rb_3", this.radioButton3.Checked),
                        new XElement("rb_4", this.radioButton3.Checked)
                    ));


                //save it to the current directory
                xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, "xmlParams.xml"));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadFromXML()
        {

            string xmlPath = @".\xmlParams.xml";
            var file = new FileInfo(xmlPath);
            if (file.Exists && file.Length != 0)
            {
                XmlTextReader reader = new XmlTextReader(xmlPath);
                reader.ReadToFollowing("Parameters");
                reader.MoveToFirstAttribute();

                //location
                reader.ReadToFollowing("X");
                Point p = new Point();
                p.X = Convert.ToInt32(reader.ReadElementContentAsString());

                reader.ReadToFollowing("Y");
                p.Y = Convert.ToInt32(reader.ReadElementContentAsString());

                this.Location = p;

                //sizes
                Size s = new Size();

                reader.ReadToFollowing("Width");
                s.Width = Convert.ToInt32(reader.ReadElementContentAsString());
                reader.ReadToFollowing("Height");
                s.Height = Convert.ToInt32(reader.ReadElementContentAsString());

                this.Size = s;

                //text
                reader.ReadToFollowing("Text");
                this.textBox1.Text = reader.ReadElementContentAsString();

                //checkboxes
                reader.ReadToFollowing("checkBox_1");
                this.checkBox1.Checked = Convert.ToBoolean(reader.ReadElementContentAsString());
                reader.ReadToFollowing("checkBox_2");
                this.checkBox2.Checked = Convert.ToBoolean(reader.ReadElementContentAsString());

                //radio
                reader.ReadToFollowing("rb_1");
                this.radioButton1.Checked = Convert.ToBoolean(reader.ReadElementContentAsString());
                reader.ReadToFollowing("rb_2");
                this.radioButton2.Checked = Convert.ToBoolean(reader.ReadElementContentAsString());
                reader.ReadToFollowing("rb_3");
                this.radioButton3.Checked = Convert.ToBoolean(reader.ReadElementContentAsString());
                reader.ReadToFollowing("rb_4");
                this.radioButton4.Checked = Convert.ToBoolean(reader.ReadElementContentAsString());
                reader.Close();

                file.Delete();
            }
        }


        private void SaveToBinary()
        {
            string writePath = @".\params.dat";

            try
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(writePath, FileMode.OpenOrCreate)))
                {
                    bw.Write(this.Location.X);
                    bw.Write(this.Location.Y);
                    bw.Write(this.Width);
                    bw.Write(this.Height);
                    bw.Write(this.textBox1.Text);
                    bw.Write(this.checkBox1.Checked);
                    bw.Write(this.checkBox2.Checked);
                    bw.Write(this.radioButton1.Checked);
                    bw.Write(this.radioButton2.Checked);
                    bw.Write(this.radioButton3.Checked);
                    bw.Write(this.radioButton4.Checked);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadFromBinary()
        {
            string readPath = @".\params.dat";
            FileInfo file = new FileInfo(readPath);
            if (file.Exists && file.Length != 0)
            {
                try
                {
                    using (BinaryReader br = new BinaryReader(File.Open(readPath, FileMode.Open)))
                    {
                        while (br.PeekChar() > -1)
                        {
                            Point p = new Point(br.ReadInt32(), br.ReadInt32());
                            this.Width = br.ReadInt32();
                            this.Height = br.ReadInt32();
                            this.textBox1.Text = br.ReadString();
                            this.checkBox1.Checked = br.ReadBoolean();
                            this.checkBox2.Checked = br.ReadBoolean();
                            this.radioButton1.Checked = br.ReadBoolean();
                            this.radioButton2.Checked = br.ReadBoolean();
                            this.radioButton3.Checked = br.ReadBoolean();
                            this.radioButton4.Checked = br.ReadBoolean();
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveToRegistry()
        {
            RegistryKey currentUser = Registry.CurrentUser;
            RegistryKey paramsKey = currentUser.CreateSubKey("Parameters");

            paramsKey.SetValue("X", this.Location.X);
            paramsKey.SetValue("Y", this.Location.Y);
            paramsKey.SetValue("Width", this.Width);
            paramsKey.SetValue("Height", this.Height);
            paramsKey.SetValue("Text", this.textBox1.Text);
            paramsKey.SetValue("checkBox_1", this.checkBox1.Checked);
            paramsKey.SetValue("checkBox_2", this.checkBox2.Checked);
            paramsKey.SetValue("rb_1", this.radioButton1.Checked);
            paramsKey.SetValue("rb_2", this.radioButton2.Checked);
            paramsKey.SetValue("rb_3", this.radioButton3.Checked);
            paramsKey.SetValue("rb_4", this.radioButton4.Checked);
            
            paramsKey.Close();
        }

        private void ReadFromRegistry()
        {
            try
            {
                RegistryKey paramsKey = Registry.CurrentUser.CreateSubKey("Parameters");
                if (paramsKey.ValueCount != 0)
                {
                    Point p = new Point();
                    p.X = Convert.ToInt32(paramsKey.GetValue("X"));
                    p.Y = Convert.ToInt32(paramsKey.GetValue("Y"));
                    this.Location = p;
                    this.Width = Convert.ToInt32(paramsKey.GetValue("Width"));
                    this.Height = Convert.ToInt32(paramsKey.GetValue("Height"));
                    this.Text = paramsKey.GetValue("Text").ToString();
                    this.checkBox1.Checked = Convert.ToBoolean(paramsKey.GetValue("checkBox_1"));
                    this.checkBox2.Checked = Convert.ToBoolean(paramsKey.GetValue("checkBox_2"));
                    this.radioButton1.Checked = Convert.ToBoolean(paramsKey.GetValue("rb_1"));
                    this.radioButton2.Checked = Convert.ToBoolean(paramsKey.GetValue("rb_2"));
                    this.radioButton3.Checked = Convert.ToBoolean(paramsKey.GetValue("rb_3"));
                    this.radioButton4.Checked = Convert.ToBoolean(paramsKey.GetValue("rb_4"));

                    //close
                    paramsKey.Close();
                    Registry.CurrentUser.DeleteSubKey("Parameters");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
