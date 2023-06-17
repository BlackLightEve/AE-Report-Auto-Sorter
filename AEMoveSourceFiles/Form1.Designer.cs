namespace AEMoveSourceFiles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoveFilesBT = new System.Windows.Forms.Button();
            this.selectReportTB = new System.Windows.Forms.TextBox();
            this.selectReportBT = new System.Windows.Forms.Button();
            this.selectDestinationBT = new System.Windows.Forms.Button();
            this.selectDestinationTB = new System.Windows.Forms.TextBox();
            this.reportInstructionLB = new System.Windows.Forms.Label();
            this.destinationInstructionLB = new System.Windows.Forms.Label();
            this.ignoreDirectoryCB = new System.Windows.Forms.ComboBox();
            this.ignoreInstructionsLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressPB = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveFilesBT
            // 
            this.MoveFilesBT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoveFilesBT.Location = new System.Drawing.Point(425, 152);
            this.MoveFilesBT.Name = "MoveFilesBT";
            this.MoveFilesBT.Size = new System.Drawing.Size(149, 46);
            this.MoveFilesBT.TabIndex = 0;
            this.MoveFilesBT.Text = "Move Files";
            this.MoveFilesBT.UseVisualStyleBackColor = true;
            this.MoveFilesBT.Click += new System.EventHandler(this.MoveFilesBT_Click);
            // 
            // selectReportTB
            // 
            this.selectReportTB.Location = new System.Drawing.Point(32, 45);
            this.selectReportTB.Name = "selectReportTB";
            this.selectReportTB.Size = new System.Drawing.Size(387, 23);
            this.selectReportTB.TabIndex = 1;
            // 
            // selectReportBT
            // 
            this.selectReportBT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectReportBT.Location = new System.Drawing.Point(425, 45);
            this.selectReportBT.Name = "selectReportBT";
            this.selectReportBT.Size = new System.Drawing.Size(149, 23);
            this.selectReportBT.TabIndex = 2;
            this.selectReportBT.Text = "Select AE Report";
            this.selectReportBT.UseVisualStyleBackColor = true;
            this.selectReportBT.Click += new System.EventHandler(this.SelectReportBT_Click);
            // 
            // selectDestinationBT
            // 
            this.selectDestinationBT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectDestinationBT.Location = new System.Drawing.Point(425, 105);
            this.selectDestinationBT.Name = "selectDestinationBT";
            this.selectDestinationBT.Size = new System.Drawing.Size(149, 23);
            this.selectDestinationBT.TabIndex = 4;
            this.selectDestinationBT.Text = "Select Destination";
            this.selectDestinationBT.UseVisualStyleBackColor = true;
            this.selectDestinationBT.Click += new System.EventHandler(this.SelectDestinationBT_Click);
            // 
            // selectDestinationTB
            // 
            this.selectDestinationTB.Location = new System.Drawing.Point(32, 105);
            this.selectDestinationTB.Name = "selectDestinationTB";
            this.selectDestinationTB.Size = new System.Drawing.Size(387, 23);
            this.selectDestinationTB.TabIndex = 3;
            // 
            // reportInstructionLB
            // 
            this.reportInstructionLB.AutoSize = true;
            this.reportInstructionLB.BackColor = System.Drawing.Color.LightGray;
            this.reportInstructionLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reportInstructionLB.Location = new System.Drawing.Point(22, 22);
            this.reportInstructionLB.Name = "reportInstructionLB";
            this.reportInstructionLB.Size = new System.Drawing.Size(179, 15);
            this.reportInstructionLB.TabIndex = 5;
            this.reportInstructionLB.Text = "Select the AE Report location...\r\n";
            // 
            // destinationInstructionLB
            // 
            this.destinationInstructionLB.AutoSize = true;
            this.destinationInstructionLB.BackColor = System.Drawing.Color.LightGray;
            this.destinationInstructionLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.destinationInstructionLB.Location = new System.Drawing.Point(22, 86);
            this.destinationInstructionLB.Name = "destinationInstructionLB";
            this.destinationInstructionLB.Size = new System.Drawing.Size(174, 15);
            this.destinationInstructionLB.TabIndex = 6;
            this.destinationInstructionLB.Text = "Select the destination folder...";
            // 
            // ignoreDirectoryCB
            // 
            this.ignoreDirectoryCB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ignoreDirectoryCB.FormattingEnabled = true;
            this.ignoreDirectoryCB.Items.AddRange(new object[] {
            "N/A",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ignoreDirectoryCB.Location = new System.Drawing.Point(226, 152);
            this.ignoreDirectoryCB.Name = "ignoreDirectoryCB";
            this.ignoreDirectoryCB.Size = new System.Drawing.Size(76, 23);
            this.ignoreDirectoryCB.TabIndex = 7;
            this.ignoreDirectoryCB.Text = "N/A";
            // 
            // ignoreInstructionsLB
            // 
            this.ignoreInstructionsLB.AutoSize = true;
            this.ignoreInstructionsLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ignoreInstructionsLB.Location = new System.Drawing.Point(22, 155);
            this.ignoreInstructionsLB.Name = "ignoreInstructionsLB";
            this.ignoreInstructionsLB.Size = new System.Drawing.Size(198, 15);
            this.ignoreInstructionsLB.TabIndex = 8;
            this.ignoreInstructionsLB.Text = "Ignore source files from directory:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 131);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // progressPB
            // 
            this.progressPB.Location = new System.Drawing.Point(319, 175);
            this.progressPB.Name = "progressPB";
            this.progressPB.Size = new System.Drawing.Size(100, 23);
            this.progressPB.TabIndex = 10;
            this.progressPB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "*You can enter multiple drive letters as \"A,B,C\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressPB);
            this.Controls.Add(this.ignoreInstructionsLB);
            this.Controls.Add(this.ignoreDirectoryCB);
            this.Controls.Add(this.destinationInstructionLB);
            this.Controls.Add(this.reportInstructionLB);
            this.Controls.Add(this.selectDestinationBT);
            this.Controls.Add(this.selectDestinationTB);
            this.Controls.Add(this.selectReportBT);
            this.Controls.Add(this.selectReportTB);
            this.Controls.Add(this.MoveFilesBT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "AE Move Source Files";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MoveFilesBT;
        private TextBox selectReportTB;
        private Button selectReportBT;
        private Button selectDestinationBT;
        private TextBox selectDestinationTB;
        private Label reportInstructionLB;
        private Label destinationInstructionLB;
        private ComboBox ignoreDirectoryCB;
        private Label ignoreInstructionsLB;
        private PictureBox pictureBox1;
        private ProgressBar progressPB;
        private Label label1;
    }
}