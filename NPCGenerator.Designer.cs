namespace NPC_Generator
{
    partial class NPCGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView_dView = new System.Windows.Forms.DataGridView();
            this.Button_Generate = new System.Windows.Forms.Button();
            this.Label_NoNPCs = new System.Windows.Forms.Label();
            this.TextBox_NoNPCs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_dView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_dView
            // 
            this.DataGridView_dView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_dView.Location = new System.Drawing.Point(104, 8);
            this.DataGridView_dView.Name = "DataGridView_dView";
            this.DataGridView_dView.Size = new System.Drawing.Size(1328, 624);
            this.DataGridView_dView.TabIndex = 0;
            // 
            // Button_Generate
            // 
            this.Button_Generate.Location = new System.Drawing.Point(8, 64);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(75, 23);
            this.Button_Generate.TabIndex = 1;
            this.Button_Generate.Text = "Generate";
            this.Button_Generate.UseVisualStyleBackColor = true;
            this.Button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // Label_NoNPCs
            // 
            this.Label_NoNPCs.AutoSize = true;
            this.Label_NoNPCs.Location = new System.Drawing.Point(8, 16);
            this.Label_NoNPCs.Name = "Label_NoNPCs";
            this.Label_NoNPCs.Size = new System.Drawing.Size(86, 13);
            this.Label_NoNPCs.TabIndex = 2;
            this.Label_NoNPCs.Text = "Number of NPCs";
            // 
            // TextBox_NoNPCs
            // 
            this.TextBox_NoNPCs.Location = new System.Drawing.Point(8, 40);
            this.TextBox_NoNPCs.Name = "TextBox_NoNPCs";
            this.TextBox_NoNPCs.Size = new System.Drawing.Size(88, 20);
            this.TextBox_NoNPCs.TabIndex = 3;
            this.TextBox_NoNPCs.Text = "200";
            // 
            // NPCGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 640);
            this.Controls.Add(this.TextBox_NoNPCs);
            this.Controls.Add(this.Label_NoNPCs);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.DataGridView_dView);
            this.Name = "NPCGenerator";
            this.Text = "NPCGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_dView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_dView;
        private System.Windows.Forms.Button Button_Generate;
        private System.Windows.Forms.Label Label_NoNPCs;
        private System.Windows.Forms.TextBox TextBox_NoNPCs;
    }
}

