using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchievementCreator
{
    [JsonObject]
    class Achievement
    {
        [JsonProperty]
        private List<string> titel;
        [JsonProperty]
        private List<string> beschreibung;
        [JsonProperty]
        private List<int> maximaleAnzahl;

        [JsonProperty]
        private int levels;

        public Achievement()
        {
            titel = new List<string>();
            beschreibung = new List<string>();
            maximaleAnzahl = new List<int>();
        }

        public int getLevels()
        {
            return levels + 1;
        }

        public void setLevels(int levels)
        {
            this.levels = levels;
        }

        public string getTitle(int level)
        {
            if (level >= titel.Count)
                return "";
            return titel[level];
        }

        public string getBeschreibung(int level)
        {
            if (level >= beschreibung.Count)
                return "";
            return beschreibung[level];
        }

        public int getMaxAnzahl(int level)
        {
            if (level >= maximaleAnzahl.Count)
                return 0;
            return maximaleAnzahl[level];
        }

        public void setTitle(string titel, int level)
        {
            while (this.titel.Count < level + 1)
            {
                this.titel.Add("");
            }
            this.titel[level] = titel;

            if (level > levels)
                levels = level;
        }

        public void setBeschreibng(string beschreibung, int level)
        {
            while (this.beschreibung.Count < level + 1)
            {
                this.beschreibung.Add("");
            }
            this.beschreibung[level] = beschreibung;

            if (level > levels)
                levels = level;
        }

        public void setAnzahl(int anzahl, int level)
        {
            while (this.maximaleAnzahl.Count < level + 1)
            {
                this.maximaleAnzahl.Add(0);
            }
            this.maximaleAnzahl[level] = anzahl;

            if (level > levels)
                levels = level;
        }

    }
}
