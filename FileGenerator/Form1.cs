using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fileName = @"C:\Temp\Mahesh.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                    fs.Write(author, 0, author.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Temp\MaheshTX.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Author: Mahesh Chand");
                    sw.WriteLine("Add one more line ");
                    sw.WriteLine("Add one more line ");
                    sw.WriteLine("Done! ");
                }

                // Write file contents on console.     
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Temp\MaheshTXFI.txt";
            FileInfo fi = new FileInfo(fileName);

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (fi.Exists)
                {
                    fi.Delete();
                }

                // Create a new file     
                using (FileStream fs = fi.Create())
                {
                    Byte[] txt = new UTF8Encoding(true).GetBytes("New file.");
                    fs.Write(txt, 0, txt.Length);
                    Byte[] author = new UTF8Encoding(true).GetBytes("Author Mahesh Chand");
                    fs.Write(author, 0, author.Length);
                }

                // Write file contents on console.     
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Temp\MaheshTXFITx.txt";
            FileInfo fi = new FileInfo(fileName);

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (fi.Exists)
                {
                    fi.Delete();
                }

                // Create a new file     
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Author: Mahesh Chand");
                    sw.WriteLine("Add one more line ");
                    sw.WriteLine("Add one more line ");
                    sw.WriteLine("Done! ");
                }

                // Write file contents on console.     
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string fileName = @"C:\Temp\Mahesh.txt";

            try
            {
                string strModelClassName = textBox1.Text + ".cs";
                string strModelFolder = textBox1.Text;
                string strApplicationModels = @"C:\\src\application\TLM.Application.Models\" + strModelFolder + "\\";
                string strApplicationModelsIncludeFile = strApplicationModels + "\\" + strModelClassName;

                // Check if file already exists. If yes, delete it.

                if (Directory.Exists(strApplicationModels))
                {
                    Directory.Delete(strApplicationModels);
                }
                else
                {
                    Directory.CreateDirectory(strApplicationModels);
                }

                if (File.Exists(strApplicationModelsIncludeFile))
                {
                    File.Delete(strApplicationModelsIncludeFile);
                }
                else
                {
                    File.Create(strApplicationModelsIncludeFile);

                }

                // Create a new file     
                using (FileStream fs = File.Create(strApplicationModelsIncludeFile))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(txtModel.Text);
                    fs.Write(title, 0, title.Length);
                    //byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                    //fs.Write(author, 0, author.Length);
                }

                //// Open the stream and read it back.    
                //using (StreamReader sr = File.OpenText(fileName))
                //{
                //    string s = "";
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {            
            try
            {
                string strModelClassName = textBox1.Text + ".cs";
                string strModelFolder = textBox1.Text;
                string strApplicationModels = @"C:\\src\application\TLM.Application.Models\" + strModelFolder + "\\";
                string strApplicationModelsIncludeFile = strApplicationModels + "\\" + strModelClassName;

                // Check if file already exists. If yes, delete it.

                if (Directory.Exists(strApplicationModels))
                {
                    Directory.Delete(strApplicationModels);
                }
                else
                {
                    Directory.CreateDirectory(strApplicationModels);
                }


                FileInfo fi = new FileInfo(strApplicationModelsIncludeFile);
                // Check if file already exists. If yes, delete it.     
                if (fi.Exists)
                {
                    fi.Delete();
                }

                // Create a new file     
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine(txtModel.Text);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
