using System.Drawing.Printing;
using System.Net;

namespace ZeroClutter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            eventviewer = new Button();
            programs = new Button();
            recyclebin = new Button();
            prefetch = new Button();
            tempfolder = new Button();
            saver = new Button();
            about = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // eventviewer
            // 
            eventviewer.BackgroundImage = (Image)resources.GetObject("eventviewer.BackgroundImage");
            eventviewer.BackgroundImageLayout = ImageLayout.Stretch;
            eventviewer.FlatStyle = FlatStyle.Flat;
            eventviewer.Font = new Font("Lato Semibold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventviewer.Image = (Image)resources.GetObject("eventviewer.Image");
            eventviewer.Location = new Point(233, 178);
            eventviewer.Name = "eventviewer";
            eventviewer.Padding = new Padding(10);
            eventviewer.Size = new Size(215, 134);
            eventviewer.TabIndex = 1;
            eventviewer.Text = "Event Viewer";
            eventviewer.TextImageRelation = TextImageRelation.ImageAboveText;
            eventviewer.Click += eventviewer_Click;
            // 
            // programs
            // 
            programs.BackgroundImage = (Image)resources.GetObject("programs.BackgroundImage");
            programs.BackgroundImageLayout = ImageLayout.Stretch;
            programs.FlatStyle = FlatStyle.Flat;
            programs.Font = new Font("Lato Semibold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            programs.Image = (Image)resources.GetObject("programs.Image");
            programs.Location = new Point(12, 178);
            programs.Name = "programs";
            programs.Padding = new Padding(10);
            programs.Size = new Size(215, 134);
            programs.TabIndex = 1;
            programs.Text = "Uninstall a Program\n";
            programs.TextImageRelation = TextImageRelation.ImageAboveText;
            programs.Click += programs_Click;
            // 
            // recyclebin
            // 
            recyclebin.BackColor = Color.Black;
            recyclebin.BackgroundImage = (Image)resources.GetObject("recyclebin.BackgroundImage");
            recyclebin.BackgroundImageLayout = ImageLayout.Stretch;
            recyclebin.FlatStyle = FlatStyle.Flat;
            recyclebin.Font = new Font("Lato Semibold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recyclebin.ForeColor = Color.Black;
            recyclebin.Image = (Image)resources.GetObject("recyclebin.Image");
            recyclebin.Location = new Point(455, 30);
            recyclebin.Name = "recyclebin";
            recyclebin.Padding = new Padding(10);
            recyclebin.Size = new Size(215, 134);
            recyclebin.TabIndex = 1;
            recyclebin.Text = "Clean Recycle Bin";
            recyclebin.TextImageRelation = TextImageRelation.ImageAboveText;
            recyclebin.UseVisualStyleBackColor = false;
            recyclebin.Click += recyclebin_Click;
            // 
            // prefetch
            // 
            prefetch.BackColor = Color.Black;
            prefetch.BackgroundImage = (Image)resources.GetObject("prefetch.BackgroundImage");
            prefetch.BackgroundImageLayout = ImageLayout.Stretch;
            prefetch.FlatStyle = FlatStyle.Flat;
            prefetch.Font = new Font("Lato Semibold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prefetch.Image = (Image)resources.GetObject("prefetch.Image");
            prefetch.Location = new Point(12, 30);
            prefetch.Name = "prefetch";
            prefetch.Padding = new Padding(10);
            prefetch.Size = new Size(215, 134);
            prefetch.TabIndex = 0;
            prefetch.Text = "Clean Prefetch";
            prefetch.TextImageRelation = TextImageRelation.ImageAboveText;
            prefetch.UseVisualStyleBackColor = false;
            prefetch.Click += prefetch_Click;
            // 
            // tempfolder
            // 
            tempfolder.BackColor = Color.Black;
            tempfolder.BackgroundImage = (Image)resources.GetObject("tempfolder.BackgroundImage");
            tempfolder.BackgroundImageLayout = ImageLayout.Stretch;
            tempfolder.FlatStyle = FlatStyle.Flat;
            tempfolder.Font = new Font("Lato Semibold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tempfolder.ForeColor = Color.Black;
            tempfolder.Image = (Image)resources.GetObject("tempfolder.Image");
            tempfolder.Location = new Point(233, 30);
            tempfolder.Name = "tempfolder";
            tempfolder.Padding = new Padding(10);
            tempfolder.Size = new Size(215, 134);
            tempfolder.TabIndex = 0;
            tempfolder.Text = "Clean Temp";
            tempfolder.TextImageRelation = TextImageRelation.ImageAboveText;
            tempfolder.UseVisualStyleBackColor = false;
            tempfolder.Click += tempfolder_Click;
            // 
            // saver
            // 
            saver.BackColor = Color.Transparent;
            saver.BackgroundImage = (Image)resources.GetObject("saver.BackgroundImage");
            saver.BackgroundImageLayout = ImageLayout.Stretch;
            saver.FlatStyle = FlatStyle.Flat;
            saver.Font = new Font("Lato Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saver.ForeColor = Color.Black;
            saver.Image = (Image)resources.GetObject("saver.Image");
            saver.ImageAlign = ContentAlignment.TopCenter;
            saver.Location = new Point(455, 178);
            saver.Name = "saver";
            saver.Padding = new Padding(10);
            saver.Size = new Size(215, 84);
            saver.TabIndex = 1;
            saver.Text = "Save Report";
            saver.TextAlign = ContentAlignment.BottomCenter;
            saver.UseVisualStyleBackColor = false;
            saver.Click += saver_Click;
            // 
            // about
            // 
            about.BackgroundImage = (Image)resources.GetObject("about.BackgroundImage");
            about.BackgroundImageLayout = ImageLayout.Stretch;
            about.FlatStyle = FlatStyle.Flat;
            about.Font = new Font("Lato Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            about.Image = (Image)resources.GetObject("about.Image");
            about.Location = new Point(455, 268);
            about.Name = "about";
            about.Size = new Size(107, 44);
            about.TabIndex = 2;
            about.TextAlign = ContentAlignment.BottomCenter;
            about.TextImageRelation = TextImageRelation.ImageAboveText;
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // exit
            // 
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Lato Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Image = (Image)resources.GetObject("exit.Image");
            exit.Location = new Point(568, 268);
            exit.Name = "exit";
            exit.Size = new Size(102, 44);
            exit.TabIndex = 3;
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(684, 361);
            Controls.Add(exit);
            Controls.Add(about);
            Controls.Add(saver);
            Controls.Add(tempfolder);
            Controls.Add(eventviewer);
            Controls.Add(programs);
            Controls.Add(recyclebin);
            Controls.Add(prefetch);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(960, 540);
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "Form1";
            Text = "Zero Clutter";
            ResumeLayout(false);
        }



        Button prefetch, tempfolder, recyclebin, programs, eventviewer, saver; 
        private Button about, exit;
        
    }
}
