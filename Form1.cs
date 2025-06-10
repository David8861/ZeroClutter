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

            Form messenger = new Form();
            messenger.ShowDialog();
            messenger.Text = "Done!";
            
            messenger.Enabled = true;
            messenger.Visible = true;

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
