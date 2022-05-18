namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CB_Debuge = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musterFestlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_SourceOne = new System.Windows.Forms.Label();
            this.BT_Brows1 = new System.Windows.Forms.Button();
            this.OF_Source = new System.Windows.Forms.OpenFileDialog();
            this.LB_Destination = new System.Windows.Forms.Label();
            this.LB_SourceTwo = new System.Windows.Forms.Label();
            this.BT_SourceTwo = new System.Windows.Forms.Button();
            this.SF_Destination = new System.Windows.Forms.SaveFileDialog();
            this.BT_Destination = new System.Windows.Forms.Button();
            this.BT_autofill = new System.Windows.Forms.Button();
            this.OF_Muster = new System.Windows.Forms.OpenFileDialog();
            this.LB_Muster = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Debuge
            // 
            this.CB_Debuge.AutoSize = true;
            this.CB_Debuge.Location = new System.Drawing.Point(12, 373);
            this.CB_Debuge.Name = "CB_Debuge";
            this.CB_Debuge.Size = new System.Drawing.Size(115, 21);
            this.CB_Debuge.TabIndex = 2;
            this.CB_Debuge.Text = "Debugemode";
            this.CB_Debuge.UseVisualStyleBackColor = true;
            this.CB_Debuge.Visible = false;
            this.CB_Debuge.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.musterFestlegenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // debugeToolStripMenuItem
            // 
            this.debugeToolStripMenuItem.Name = "debugeToolStripMenuItem";
            this.debugeToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.debugeToolStripMenuItem.Text = "Debuge";
            this.debugeToolStripMenuItem.Click += new System.EventHandler(this.debugeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // musterFestlegenToolStripMenuItem
            // 
            this.musterFestlegenToolStripMenuItem.Name = "musterFestlegenToolStripMenuItem";
            this.musterFestlegenToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.musterFestlegenToolStripMenuItem.Text = "Muster festlegen";
            this.musterFestlegenToolStripMenuItem.Click += new System.EventHandler(this.musterFestlegenToolStripMenuItem_Click);
            // 
            // LB_SourceOne
            // 
            this.LB_SourceOne.AutoSize = true;
            this.LB_SourceOne.Location = new System.Drawing.Point(3, 0);
            this.LB_SourceOne.Name = "LB_SourceOne";
            this.LB_SourceOne.Size = new System.Drawing.Size(167, 17);
            this.LB_SourceOne.TabIndex = 5;
            this.LB_SourceOne.Text = "Pfad Zeitmessung Kunde";
            this.LB_SourceOne.Click += new System.EventHandler(this.LB_Source1_Click);
            // 
            // BT_Brows1
            // 
            this.BT_Brows1.Location = new System.Drawing.Point(266, 3);
            this.BT_Brows1.Name = "BT_Brows1";
            this.BT_Brows1.Size = new System.Drawing.Size(257, 59);
            this.BT_Brows1.TabIndex = 6;
            this.BT_Brows1.Text = "Datei Suchen";
            this.BT_Brows1.UseVisualStyleBackColor = true;
            this.BT_Brows1.Click += new System.EventHandler(this.BT_Brows1_Click);
            // 
            // OF_Source
            // 
            this.OF_Source.Filter = "Excel-Datei|*.xlsx;*.xls|Textdatei|*.txt|Alle Dateien|*.*";
            this.OF_Source.FileOk += new System.ComponentModel.CancelEventHandler(this.OF_Source_FileOk);
            // 
            // LB_Destination
            // 
            this.LB_Destination.AutoSize = true;
            this.LB_Destination.Location = new System.Drawing.Point(3, 132);
            this.LB_Destination.Name = "LB_Destination";
            this.LB_Destination.Size = new System.Drawing.Size(139, 17);
            this.LB_Destination.TabIndex = 7;
            this.LB_Destination.Text = "Speicherort Zieldatei";
            // 
            // LB_SourceTwo
            // 
            this.LB_SourceTwo.AutoSize = true;
            this.LB_SourceTwo.Location = new System.Drawing.Point(3, 66);
            this.LB_SourceTwo.Name = "LB_SourceTwo";
            this.LB_SourceTwo.Size = new System.Drawing.Size(149, 34);
            this.LB_SourceTwo.TabIndex = 8;
            this.LB_SourceTwo.Text = "Pfad Zeitmessung \r\n(Nur für Chip benötigt)";
            // 
            // BT_SourceTwo
            // 
            this.BT_SourceTwo.Location = new System.Drawing.Point(266, 69);
            this.BT_SourceTwo.Name = "BT_SourceTwo";
            this.BT_SourceTwo.Size = new System.Drawing.Size(257, 59);
            this.BT_SourceTwo.TabIndex = 9;
            this.BT_SourceTwo.Text = "Datei Suchen";
            this.BT_SourceTwo.UseVisualStyleBackColor = true;
            this.BT_SourceTwo.Click += new System.EventHandler(this.BT_SourceTwo_Click);
            // 
            // SF_Destination
            // 
            this.SF_Destination.FileName = "Auswertung";
            this.SF_Destination.Filter = "Excel-Datei|*xlsx|Alle Dateien|*.*";
            // 
            // BT_Destination
            // 
            this.BT_Destination.Location = new System.Drawing.Point(266, 135);
            this.BT_Destination.Name = "BT_Destination";
            this.BT_Destination.Size = new System.Drawing.Size(257, 60);
            this.BT_Destination.TabIndex = 10;
            this.BT_Destination.Text = "Speichern unter";
            this.BT_Destination.UseVisualStyleBackColor = true;
            this.BT_Destination.Click += new System.EventHandler(this.BT_Destination_Click);
            // 
            // BT_autofill
            // 
            this.BT_autofill.Location = new System.Drawing.Point(169, 268);
            this.BT_autofill.Name = "BT_autofill";
            this.BT_autofill.Size = new System.Drawing.Size(193, 73);
            this.BT_autofill.TabIndex = 11;
            this.BT_autofill.Text = "Autofill";
            this.BT_autofill.UseVisualStyleBackColor = true;
            this.BT_autofill.Click += new System.EventHandler(this.BT_autofill_Click);
            // 
            // OF_Muster
            // 
            this.OF_Muster.FileName = "Muster.xlsx";
            this.OF_Muster.Filter = "Excel-Datei|*.xlsx|Alle Dateien|*.*";
            // 
            // LB_Muster
            // 
            this.LB_Muster.AutoSize = true;
            this.LB_Muster.Location = new System.Drawing.Point(9, 353);
            this.LB_Muster.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.LB_Muster.Name = "LB_Muster";
            this.LB_Muster.Size = new System.Drawing.Size(228, 17);
            this.LB_Muster.TabIndex = 12;
            this.LB_Muster.Text = "Muster unter: C:\\Autofill\\Muster.xlsx";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BT_Destination, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BT_Brows1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BT_SourceTwo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LB_Destination, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LB_SourceTwo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LB_SourceOne, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 198);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LB_Muster);
            this.Controls.Add(this.BT_autofill);
            this.Controls.Add(this.CB_Debuge);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Autofill";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Debuge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LB_SourceOne;
        private System.Windows.Forms.Button BT_Brows1;
        private System.Windows.Forms.OpenFileDialog OF_Source;
        private System.Windows.Forms.Label LB_Destination;
        private System.Windows.Forms.Label LB_SourceTwo;
        private System.Windows.Forms.Button BT_SourceTwo;
        private System.Windows.Forms.SaveFileDialog SF_Destination;
        private System.Windows.Forms.Button BT_Destination;
        private System.Windows.Forms.Button BT_autofill;
        private System.Windows.Forms.ToolStripMenuItem musterFestlegenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OF_Muster;
        private System.Windows.Forms.Label LB_Muster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

