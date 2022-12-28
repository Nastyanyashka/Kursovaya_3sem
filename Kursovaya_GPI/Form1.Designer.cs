namespace Kursovaya_GPI
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxDeltaT = new System.Windows.Forms.TextBox();
            this.labelDeltaT = new System.Windows.Forms.Label();
            this.textBoxMaxLoadRATS = new System.Windows.Forms.TextBox();
            this.labelMaxLoadRATS = new System.Windows.Forms.Label();
            this.labelChanceOfTakeCall = new System.Windows.Forms.Label();
            this.textBoxChanceOfTakeCall = new System.Windows.Forms.TextBox();
            this.textBoxMaxTimeOfCall = new System.Windows.Forms.TextBox();
            this.labelMaxTimeOfCall = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.textBoxAmountOfModels = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoadOfFirstRATS = new System.Windows.Forms.Label();
            this.labelLoadOfSecondRATS = new System.Windows.Forms.Label();
            this.labelLoadOfThirdRATS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(705, 36);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxDeltaT
            // 
            this.textBoxDeltaT.Location = new System.Drawing.Point(12, 36);
            this.textBoxDeltaT.Name = "textBoxDeltaT";
            this.textBoxDeltaT.Size = new System.Drawing.Size(100, 23);
            this.textBoxDeltaT.TabIndex = 1;
            // 
            // labelDeltaT
            // 
            this.labelDeltaT.AutoSize = true;
            this.labelDeltaT.Location = new System.Drawing.Point(12, 9);
            this.labelDeltaT.Name = "labelDeltaT";
            this.labelDeltaT.Size = new System.Drawing.Size(18, 15);
            this.labelDeltaT.TabIndex = 2;
            this.labelDeltaT.Text = "dt";
            // 
            // textBoxMaxLoadRATS
            // 
            this.textBoxMaxLoadRATS.Location = new System.Drawing.Point(12, 95);
            this.textBoxMaxLoadRATS.Name = "textBoxMaxLoadRATS";
            this.textBoxMaxLoadRATS.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxLoadRATS.TabIndex = 3;
            // 
            // labelMaxLoadRATS
            // 
            this.labelMaxLoadRATS.AutoSize = true;
            this.labelMaxLoadRATS.Location = new System.Drawing.Point(12, 77);
            this.labelMaxLoadRATS.Name = "labelMaxLoadRATS";
            this.labelMaxLoadRATS.Size = new System.Drawing.Size(99, 15);
            this.labelMaxLoadRATS.TabIndex = 4;
            this.labelMaxLoadRATS.Text = "Max load of RATS";
            // 
            // labelChanceOfTakeCall
            // 
            this.labelChanceOfTakeCall.AutoSize = true;
            this.labelChanceOfTakeCall.Location = new System.Drawing.Point(12, 133);
            this.labelChanceOfTakeCall.Name = "labelChanceOfTakeCall";
            this.labelChanceOfTakeCall.Size = new System.Drawing.Size(107, 15);
            this.labelChanceOfTakeCall.TabIndex = 5;
            this.labelChanceOfTakeCall.Text = "Chance of take call";
            // 
            // textBoxChanceOfTakeCall
            // 
            this.textBoxChanceOfTakeCall.Location = new System.Drawing.Point(12, 151);
            this.textBoxChanceOfTakeCall.Name = "textBoxChanceOfTakeCall";
            this.textBoxChanceOfTakeCall.Size = new System.Drawing.Size(100, 23);
            this.textBoxChanceOfTakeCall.TabIndex = 6;
            // 
            // textBoxMaxTimeOfCall
            // 
            this.textBoxMaxTimeOfCall.Location = new System.Drawing.Point(12, 203);
            this.textBoxMaxTimeOfCall.Name = "textBoxMaxTimeOfCall";
            this.textBoxMaxTimeOfCall.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxTimeOfCall.TabIndex = 7;
            // 
            // labelMaxTimeOfCall
            // 
            this.labelMaxTimeOfCall.AutoSize = true;
            this.labelMaxTimeOfCall.Location = new System.Drawing.Point(12, 185);
            this.labelMaxTimeOfCall.Name = "labelMaxTimeOfCall";
            this.labelMaxTimeOfCall.Size = new System.Drawing.Size(124, 15);
            this.labelMaxTimeOfCall.TabIndex = 8;
            this.labelMaxTimeOfCall.Text = "Maximum time of call";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // textBoxAmountOfModels
            // 
            this.textBoxAmountOfModels.Location = new System.Drawing.Point(12, 257);
            this.textBoxAmountOfModels.Name = "textBoxAmountOfModels";
            this.textBoxAmountOfModels.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmountOfModels.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Amount of models";
            // 
            // labelLoadOfFirstRATS
            // 
            this.labelLoadOfFirstRATS.AutoSize = true;
            this.labelLoadOfFirstRATS.Location = new System.Drawing.Point(17, 329);
            this.labelLoadOfFirstRATS.Name = "labelLoadOfFirstRATS";
            this.labelLoadOfFirstRATS.Size = new System.Drawing.Size(94, 15);
            this.labelLoadOfFirstRATS.TabIndex = 13;
            this.labelLoadOfFirstRATS.Text = "Load of 1st RATS";
            // 
            // labelLoadOfSecondRATS
            // 
            this.labelLoadOfSecondRATS.AutoSize = true;
            this.labelLoadOfSecondRATS.Location = new System.Drawing.Point(262, 329);
            this.labelLoadOfSecondRATS.Name = "labelLoadOfSecondRATS";
            this.labelLoadOfSecondRATS.Size = new System.Drawing.Size(99, 15);
            this.labelLoadOfSecondRATS.TabIndex = 14;
            this.labelLoadOfSecondRATS.Text = "Load of 2nd RATS";
            // 
            // labelLoadOfThirdRATS
            // 
            this.labelLoadOfThirdRATS.AutoSize = true;
            this.labelLoadOfThirdRATS.Location = new System.Drawing.Point(572, 329);
            this.labelLoadOfThirdRATS.Name = "labelLoadOfThirdRATS";
            this.labelLoadOfThirdRATS.Size = new System.Drawing.Size(96, 15);
            this.labelLoadOfThirdRATS.TabIndex = 15;
            this.labelLoadOfThirdRATS.Text = "Load of 3rd RATS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoadOfThirdRATS);
            this.Controls.Add(this.labelLoadOfSecondRATS);
            this.Controls.Add(this.labelLoadOfFirstRATS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmountOfModels);
            this.Controls.Add(this.labelMaxTimeOfCall);
            this.Controls.Add(this.textBoxMaxTimeOfCall);
            this.Controls.Add(this.textBoxChanceOfTakeCall);
            this.Controls.Add(this.labelChanceOfTakeCall);
            this.Controls.Add(this.labelMaxLoadRATS);
            this.Controls.Add(this.textBoxMaxLoadRATS);
            this.Controls.Add(this.labelDeltaT);
            this.Controls.Add(this.textBoxDeltaT);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStart;
        private TextBox textBoxDeltaT;
        private Label labelDeltaT;
        private TextBox textBoxMaxLoadRATS;
        private Label labelMaxLoadRATS;
        private Label labelChanceOfTakeCall;
        private TextBox textBoxChanceOfTakeCall;
        private TextBox textBoxMaxTimeOfCall;
        private Label labelMaxTimeOfCall;
        private System.Windows.Forms.Timer timerUpdate;
        private TextBox textBoxAmountOfModels;
        private Label label2;
        private Label labelLoadOfFirstRATS;
        private Label labelLoadOfSecondRATS;
        private Label labelLoadOfThirdRATS;
    }
}