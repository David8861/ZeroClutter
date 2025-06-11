using Microsoft.VisualBasic;
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
        private void mydownloads_Click(object sender, EventArgs e)
        {
            Form downloadquestion = new Form();
            
            Button accept = new Button();
            Button cancel = new Button();

            downloadquestion.Name = "Clear Downloads?";
            downloadquestion.Text = "Clear Downloads?";
            downloadquestion.Size = new Size(280, 100);
            downloadquestion.Location = new Point(125, 100);
            downloadquestion.Enabled = true;
            downloadquestion.MaximumSize = new Size(280, 100);
            downloadquestion.MinimumSize = new Size(280, 100);
            downloadquestion.Controls.Add(accept);
            downloadquestion.Controls.Add(cancel);
            
            this.AcceptButton = accept;
            accept.Location = new Point(35, 5);
            accept.Size = new Size(100, 45);
            accept.Enabled = true;
            accept.Visible = true;
            accept.Text = "Accept";

            this.CancelButton = cancel;
            cancel.Location = new Point(135, 5);
            cancel.Size = new Size(100, 45);
            cancel.Enabled = true;
            cancel.Visible = true;
            cancel.Text = "Cancel";

            downloadquestion.Show();
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
