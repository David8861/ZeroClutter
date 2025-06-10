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

            TextBox finishedprefetch = new TextBox();
            Form form = new Form();
            form.ShowInTaskbar = false;
            form.Show();
            
            form.Name = "Done";
            form.Text = "Done";
            form.Size = new Size(100, 75);
            this.Visible = true;
            form.Controls.Add(finishedprefetch);

            finishedprefetch.Text = "Done!";
            finishedprefetch.TextAlign = HorizontalAlignment.Center;
            finishedprefetch.Enabled = true;
            finishedprefetch.Size = new Size(90, 60);
            finishedprefetch.BorderStyle = BorderStyle.FixedSingle;
            finishedprefetch.TabIndex = 0;
            finishedprefetch.ReadOnly = true;

            prefetch.Enabled = false;

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
            " Zero Clutter removes all the annoying files you would much rather not want to deal with.\n";
            aboutthisprogram.Name = "About";
            aboutthisprogram.Size = new Size(535, 340);
            aboutthisprogram.ReadOnly = true;
            aboutthisprogram.Show();
            aboutthisprogram.SelectionProtected = true;

        }

        
    }
}
