namespace kosci
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodzajGryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wersjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wersjaKarcianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćRundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kostka1 = new System.Windows.Forms.CheckBox();
            this.kostka2 = new System.Windows.Forms.CheckBox();
            this.kostka3 = new System.Windows.Forms.CheckBox();
            this.kostka4 = new System.Windows.Forms.CheckBox();
            this.kostka5 = new System.Windows.Forms.CheckBox();
            this.rzuc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem,
            this.wynikiToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rodzajGryToolStripMenuItem1,
            this.ilośćRundToolStripMenuItem,
            this.toolStripSeparator1,
            this.wyjdźToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // rodzajGryToolStripMenuItem1
            // 
            this.rodzajGryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wersjaToolStripMenuItem,
            this.wersjaKarcianaToolStripMenuItem});
            this.rodzajGryToolStripMenuItem1.Name = "rodzajGryToolStripMenuItem1";
            this.rodzajGryToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rodzajGryToolStripMenuItem1.Text = "Nowa Gra";
            // 
            // wersjaToolStripMenuItem
            // 
            this.wersjaToolStripMenuItem.Name = "wersjaToolStripMenuItem";
            this.wersjaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.wersjaToolStripMenuItem.Text = "Wersja Klasyczna";
            this.wersjaToolStripMenuItem.Click += new System.EventHandler(this.wersjaToolStripMenuItem_Click);
            // 
            // wersjaKarcianaToolStripMenuItem
            // 
            this.wersjaKarcianaToolStripMenuItem.Name = "wersjaKarcianaToolStripMenuItem";
            this.wersjaKarcianaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.wersjaKarcianaToolStripMenuItem.Text = "Wersja Karciana";
            this.wersjaKarcianaToolStripMenuItem.Click += new System.EventHandler(this.wersjaKarcianaToolStripMenuItem_Click);
            // 
            // ilośćRundToolStripMenuItem
            // 
            this.ilośćRundToolStripMenuItem.Name = "ilośćRundToolStripMenuItem";
            this.ilośćRundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ilośćRundToolStripMenuItem.Text = "Ilość Rund";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // wynikiToolStripMenuItem
            // 
            this.wynikiToolStripMenuItem.Name = "wynikiToolStripMenuItem";
            this.wynikiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.wynikiToolStripMenuItem.Text = "Wyniki";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorzyToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // autorzyToolStripMenuItem
            // 
            this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
            this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.autorzyToolStripMenuItem.Text = "Autorzy";
            // 
            // kostka1
            // 
            this.kostka1.Appearance = System.Windows.Forms.Appearance.Button;
            this.kostka1.AutoSize = true;
            this.kostka1.Checked = true;
            this.kostka1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kostka1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kostka1.Image = global::kosci.Properties.Resources._0;
            this.kostka1.Location = new System.Drawing.Point(46, 148);
            this.kostka1.Name = "kostka1";
            this.kostka1.Size = new System.Drawing.Size(125, 126);
            this.kostka1.TabIndex = 2;
            this.kostka1.UseVisualStyleBackColor = true;
            this.kostka1.Visible = false;
            // 
            // kostka2
            // 
            this.kostka2.Appearance = System.Windows.Forms.Appearance.Button;
            this.kostka2.AutoSize = true;
            this.kostka2.Checked = true;
            this.kostka2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kostka2.Image = global::kosci.Properties.Resources._0;
            this.kostka2.Location = new System.Drawing.Point(177, 148);
            this.kostka2.Name = "kostka2";
            this.kostka2.Size = new System.Drawing.Size(125, 126);
            this.kostka2.TabIndex = 3;
            this.kostka2.UseVisualStyleBackColor = true;
            this.kostka2.Visible = false;
            // 
            // kostka3
            // 
            this.kostka3.Appearance = System.Windows.Forms.Appearance.Button;
            this.kostka3.AutoSize = true;
            this.kostka3.Checked = true;
            this.kostka3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kostka3.Image = global::kosci.Properties.Resources._0;
            this.kostka3.Location = new System.Drawing.Point(308, 148);
            this.kostka3.Name = "kostka3";
            this.kostka3.Size = new System.Drawing.Size(125, 126);
            this.kostka3.TabIndex = 4;
            this.kostka3.UseVisualStyleBackColor = true;
            this.kostka3.Visible = false;
            // 
            // kostka4
            // 
            this.kostka4.Appearance = System.Windows.Forms.Appearance.Button;
            this.kostka4.AutoSize = true;
            this.kostka4.Checked = true;
            this.kostka4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kostka4.Image = global::kosci.Properties.Resources._0;
            this.kostka4.Location = new System.Drawing.Point(439, 148);
            this.kostka4.Name = "kostka4";
            this.kostka4.Size = new System.Drawing.Size(125, 126);
            this.kostka4.TabIndex = 5;
            this.kostka4.UseVisualStyleBackColor = true;
            this.kostka4.Visible = false;
            // 
            // kostka5
            // 
            this.kostka5.Appearance = System.Windows.Forms.Appearance.Button;
            this.kostka5.AutoSize = true;
            this.kostka5.Checked = true;
            this.kostka5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kostka5.Image = global::kosci.Properties.Resources._0;
            this.kostka5.Location = new System.Drawing.Point(570, 148);
            this.kostka5.Name = "kostka5";
            this.kostka5.Size = new System.Drawing.Size(125, 126);
            this.kostka5.TabIndex = 6;
            this.kostka5.UseVisualStyleBackColor = true;
            this.kostka5.Visible = false;
            // 
            // rzuc
            // 
            this.rzuc.BackColor = System.Drawing.Color.Green;
            this.rzuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rzuc.Font = new System.Drawing.Font("Buxton Sketch", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rzuc.Location = new System.Drawing.Point(276, 305);
            this.rzuc.Name = "rzuc";
            this.rzuc.Size = new System.Drawing.Size(192, 78);
            this.rzuc.TabIndex = 7;
            this.rzuc.Text = "RZUĆ";
            this.rzuc.UseVisualStyleBackColor = false;
            this.rzuc.Visible = false;
            this.rzuc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kosci.Properties.Resources.background_green;
            this.ClientSize = new System.Drawing.Size(742, 410);
            this.Controls.Add(this.rzuc);
            this.Controls.Add(this.kostka5);
            this.Controls.Add(this.kostka4);
            this.Controls.Add(this.kostka3);
            this.Controls.Add(this.kostka2);
            this.Controls.Add(this.kostka1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kości";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rodzajGryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ilośćRundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wynikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wersjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wersjaKarcianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox kostka1;
        private System.Windows.Forms.CheckBox kostka2;
        private System.Windows.Forms.CheckBox kostka3;
        private System.Windows.Forms.CheckBox kostka4;
        private System.Windows.Forms.CheckBox kostka5;
        private System.Windows.Forms.Button rzuc;
    }
}

