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

            string FirstName = "Alan";
            if (Gender == "Female") FirstName = getRepoData("Female Names");
            else FirstName = getRepoData("Male Names");

            string Surname = getRepoData("Surnames");

            string MothersName = getRepoData("Female Names");
            string FathersName = getRepoData("Male Names");

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

            string Appearance = getRepoData("Appearance");

            string Background = getRepoData("Backgrounds");
            string Goals = getRepoData("Goals");
            string Personality = getRepoData("Personality");
            string Profession = getRepoData("Professions");
            string QuestRewards = getRepoData("Quest Rewards");
            string Secret = getRepoData("Secrets");
            return new NPCData(Gender, FirstName, Surname,
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

        public string getRepoData(string listName)
        {
            return npcDataRepo.repoData[getPosOfList(listName)][rnd.Next(0, npcDataRepo.repoData[getPosOfList(listName)].Count)];
        }
    }
}
