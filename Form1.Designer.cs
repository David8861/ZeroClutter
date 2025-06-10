using System.Drawing.Printing;

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
            prefetch = new Button();
            topbar = new ToolStrip();
            
            about = new ToolStripMenuItem();
            topbar.SuspendLayout();
            SuspendLayout();
            // 
            // prefetch
            // 
            
            prefetch.FlatStyle = FlatStyle.System;
            prefetch.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prefetch.Location = new Point(50, 30);
            prefetch.Name = "prefetch";
            prefetch.Padding = new Padding(10, 10, 10, 10);
            prefetch.Size = new Size(180, 120);
            prefetch.TabIndex = 0;
            prefetch.Text = "Clean Prefetch";
            
            // 
            // topbar
            // 
            topbar.Dock = DockStyle.Bottom;
            topbar.Items.AddRange(new ToolStripItem[] { about });
            topbar.Location = new Point(0, 364);
            topbar.Margin = new Padding(15);
            topbar.Name = "topbar";
            topbar.Padding = new Padding(5, 10, 10, 5);
            topbar.Size = new Size(700, 36);
            topbar.TabIndex = 1;
            
            // 
            // about
            // 
            about.Alignment = ToolStripItemAlignment.Right;
            about.Font = new Font("Nirmala UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            about.Name = "about";
            about.Size = new Size(55, 21);
            about.Text = "About";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            this.MinimumSize = new Size(700, 400);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(700, 400);
            Controls.Add(prefetch);
            Controls.Add(topbar);
            Name = "Form1";
            Text = "Zero Clutter";
            topbar.ResumeLayout(false);
            topbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        ToolStripMenuItem about;
        Button prefetch;
        ToolStrip topbar;
        
    }
}
