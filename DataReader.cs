using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NPC_Generator
{
    public class DataReader
    {
        //Careful with modifying position of elements
        List<String> fileList = new List<String>
        {
            "Appearance",
            "Backgrounds",
            "Female Names",
            "Goals",
            "Personality",
            "Professions",
            "Quest Rewards",
            "Secrets",
            "Male Names",
            "Surnames"
        };
        string folderLocation = "NPC Data\\";
        string fileAppend = ".csv";
        NPCDataRepo npcDataRepo;

        public DataReader(NPCDataRepo npcDataRepo)
        {
            this.npcDataRepo = npcDataRepo;
            for (int i = 0; i < fileList.Count; i++)
            {
                ReadFile(folderLocation + fileList[i] + fileAppend, i);
            }
        }

        public void ReadFile(string fileName, int dataPos)
        {
            //Basic setup of initial input operation
            StreamReader sReader = new StreamReader(fileName);

            List<String> fileStrings = new List<String>();
            string tempString;

            while (!sReader.EndOfStream)
            {
                tempString = sReader.ReadLine();
                if (tempString.Substring(tempString.Length - 1, 1) == ",") tempString = tempString.Substring(0, tempString.Length - 1);
                fileStrings.Add(tempString);
            }

            npcDataRepo.repoData.Add(fileStrings);
            npcDataRepo.repoDataLabels.Add(fileList[dataPos]);
        }
    }
}
