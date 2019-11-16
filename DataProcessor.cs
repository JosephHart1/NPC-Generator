using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Generator
{
    public class DataProcessor
    {
        NPCDataRepo npcDataRepo;
        Random rnd = new Random();

        public DataProcessor(NPCDataRepo npcDataRepo)
        {
            this.npcDataRepo = npcDataRepo;
        }

        public NPCData generateNPC()
        {
            string Gender;
            int genderRnd = rnd.Next(0, 2);
            if (genderRnd == 0) Gender = "Female";
            else Gender = "Male";

            string Race;
            int RaceRnd = rnd.Next(0, 10);
            if (RaceRnd != 0) Race = "Human";
            else
            {
                Race = getRandRepoData("Races");
            }

            string FirstName = "Alan";
            if (Gender == "Female") FirstName = getRandRepoData("Female Names");
            else FirstName = getRandRepoData("Male Names");

            string Surname = getRandRepoData("Surnames");

            string MothersName = getRandRepoData("Female Names");
            string FathersName = getRandRepoData("Male Names");

            Boolean Siblings = false;
            int NumBrothers = 0;
            int NumSisters = 0;
            if (rnd.Next(0, 2) == 0) Siblings = false;
            else
            {
                Siblings = true;
                NumBrothers = rnd.Next(0, 5);
                NumSisters = rnd.Next(0, 5);
            }

            string Appearance = getRandRepoData("Appearance");

            string Background = getRandRepoData("Backgrounds");
            string Goals = getRandRepoData("Goals");
            string Personality = getRandRepoData("Personality");
            string Profession = getRandRepoData("Professions");
            string QuestRewards = getRandRepoData("Quest Rewards");
            string Secret = getRandRepoData("Secrets");
            return new NPCData(Gender, Race, FirstName, Surname,
             MothersName, FathersName, Siblings,
             NumBrothers, NumSisters, Appearance,
             Background, Goals, Personality,
             Profession, QuestRewards, Secret);
        }

        public int getPosOfList(string listName)
        {
            for (int i = 0; i < npcDataRepo.repoDataLabels.Count; i++)
            {
                if (npcDataRepo.repoDataLabels[i] == listName) return i;
            }

            return 0;
        }

        public string getRandRepoData(string listName)
        {
            return npcDataRepo.repoData[getPosOfList(listName)][rnd.Next(0, npcDataRepo.repoData[getPosOfList(listName)].Count)];
        }
    }
}
