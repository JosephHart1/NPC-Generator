﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Generator
{
    public partial class NPCGenerator : Form
    {
        NPCDataRepo npcDataRepo;
        List<NPCData> npcList;
        DataReader dataReader;
        DataProcessor dataProcessor;
        DataGridView dView;
        List<string[]> tableRows;
        DataWriter dataWriter;

        public NPCGenerator()
        {
            InitializeComponent();
            dView = DataGridView_dView;
            npcDataRepo = new NPCDataRepo();
            npcList = new List<NPCData>();
            dataReader = new DataReader(npcDataRepo);
            dataProcessor = new DataProcessor(npcDataRepo);
            dataWriter = new DataWriter();
            tableRows = new List<string[]>();
        }

        private void Button_Generate_Click(object sender, EventArgs e)
        {
            npcList.Clear();
            tableRows.Clear();
            dView.Rows.Clear();
            dView.Columns.Clear();
            int numNPCsToGenerate = Int32.Parse(TextBox_NoNPCs.Text);
            for (int i = 0; i < numNPCsToGenerate; i++)
            {
                npcList.Add(dataProcessor.generateNPC());
            }
            displayTable();
            dataWriter.writeToCSV(tableRows);
        }

        private void displayTable()
        {
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Name";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Gender";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Race";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Appearance";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Background";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Goals";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Personality";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Profession";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Quest Reward";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Secret";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Mothers Name";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Fathers Name";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Number of Brothers";
            dView.ColumnCount++;
            dView.Columns[dView.ColumnCount - 1].Name = "Number of Sisters";

            for (int i = 0; i < npcList.Count; i++)
            {
                string[] rowToAdd = { npcList[i].FirstName + " " + npcList[i].Surname,
                npcList[i].Gender,
                npcList[i].Race,
                npcList[i].Appearance,
                npcList[i].Background,
                npcList[i].Goals,
                npcList[i].Personality,
                npcList[i].Profession,
                npcList[i].QuestRewards,
                npcList[i].Secret,
                npcList[i].MothersName,
                npcList[i].FathersName,
                npcList[i].NumBrothers.ToString(),
                npcList[i].NumSisters.ToString() };
                dView.Rows.Add(rowToAdd);
                tableRows.Add(rowToAdd);
            }

            dView.AutoResizeColumns();
        }
    }
}
