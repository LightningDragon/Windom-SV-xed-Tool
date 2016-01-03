﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WindomSVXedTool
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            //AllocConsole();
            InitializeComponent();
           
            
            
        }

        //[System.Runtime.InteropServices.DllImport("kernel32.dll")]
        //private static extern bool AllocConsole();

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                FileInfo f = new FileInfo(txtFile.Text);
                
                switch(f.Extension)
                {
                    case ".xed":
                        XedDecrypt xd = new XedDecrypt();
                        xd.Decrypt(txtFile.Text,txtName.Text); 
                        break;
                    case ".txt":
                        XedEncrypt xe = new XedEncrypt();
                        xe.Encrypt(txtFile.Text, f.DirectoryName,txtName.Text);
                        break;
                    default:
                        MessageBox.Show("Error: Invalid File Type");
                        break;
                }
        //}
            //catch
            //{
            //    MessageBox.Show("Error 2: Invalid File Type");
            //}

   

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "supported Files (*.xed;*.txt)|*.xed;*.txt";
            browseFile.Title = "Browse for xed or txt File";
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return;

            txtFile.Text = browseFile.FileName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
