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
            topbar = new ToolStrip();
            exit = new ToolStripMenuItem();
            about = new ToolStripMenuItem();
            saver = new Button();
            topbar.SuspendLayout();
            SuspendLayout();
            // 
            // eventviewer
            // 
            eventviewer.FlatStyle = FlatStyle.System;
            eventviewer.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventviewer.Location = new Point(233, 203);
            eventviewer.Name = "eventviewer";
            eventviewer.Padding = new Padding(10);
            eventviewer.Size = new Size(216, 104);
            eventviewer.TabIndex = 1;
            eventviewer.Text = "Event Viewer";
            eventviewer.Click += eventviewer_Click;
            // 
            // programs
            // 
            programs.FlatStyle = FlatStyle.System;
            programs.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programs.Location = new Point(12, 203);
            programs.Name = "programs";
            programs.Padding = new Padding(10);
            programs.Size = new Size(215, 104);
            programs.TabIndex = 1;
            programs.Text = "Uninstall a Program\n";
            programs.Click += programs_Click;
            // 
            // recyclebin
            // 
            recyclebin.FlatStyle = FlatStyle.System;
            recyclebin.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recyclebin.Location = new Point(452, 30);
            recyclebin.Name = "recyclebin";
            recyclebin.Padding = new Padding(10);
            recyclebin.Size = new Size(220, 160);
            recyclebin.TabIndex = 1;
            recyclebin.Text = "Clean Recycle Bin";
            recyclebin.Click += recyclebin_Click;
            // 
            // prefetch
            // 
            prefetch.FlatStyle = FlatStyle.System;
            prefetch.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prefetch.Location = new Point(12, 30);
            prefetch.Name = "prefetch";
            prefetch.Padding = new Padding(10);
            prefetch.Size = new Size(215, 160);
            prefetch.TabIndex = 0;
            prefetch.Text = "Clean Prefetch";
            prefetch.Click += prefetch_Click;
            // 
            // tempfolder
            // 
            tempfolder.FlatStyle = FlatStyle.System;
            tempfolder.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempfolder.Location = new Point(233, 30);
            tempfolder.Name = "tempfolder";
            tempfolder.Padding = new Padding(10);
            tempfolder.Size = new Size(216, 160);
            tempfolder.TabIndex = 0;
            tempfolder.Text = "Clean Temp";
            tempfolder.Click += tempfolder_Click;
            // 
            // topbar
            // 
            topbar.Dock = DockStyle.Bottom;
            topbar.Items.AddRange(new ToolStripItem[] { exit, about });
            topbar.Location = new Point(0, 325);
            topbar.Margin = new Padding(15);
            topbar.Name = "topbar";
            topbar.Padding = new Padding(5, 10, 10, 5);
            topbar.Size = new Size(684, 36);
            topbar.TabIndex = 1;
            // 
            // exit
            // 
            exit.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Name = "exit";
            exit.Size = new Size(40, 21);
            exit.Text = "Exit";
            exit.Click += exit_Click;
            // 
            // about
            // 
            about.Alignment = ToolStripItemAlignment.Right;
            about.Font = new Font("Nirmala UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            about.Name = "about";
            about.Size = new Size(55, 21);
            about.Text = "About";
            
            about.Click += about_Click;
            // 
            // saver
            // 
            saver.FlatStyle = FlatStyle.System;
            saver.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saver.Location = new Point(452, 203);
            saver.Name = "saver";
            saver.Padding = new Padding(10);
            saver.Size = new Size(220, 104);
            saver.TabIndex = 1;
            saver.Text = "Save Report";
            saver.Click += saver_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(684, 361);
            Controls.Add(saver);
            Controls.Add(tempfolder);
            Controls.Add(eventviewer);
            Controls.Add(programs);
            Controls.Add(recyclebin);
            Controls.Add(prefetch);
            Controls.Add(topbar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(960, 540);
            MaximumSize = new Size(700, 400);
            MinimumSize = new Size(700, 400);
            Name = "Form1";
            Text = "Zero Clutter - lightweight file cleaner";
            topbar.ResumeLayout(false);
            topbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        ToolStripMenuItem exit, about;
        Button prefetch, tempfolder, recyclebin, programs, eventviewer, saver; 
        ToolStrip topbar;
        
    }
}
