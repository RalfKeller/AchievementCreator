namespace AchievementCreator
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
            this.components = new System.ComponentModel.Container();
            this.newAchievementButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.titelTextbox = new System.Windows.Forms.TextBox();
            this.titelLabel = new System.Windows.Forms.Label();
            this.beschreibungsLabel = new System.Windows.Forms.Label();
            this.beschreibungTextbox = new System.Windows.Forms.TextBox();
            this.anzahlUpDown = new System.Windows.Forms.NumericUpDown();
            this.anzahlLabel = new System.Windows.Forms.Label();
            this.newLevelButton = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.anzahlUpDown)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAchievementButton
            // 
            this.newAchievementButton.Location = new System.Drawing.Point(170, 358);
            this.newAchievementButton.Name = "newAchievementButton";
            this.newAchievementButton.Size = new System.Drawing.Size(117, 23);
            this.newAchievementButton.TabIndex = 1;
            this.newAchievementButton.Text = "Neues Achievement";
            this.newAchievementButton.UseVisualStyleBackColor = true;
            this.newAchievementButton.Click += new System.EventHandler(this.newAchievementButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(148, 368);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // titelTextbox
            // 
            this.titelTextbox.Location = new System.Drawing.Point(246, 13);
            this.titelTextbox.Name = "titelTextbox";
            this.titelTextbox.Size = new System.Drawing.Size(144, 20);
            this.titelTextbox.TabIndex = 3;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Location = new System.Drawing.Point(167, 16);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(27, 13);
            this.titelLabel.TabIndex = 4;
            this.titelLabel.Text = "Titel";
            // 
            // beschreibungsLabel
            // 
            this.beschreibungsLabel.AutoSize = true;
            this.beschreibungsLabel.Location = new System.Drawing.Point(167, 54);
            this.beschreibungsLabel.Name = "beschreibungsLabel";
            this.beschreibungsLabel.Size = new System.Drawing.Size(72, 13);
            this.beschreibungsLabel.TabIndex = 5;
            this.beschreibungsLabel.Text = "Beschreibung";
            // 
            // beschreibungTextbox
            // 
            this.beschreibungTextbox.Location = new System.Drawing.Point(246, 51);
            this.beschreibungTextbox.Name = "beschreibungTextbox";
            this.beschreibungTextbox.Size = new System.Drawing.Size(144, 20);
            this.beschreibungTextbox.TabIndex = 6;
            // 
            // anzahlUpDown
            // 
            this.anzahlUpDown.Location = new System.Drawing.Point(246, 93);
            this.anzahlUpDown.Name = "anzahlUpDown";
            this.anzahlUpDown.Size = new System.Drawing.Size(144, 20);
            this.anzahlUpDown.TabIndex = 7;
            // 
            // anzahlLabel
            // 
            this.anzahlLabel.AutoSize = true;
            this.anzahlLabel.Location = new System.Drawing.Point(167, 95);
            this.anzahlLabel.Name = "anzahlLabel";
            this.anzahlLabel.Size = new System.Drawing.Size(39, 13);
            this.anzahlLabel.TabIndex = 8;
            this.anzahlLabel.Text = "Anzahl";
            // 
            // newLevelButton
            // 
            this.newLevelButton.Location = new System.Drawing.Point(293, 358);
            this.newLevelButton.Name = "newLevelButton";
            this.newLevelButton.Size = new System.Drawing.Size(75, 23);
            this.newLevelButton.TabIndex = 9;
            this.newLevelButton.Text = "Neues Level";
            this.newLevelButton.UseVisualStyleBackColor = true;
            this.newLevelButton.Click += new System.EventHandler(this.newLevelButton_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(374, 359);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Speichern";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.löschenToolStripMenuItem_DropDownItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 394);
            this.Controls.Add(this.save);
            this.Controls.Add(this.newLevelButton);
            this.Controls.Add(this.anzahlLabel);
            this.Controls.Add(this.anzahlUpDown);
            this.Controls.Add(this.beschreibungTextbox);
            this.Controls.Add(this.beschreibungsLabel);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.titelTextbox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.newAchievementButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.anzahlUpDown)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newAchievementButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox titelTextbox;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Label beschreibungsLabel;
        private System.Windows.Forms.TextBox beschreibungTextbox;
        private System.Windows.Forms.NumericUpDown anzahlUpDown;
        private System.Windows.Forms.Label anzahlLabel;
        private System.Windows.Forms.Button newLevelButton;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;

    }
}

