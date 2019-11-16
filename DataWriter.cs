using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace NPC_Generator
{
    class DataWriter
    {
        public void writeToCSV(List<string[]> tableRows)
        {
            StringBuilder csvText = new StringBuilder();
            string tempS = "Name,Gender,Race,Appearance,Background,Goals,Personality,Profession,Quest Reward,Secret,Mothers Name,Fathers Name,Number of Brothers,Number of Sisters";
            csvText.AppendLine(tempS);  //Titles
            for (int i = 0; i < tableRows.Count; i++)
            {
                for (int j = 0; j < tableRows[i].Length; j++)
                {
                    if (j > 0) tempS = tempS + "," + tableRows[i][j];
                    else tempS = tableRows[i][j];
                }
                csvText.AppendLine(tempS);
            }
            File.WriteAllText("NPCOutput.csv", csvText.ToString());
        }
    }
}
