namespace ZeroClutter
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        }

        private void prefetch_Click(object sender, EventArgs e)
        {

            string[] filePaths = Directory.GetFiles("C:\\Windows\\Prefetch");

            foreach (string filePath in filePaths)
            {

                File.Delete(filePath);

            }

            prefetch.Enabled = false; prefetch.ResetText(); prefetch.Text = "Cleaned";

        }
        private void tempfolder_Click(object sender, EventArgs e)
        {

            if (Directory.Exists("C:\\Windows\\Temp"))
            {

                string[] DirPaths = Directory.GetDirectories("C:\\Windows\\Temp");

                if (Directory.Exists("C:\\TempDelete"))
                {
                    Directory.Delete("C:\\TempDelete", true);
                }
                else
                {
                    Directory.Move("C:\\Windows\\Temp", "C:\\TempDelete");

                }

                Directory.Delete("C:\\TempDelete", true);
            }

            if (Directory.Exists("C:\\TempDelete"))
            {

                Directory.Delete("C:\\TempDelete", true);

                Directory.CreateDirectory("C:\\TempDelete");

                Directory.Exists("C:\\Windows\\Temp");

                if (Directory.Exists("C:\\Windows\\Temp"))
                {
                    string[] DirPaths = Directory.GetDirectories("C:\\Windows\\Temp");

                    Directory.Move("C:\\Windows\\Temp", "C:\\TempDelete");

                    foreach (string DirPath in DirPaths)

                    {
                        File.Delete(DirPath);
                    }

                    Directory.Delete("C:\\TempDelete", true);
                }

            }



            tempfolder.Enabled = false; tempfolder.ResetText(); tempfolder.Text = "Cleaned";


        }
        private void recyclebin_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles("C:\\$RECYCLE.BIN");

            foreach (string filePath in filePaths)
            {
                File.Delete(filePath);

            }

            recyclebin.Enabled = false; recyclebin.Text = "Cleaned";

        }
        private void programs_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("Control.exe");

        }
        private void eventviewer_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("C:\\Windows\\System32\\eventvwr.exe");

        }

        private void saver_Click(object sender, EventArgs e)
        {


            if (Directory.Exists("C:\\ZeroClutter"))
            {
                File.Delete("C:\\ZeroClutter\\SaveReport.txt");

                Directory.Delete("C:\\ZeroClutter");

                Directory.CreateDirectory("C:\\ZeroClutter");


                File.WriteAllText("C:\\ZeroClutter\\SaveReport.txt", "You cleaned Prefetch, Temp, and Recycle Bin.");

                saver.Enabled = false; saver.ResetText(); saver.Text = "Saved";
            }
            else
            {

                Directory.CreateDirectory("C:\\ZeroClutter");

                File.WriteAllText("C:\\ZeroClutter\\SaveReport.txt", "You cleaned Prefetch, Temp, and Recycle Bin.");

                saver.Enabled = false; saver.ResetText(); saver.Text = "Saved";
            }

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
            aboutform.Icon = Icon;
            aboutform.ShowIcon = true;
            aboutform.ShowInTaskbar = true;
            aboutform.Name = "about";
            aboutform.Text = "About";
            aboutform.Location = new Point(300, 250);
            aboutform.Size = new Size(550, 350);
            aboutform.MaximumSize = new Size(550, 350);
            aboutform.MinimumSize = new Size(550, 350);
            aboutform.ShowInTaskbar = true;
            aboutform.Controls.Add(aboutthisprogram);

            aboutthisprogram.ForeColor = Color.White;
            aboutthisprogram.Text = "Zero Clutter\n " +
            "\nZero Clutter is a lightweight, simple file remover tool (with some built-in maintenance functions). Zero Clutter enables you to jump to important applications, clean files, and save a report to your drive.\n" +
            "\nZeroClutter works in both x64/x86 architecture.\n" + "\nVisit my Github for more: github.com/David8861.\n";
            aboutthisprogram.WordWrap = true;
            aboutthisprogram.Name = "About";
            aboutthisprogram.Size = new Size(535, 340);
            aboutthisprogram.ReadOnly = true;
            aboutthisprogram.SelectionProtected = true;
            aboutthisprogram.Show();
            aboutthisprogram.BackColor = Color.FromArgb(45, 47, 48);

        }


    }
}
