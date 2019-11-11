using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Generator
{
    public class NPCData
    {
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public Boolean Siblings { get; set; }
        public int NumBrothers { get; set; }
        public int NumSisters { get; set; }
        public string Appearance { get; set; }
        public string Background { get; set; }
        public string Goals { get; set; }
        public string Personality { get; set; }
        public string Profession { get; set; }
        public string QuestRewards { get; set; }
        public string Secret { get; set; }

        public NPCData(string Gender, string FirstName, string Surname,
            string MothersName, string FathersName, Boolean Siblings,
            int NumBrothers, int NumSisters, string Appearance,
            string Background, string Goals, string Personality,
            string Profession, string QuestRewards, string Secret)
        {
            this.Gender = Gender;
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.MothersName = MothersName;
            this.FathersName = FathersName;
            this.Siblings = Siblings;
            this.NumBrothers = NumBrothers;
            this.NumSisters = NumSisters;
            this.Appearance = Appearance;
            this.Background = Background;
            this.Goals = Goals;
            this.Personality = Personality;
            this.Profession = Profession;
            this.QuestRewards = QuestRewards;
            this.Secret = Secret;
        }
    }

    public class NPCDataRepo
    {
        public List<List<String>> repoData { get; set; }
        public List<String> repoDataLabels { get; set; }

        public NPCDataRepo()
        {
            repoData = new List<List<String>>();
            repoDataLabels = new List<String>();
        }
    }
}
