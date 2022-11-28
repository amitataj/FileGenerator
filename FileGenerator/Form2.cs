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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string str = @"using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TLM.Domain.Schedules.Models;
using TLM.Application.Models.Schedules;

namespace TLM.Application.Mappings
{
    public class CommonMapping : Profile
    {
        public CommonMapping()
        {
            //create your mapping here 

            CreateMap<SchedulesQueryModel, SchedulesRequest>();

            CreateMap<SchedulesResponse, SchedulesViewModel>();

            CreateMap<SchedulesDomainResponseDto, SchedulesApplicationResponseDto>();
        }
    }
}";
                string strApplicationModels = @"C:\\src\application\TLM.Application\\Mappings\CommonMappings\\";
                string strApplicationModelsIncludeFile = @"C:\\src\application\TLM.Application\\Mappings\CommonMappings\\CommonMappings.cs";

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

                    str = str.Replace("Schedules", textBox1.Text);
                    sw.WriteLine(str);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TLM.Domain.Slot.Models.Slot

            try
            {
                string strModelClassName = textBox1.Text + ".cs";
                string strModelFolder = textBox1.Text;
                string strDomainModels = @"C:\\src\domain\TLM.Domain."+ strModelFolder + "\\Models\\" + strModelFolder + "\\";
                string strDomainModelsIncludeFile = strDomainModels + "\\" + strModelClassName;

                // Check if file already exists. If yes, delete it.

                if (Directory.Exists(strDomainModels))
                {
                    Directory.Delete(strDomainModels);
                }
                else
                {
                    Directory.CreateDirectory(strDomainModels);
                }


                FileInfo fi = new FileInfo(strDomainModelsIncludeFile);
                // Check if file already exists. If yes, delete it.     
                if (fi.Exists)
                {
                    fi.Delete();
                }

                // Create a new file     
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine(txtBoxDomain.Text);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }


            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TLM.Domain.Slot.Models.Slot

            try
            {
                string strModelClassName = textBox1.Text + "RequestRequestResourceDto.cs";
                string strModelFolder = textBox1.Text;
                string strDomainModels = @"C:\\src\resource\TLM.Resource." + strModelFolder + "\\Models\\" + strModelFolder + "\\";
                string strDomainModelsIncludeFile = strDomainModels + "\\" + strModelClassName;

                // Check if file already exists. If yes, delete it.

                if (Directory.Exists(strDomainModels))
                {
                    Directory.Delete(strDomainModels);
                }
                else
                {
                    Directory.CreateDirectory(strDomainModels);
                }


                FileInfo fi = new FileInfo(strDomainModelsIncludeFile);
                // Check if file already exists. If yes, delete it.     
                if (fi.Exists)
                {
                    fi.Delete();
                }

                // Create a new file     
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine(txtBoxResource.Text);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
