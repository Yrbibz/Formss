namespace copiaecola
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rtb1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            apagarToolStripMenuItem = new ToolStripMenuItem();
            rtb2 = new RichTextBox();
            toolTip1 = new ToolTip(components);
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtb1
            // 
            rtb1.ContextMenuStrip = contextMenuStrip1;
            rtb1.Location = new Point(61, 44);
            rtb1.Name = "rtb1";
            rtb1.Size = new Size(738, 194);
            rtb1.TabIndex = 0;
            rtb1.Text = resources.GetString("rtb1.Text");
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem, apagarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 70);
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(112, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(112, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // apagarToolStripMenuItem
            // 
            apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            apagarToolStripMenuItem.Size = new Size(112, 22);
            apagarToolStripMenuItem.Text = "Apagar";
            apagarToolStripMenuItem.ToolTipText = "Isso apagará tudo!";
            apagarToolStripMenuItem.Click += apagarToolStripMenuItem_Click;
            // 
            // rtb2
            // 
            rtb2.ContextMenuStrip = contextMenuStrip1;
            rtb2.Location = new Point(61, 327);
            rtb2.Name = "rtb2";
            rtb2.Size = new Size(738, 192);
            rtb2.TabIndex = 1;
            rtb2.Text = "";
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 571);
            Controls.Add(rtb2);
            Controls.Add(rtb1);
            Name = "Form1";
            Text = "Copia e Cola";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb1;
        private RichTextBox rtb2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem apagarToolStripMenuItem;
        private ToolTip toolTip1;
    }
}