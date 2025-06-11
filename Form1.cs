using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace ZeroClutter
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void prefetch_Click(object sender, EventArgs e)
        {

            string[] filePaths = Directory.GetFiles("C:\\Windows\\Prefetch");

            foreach (string filePath in filePaths)
            {

                File.Delete(filePath);

            }

            prefetch.Enabled = false; prefetch.ResetText(); prefetch.Text = "Done";

        }
        private void tempfolder_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles("C:\\Windows\\Temp");

            foreach (string filePath in filePaths)
            {
                File.Delete(filePath);

            }

            tempfolder.Enabled = false; tempfolder.ResetText(); tempfolder.Text = "Done";


        }
        private void recyclebin_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles("C:\\$Recycle.Bin");
            

            foreach (string filePath in filePaths)
            {
                File.Delete(filePath);

            }

            recyclebin.Enabled = false; recyclebin.ResetText(); recyclebin.Text = "Done";

        }
        private void programs_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("Control.exe");

        }
       
        
   

        private void exit_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
        private void about_Click(object sender, EventArgs e)

            
        {
            Form aboutform = new Form();

            RichTextBox aboutthisprogram = new RichTextBox();

            aboutform.Show();

            aboutform.Name = "About";
            aboutform.Text = "About Zero Clutter";
            aboutform.Location = new Point(300, 250);
            aboutform.Size = new Size(550, 350);
            aboutform.ShowInTaskbar = true;
            aboutform.Controls.Add(aboutthisprogram);

            
            aboutthisprogram.Text = "Zero Clutter \n " +
            "Zero Clutter removes many of the files you would much rather not want to deal with, with a few clicks." +
            "\bVisit my Github for more: github.com/David8861.\n";
            aboutthisprogram.Name = "About";
            aboutthisprogram.Size = new Size(535, 340);
            aboutthisprogram.ReadOnly = true;
            aboutthisprogram.Show();
            aboutthisprogram.SelectionProtected = true;

        }

        
    }
}
