namespace NumberGuessWorkflowHost
{
    partial class WorkflowHostForm
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
            this.labelInstanceId = new System.Windows.Forms.Label();
            this.InstanceId = new System.Windows.Forms.ComboBox();
            this.labelGuess = new System.Windows.Forms.Label();
            this.Guess = new System.Windows.Forms.TextBox();
            this.EnterGuess = new System.Windows.Forms.Button();
            this.QuitGame = new System.Windows.Forms.Button();
            this.WorkflowStatus = new System.Windows.Forms.TextBox();
            this.NewGame = new System.Windows.Forms.Button();
            this.labelNumberRange = new System.Windows.Forms.Label();
            this.NumberRange = new System.Windows.Forms.ComboBox();
            this.labelWorkflowType = new System.Windows.Forms.Label();
            this.WorkflowType = new System.Windows.Forms.ComboBox();
            this.WorkflowVersion = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.GroupBox();
            this.Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInstanceId
            // 
            this.labelInstanceId.AutoSize = true;
            this.labelInstanceId.Location = new System.Drawing.Point(8, 34);
            this.labelInstanceId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstanceId.Name = "labelInstanceId";
            this.labelInstanceId.Size = new System.Drawing.Size(129, 16);
            this.labelInstanceId.TabIndex = 0;
            this.labelInstanceId.Text = "Workflow Instance Id";
            // 
            // InstanceId
            // 
            this.InstanceId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstanceId.FormattingEnabled = true;
            this.InstanceId.Location = new System.Drawing.Point(157, 31);
            this.InstanceId.Margin = new System.Windows.Forms.Padding(4);
            this.InstanceId.Name = "InstanceId";
            this.InstanceId.Size = new System.Drawing.Size(299, 24);
            this.InstanceId.TabIndex = 1;
            this.InstanceId.SelectedIndexChanged += new System.EventHandler(this.InstanceId_SelectedIndexChanged);
            // 
            // labelGuess
            // 
            this.labelGuess.AutoSize = true;
            this.labelGuess.Location = new System.Drawing.Point(0, 69);
            this.labelGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuess.Name = "labelGuess";
            this.labelGuess.Size = new System.Drawing.Size(46, 16);
            this.labelGuess.TabIndex = 2;
            this.labelGuess.Text = "Guess";
            // 
            // Guess
            // 
            this.Guess.Location = new System.Drawing.Point(54, 66);
            this.Guess.Margin = new System.Windows.Forms.Padding(4);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(174, 22);
            this.Guess.TabIndex = 3;
            // 
            // EnterGuess
            // 
            this.EnterGuess.Location = new System.Drawing.Point(236, 63);
            this.EnterGuess.Margin = new System.Windows.Forms.Padding(4);
            this.EnterGuess.Name = "EnterGuess";
            this.EnterGuess.Size = new System.Drawing.Size(100, 28);
            this.EnterGuess.TabIndex = 4;
            this.EnterGuess.Text = "Enter Guess";
            this.EnterGuess.UseVisualStyleBackColor = true;
            this.EnterGuess.Click += new System.EventHandler(this.EnterGuess_Click);
            // 
            // QuitGame
            // 
            this.QuitGame.Location = new System.Drawing.Point(356, 63);
            this.QuitGame.Margin = new System.Windows.Forms.Padding(4);
            this.QuitGame.Name = "QuitGame";
            this.QuitGame.Size = new System.Drawing.Size(100, 28);
            this.QuitGame.TabIndex = 5;
            this.QuitGame.Text = "Quit";
            this.QuitGame.UseVisualStyleBackColor = true;
            this.QuitGame.Click += new System.EventHandler(this.QuitGame_Click);
            // 
            // WorkflowStatus
            // 
            this.WorkflowStatus.Location = new System.Drawing.Point(11, 99);
            this.WorkflowStatus.Margin = new System.Windows.Forms.Padding(4);
            this.WorkflowStatus.Multiline = true;
            this.WorkflowStatus.Name = "WorkflowStatus";
            this.WorkflowStatus.ReadOnly = true;
            this.WorkflowStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WorkflowStatus.Size = new System.Drawing.Size(448, 212);
            this.WorkflowStatus.TabIndex = 6;
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(13, 12);
            this.NewGame.Margin = new System.Windows.Forms.Padding(4);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(100, 28);
            this.NewGame.TabIndex = 7;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGameLocation_Click);
            // 
            // labelNumberRange
            // 
            this.labelNumberRange.AutoSize = true;
            this.labelNumberRange.Location = new System.Drawing.Point(125, 19);
            this.labelNumberRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberRange.Name = "labelNumberRange";
            this.labelNumberRange.Size = new System.Drawing.Size(161, 16);
            this.labelNumberRange.TabIndex = 8;
            this.labelNumberRange.Text = "Guess a number from 1 to ";
            // 
            // NumberRange
            // 
            this.NumberRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberRange.FormattingEnabled = true;
            this.NumberRange.Items.AddRange(new object[] {
            "10",
            "100",
            "1000"});
            this.NumberRange.Location = new System.Drawing.Point(315, 16);
            this.NumberRange.Margin = new System.Windows.Forms.Padding(4);
            this.NumberRange.Name = "NumberRange";
            this.NumberRange.Size = new System.Drawing.Size(166, 24);
            this.NumberRange.TabIndex = 9;
            this.NumberRange.SelectedIndexChanged += new System.EventHandler(this.NumberRange_SelectedIndexChanged);
            // 
            // labelWorkflowType
            // 
            this.labelWorkflowType.AutoSize = true;
            this.labelWorkflowType.Location = new System.Drawing.Point(17, 53);
            this.labelWorkflowType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkflowType.Name = "labelWorkflowType";
            this.labelWorkflowType.Size = new System.Drawing.Size(91, 16);
            this.labelWorkflowType.TabIndex = 10;
            this.labelWorkflowType.Text = "Workflow type";
            // 
            // WorkflowType
            // 
            this.WorkflowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkflowType.FormattingEnabled = true;
            this.WorkflowType.Items.AddRange(new object[] {
            "StateMachineNumberGuessWorkflow",
            "FlowchartNumberGuessWorkflow",
            "SequentialNumberGuessWorkflow",
            "StateMachineNumberGuessWorkflow v1",
            "FlowchartNumberGuessWorkflow v1",
            "SequentialNumberGuessWorkflow v1"});
            this.WorkflowType.Location = new System.Drawing.Point(128, 50);
            this.WorkflowType.Margin = new System.Windows.Forms.Padding(4);
            this.WorkflowType.Name = "WorkflowType";
            this.WorkflowType.Size = new System.Drawing.Size(353, 24);
            this.WorkflowType.TabIndex = 11;
            this.WorkflowType.SelectedIndexChanged += new System.EventHandler(this.WorkflowType_SelectedIndexChanged);
            // 
            // WorkflowVersion
            // 
            this.WorkflowVersion.AutoSize = true;
            this.WorkflowVersion.Location = new System.Drawing.Point(10, 422);
            this.WorkflowVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkflowVersion.Name = "WorkflowVersion";
            this.WorkflowVersion.Size = new System.Drawing.Size(109, 16);
            this.WorkflowVersion.TabIndex = 12;
            this.WorkflowVersion.Text = "Workflow version";
            this.WorkflowVersion.Click += new System.EventHandler(this.labelWorkflowVersion_Click);
            // 
            // Game
            // 
            this.Game.Controls.Add(this.QuitGame);
            this.Game.Controls.Add(this.WorkflowStatus);
            this.Game.Controls.Add(this.Guess);
            this.Game.Controls.Add(this.InstanceId);
            this.Game.Controls.Add(this.labelInstanceId);
            this.Game.Controls.Add(this.labelGuess);
            this.Game.Controls.Add(this.EnterGuess);
            this.Game.Location = new System.Drawing.Point(17, 82);
            this.Game.Margin = new System.Windows.Forms.Padding(4);
            this.Game.Name = "Game";
            this.Game.Padding = new System.Windows.Forms.Padding(4);
            this.Game.Size = new System.Drawing.Size(464, 327);
            this.Game.TabIndex = 13;
            this.Game.TabStop = false;
            this.Game.Text = "Game";
            // 
            // WorkflowHostForm
            // 
            this.AcceptButton = this.EnterGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 453);
            this.Controls.Add(this.labelNumberRange);
            this.Controls.Add(this.NumberRange);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.labelWorkflowType);
            this.Controls.Add(this.WorkflowType);
            this.Controls.Add(this.WorkflowVersion);
            this.Controls.Add(this.Game);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkflowHostForm";
            this.Text = "WorkflowHostForm";
            this.Load += new System.EventHandler(this.WorkflowHostForm_Load);
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstanceId;
        private System.Windows.Forms.ComboBox InstanceId;
        private System.Windows.Forms.Label labelGuess;
        private System.Windows.Forms.TextBox Guess;
        private System.Windows.Forms.Button EnterGuess;
        private System.Windows.Forms.Button QuitGame;
        private System.Windows.Forms.TextBox WorkflowStatus;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label labelNumberRange;
        private System.Windows.Forms.ComboBox NumberRange;
        private System.Windows.Forms.Label labelWorkflowType;
        private System.Windows.Forms.ComboBox WorkflowType;
        private System.Windows.Forms.Label WorkflowVersion;
        private System.Windows.Forms.GroupBox Game;
    }
}