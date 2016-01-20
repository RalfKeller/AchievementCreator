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
            this.label1 = new System.Windows.Forms.Label();
            this.methodenIDBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.anzahlUpDown)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAchievementButton
            // 
            this.newAchievementButton.Location = new System.Drawing.Point(255, 551);
            this.newAchievementButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newAchievementButton.Name = "newAchievementButton";
            this.newAchievementButton.Size = new System.Drawing.Size(176, 35);
            this.newAchievementButton.TabIndex = 1;
            this.newAchievementButton.Text = "Neues Achievement";
            this.newAchievementButton.UseVisualStyleBackColor = true;
            this.newAchievementButton.Click += new System.EventHandler(this.newAchievementButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(18, 20);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(220, 564);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // titelTextbox
            // 
            this.titelTextbox.Location = new System.Drawing.Point(369, 20);
            this.titelTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titelTextbox.Name = "titelTextbox";
            this.titelTextbox.Size = new System.Drawing.Size(214, 26);
            this.titelTextbox.TabIndex = 3;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Location = new System.Drawing.Point(250, 25);
            this.titelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(38, 20);
            this.titelLabel.TabIndex = 4;
            this.titelLabel.Text = "Titel";
            // 
            // beschreibungsLabel
            // 
            this.beschreibungsLabel.AutoSize = true;
            this.beschreibungsLabel.Location = new System.Drawing.Point(250, 83);
            this.beschreibungsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.beschreibungsLabel.Name = "beschreibungsLabel";
            this.beschreibungsLabel.Size = new System.Drawing.Size(107, 20);
            this.beschreibungsLabel.TabIndex = 5;
            this.beschreibungsLabel.Text = "Beschreibung";
            // 
            // beschreibungTextbox
            // 
            this.beschreibungTextbox.Location = new System.Drawing.Point(369, 78);
            this.beschreibungTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beschreibungTextbox.Name = "beschreibungTextbox";
            this.beschreibungTextbox.Size = new System.Drawing.Size(214, 26);
            this.beschreibungTextbox.TabIndex = 6;
            // 
            // anzahlUpDown
            // 
            this.anzahlUpDown.Location = new System.Drawing.Point(369, 143);
            this.anzahlUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anzahlUpDown.Name = "anzahlUpDown";
            this.anzahlUpDown.Size = new System.Drawing.Size(216, 26);
            this.anzahlUpDown.TabIndex = 7;
            // 
            // anzahlLabel
            // 
            this.anzahlLabel.AutoSize = true;
            this.anzahlLabel.Location = new System.Drawing.Point(250, 146);
            this.anzahlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.anzahlLabel.Name = "anzahlLabel";
            this.anzahlLabel.Size = new System.Drawing.Size(58, 20);
            this.anzahlLabel.TabIndex = 8;
            this.anzahlLabel.Text = "Anzahl";
            // 
            // newLevelButton
            // 
            this.newLevelButton.Location = new System.Drawing.Point(440, 551);
            this.newLevelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newLevelButton.Name = "newLevelButton";
            this.newLevelButton.Size = new System.Drawing.Size(112, 35);
            this.newLevelButton.TabIndex = 9;
            this.newLevelButton.Text = "Neues Level";
            this.newLevelButton.UseVisualStyleBackColor = true;
            this.newLevelButton.Click += new System.EventHandler(this.newLevelButton_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(561, 552);
            this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(112, 35);
            this.save.TabIndex = 10;
            this.save.Text = "Speichern";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 67);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.löschenToolStripMenuItem_DropDownItemClicked);
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "MethodenID";
            // 
            // methodenIDBox
            // 
            this.methodenIDBox.Location = new System.Drawing.Point(369, 210);
            this.methodenIDBox.Name = "methodenIDBox";
            this.methodenIDBox.Size = new System.Drawing.Size(214, 26);
            this.methodenIDBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 606);
            this.Controls.Add(this.methodenIDBox);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox methodenIDBox;
    }
}

