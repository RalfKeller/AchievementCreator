using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace AchievementCreator
{
    public partial class Form1 : Form
    {
        List<Achievement> allAchievements = new List<Achievement>();
        Achievement currentAchievement;
        int currentLevel;
        int currentAchievementIndex = -1;

        int contextLevel;
        int contextAchievementIndex;

        public Form1()
        {
            InitializeComponent();
            loadAchievements();
        }

        public void loadAchievements()
        {
            try
            {
                if (File.Exists("achievements.txt"))
                {
                    string achievementsString = File.ReadAllText("achievements.txt");
                    allAchievements = JsonConvert.DeserializeObject<List<Achievement>>(achievementsString);

                    foreach (Achievement achievement in allAchievements)
                    {
                        TreeNode mainNode = new TreeNode(achievement.getTitle(0));
                        mainNode.Name = "aNode";
                        for (int i = 0; i < achievement.getLevels(); i++)
                        {
                            TreeNode newNode = new TreeNode("Level " + i);
                            newNode.Name = "levelNode";
                            mainNode.Nodes.Add(newNode);
                        }

                        treeView1.Nodes.Add(mainNode);
                    }
                }

                else
                {
                    File.Create("achievements.txt");
                }
            }
            catch (Exception)
            {
                allAchievements = new List<Achievement>();
            }

        }

        private void newAchievementButton_Click(object sender, EventArgs e)
        {
            Achievement a = new Achievement();
            currentAchievement = a;
            allAchievements.Add(a);
            TreeNode node = new TreeNode("[Neues Achievement]");
            node.Name = "aNode";
            treeView1.Nodes.Add(node);
        }

        private void save_Click(object sender, EventArgs e)
        {
            currentAchievement.setAnzahl((int)anzahlUpDown.Value, currentLevel);
            currentAchievement.setBeschreibng(beschreibungTextbox.Text, currentLevel);
            currentAchievement.setTitle(titelTextbox.Text, currentLevel);

            saveToFile();
        }

        private void saveToFile()
        {
            string outputString = JsonConvert.SerializeObject(allAchievements);
            File.WriteAllText("achievements.txt", outputString);
        }

        private void newLevelButton_Click(object sender, EventArgs e)
        {
            if (currentAchievementIndex == -1)
            {
                MessageBox.Show("Du musst zuerst ein Achievement auswählen bevor du ein neues Level erstellen kannst.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TreeNode parentNode = treeView1.Nodes[currentAchievementIndex];
            Achievement a = allAchievements[currentAchievementIndex];

            TreeNode newNode = new TreeNode("Level " + a.getLevels());
            newNode.Name = "levelNode";
            a.setLevels(a.getLevels());

            parentNode.Nodes.Add(newNode);

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int achievementIndex;
            int levelIndex;

            TreeNode currentNode = e.Node;
            if (currentNode.Name == "levelNode")
            {
                levelIndex = e.Node.Index;
                achievementIndex = e.Node.Parent.Index;

            }

            else
            {
                currentAchievementIndex = currentNode.Index;
                loadAchievement(currentNode.Index, 0);

                achievementIndex = currentNode.Index;
                levelIndex = -1;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                loadAchievement(achievementIndex, levelIndex == -1 ? 0 : levelIndex);
                currentAchievementIndex = achievementIndex;
                currentLevel = levelIndex;
            }

            else
            {
                contextAchievementIndex = achievementIndex;
                contextLevel = levelIndex;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void loadAchievement(int achievementIndex, int level)
        {
            Achievement a = allAchievements[achievementIndex];
            titelTextbox.Text = a.getTitle(level);
            beschreibungTextbox.Text = a.getBeschreibung(level);
            anzahlUpDown.Value = a.getMaxAnzahl(level);

            currentAchievement = a;
        }

        private void clearViews()
        {
            titelTextbox.Text = "";
            beschreibungTextbox.Text = "";
            anzahlUpDown.Value = 0;
            methodenIDBox.Text = "";
        }

        private void löschenToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextAchievementIndex != -1)
            {
                if (contextLevel == -1)
                {
                    allAchievements.RemoveAt(contextAchievementIndex);
                    treeView1.Nodes.RemoveAt(contextAchievementIndex);
                    currentAchievementIndex = -1;
                    treeView1.SelectedNode = null;
                    currentAchievement = null;
                    clearViews();
                    saveToFile();
                }

                else if (contextLevel < allAchievements[contextAchievementIndex].getLevels() - 1)
                {
                    MessageBox.Show("Du kannst nicht ein Level löschen, wenn es nicht das letzte ist.", "Feher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (contextLevel == allAchievements[contextAchievementIndex].getLevels() - 1)
                {
                    allAchievements[contextAchievementIndex].deleteLastLevel();
                    treeView1.Nodes[contextAchievementIndex].Nodes.RemoveAt(contextLevel);
                    currentLevel = -1;
                    currentAchievementIndex = -1;
                    treeView1.SelectedNode = null;
                    currentAchievement = null;
                    clearViews();
                    saveToFile();
                }
            }

            else
            {
                MessageBox.Show("Es wurde nichts richtiges Ausgewählt!");
            }

        }
    }
}
