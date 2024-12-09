namespace Pathfinder2EActionEvaluator
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
            addCreatureButton = new Button();
            spellListBox = new ListBox();
            label1 = new Label();
            creatureEntryBox = new GroupBox();
            clearCreatureButton = new Button();
            CreatureDisplay = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            creatureWill = new TextBox();
            creatureReflex = new TextBox();
            creatureFortitude = new TextBox();
            creatureAC = new TextBox();
            spellDeeCee = new TextBox();
            label6 = new Label();
            spellAttack = new TextBox();
            label7 = new Label();
            numberOfRuns = new TextBox();
            label8 = new Label();
            runSpellSimButton = new Button();
            spellSimOutput = new TextBox();
            creatureEntryBox.SuspendLayout();
            SuspendLayout();
            // 
            // addCreatureButton
            // 
            addCreatureButton.Location = new Point(256, 22);
            addCreatureButton.Name = "addCreatureButton";
            addCreatureButton.Size = new Size(77, 39);
            addCreatureButton.TabIndex = 1;
            addCreatureButton.Text = "Add Creature";
            addCreatureButton.UseVisualStyleBackColor = true;
            addCreatureButton.Click += addCreatureButton_Click;
            // 
            // spellListBox
            // 
            spellListBox.FormattingEnabled = true;
            spellListBox.ItemHeight = 15;
            spellListBox.Location = new Point(12, 27);
            spellListBox.Name = "spellListBox";
            spellListBox.Size = new Size(140, 214);
            spellListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Spell List";
            // 
            // creatureEntryBox
            // 
            creatureEntryBox.Controls.Add(clearCreatureButton);
            creatureEntryBox.Controls.Add(CreatureDisplay);
            creatureEntryBox.Controls.Add(label5);
            creatureEntryBox.Controls.Add(label4);
            creatureEntryBox.Controls.Add(label3);
            creatureEntryBox.Controls.Add(label2);
            creatureEntryBox.Controls.Add(creatureWill);
            creatureEntryBox.Controls.Add(creatureReflex);
            creatureEntryBox.Controls.Add(creatureFortitude);
            creatureEntryBox.Controls.Add(creatureAC);
            creatureEntryBox.Controls.Add(addCreatureButton);
            creatureEntryBox.Location = new Point(12, 259);
            creatureEntryBox.Name = "creatureEntryBox";
            creatureEntryBox.Size = new Size(339, 179);
            creatureEntryBox.TabIndex = 4;
            creatureEntryBox.TabStop = false;
            creatureEntryBox.Text = "Creature Entry Box";
            // 
            // clearCreatureButton
            // 
            clearCreatureButton.Location = new Point(285, 79);
            clearCreatureButton.Name = "clearCreatureButton";
            clearCreatureButton.Size = new Size(46, 94);
            clearCreatureButton.TabIndex = 13;
            clearCreatureButton.Text = "Clear All Foes";
            clearCreatureButton.UseVisualStyleBackColor = true;
            clearCreatureButton.Click += clearCreatureButton_Click;
            // 
            // CreatureDisplay
            // 
            CreatureDisplay.Location = new Point(6, 79);
            CreatureDisplay.Multiline = true;
            CreatureDisplay.Name = "CreatureDisplay";
            CreatureDisplay.ReadOnly = true;
            CreatureDisplay.ScrollBars = ScrollBars.Vertical;
            CreatureDisplay.Size = new Size(273, 94);
            CreatureDisplay.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 19);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 12;
            label5.Text = "Will";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 19);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Reflex";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 19);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Fortitude";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 9;
            label2.Text = "AC";
            // 
            // creatureWill
            // 
            creatureWill.Location = new Point(192, 38);
            creatureWill.Name = "creatureWill";
            creatureWill.Size = new Size(56, 23);
            creatureWill.TabIndex = 8;
            // 
            // creatureReflex
            // 
            creatureReflex.Location = new Point(130, 38);
            creatureReflex.Name = "creatureReflex";
            creatureReflex.Size = new Size(56, 23);
            creatureReflex.TabIndex = 7;
            // 
            // creatureFortitude
            // 
            creatureFortitude.Location = new Point(68, 38);
            creatureFortitude.Name = "creatureFortitude";
            creatureFortitude.Size = new Size(56, 23);
            creatureFortitude.TabIndex = 6;
            // 
            // creatureAC
            // 
            creatureAC.Location = new Point(6, 38);
            creatureAC.Name = "creatureAC";
            creatureAC.Size = new Size(56, 23);
            creatureAC.TabIndex = 5;
            // 
            // spellDeeCee
            // 
            spellDeeCee.Location = new Point(158, 46);
            spellDeeCee.Name = "spellDeeCee";
            spellDeeCee.Size = new Size(56, 23);
            spellDeeCee.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 28);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 14;
            label6.Text = "Spell DC";
            // 
            // spellAttack
            // 
            spellAttack.Location = new Point(220, 46);
            spellAttack.Name = "spellAttack";
            spellAttack.Size = new Size(56, 23);
            spellAttack.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 27);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 16;
            label7.Text = "Attack";
            // 
            // numberOfRuns
            // 
            numberOfRuns.Location = new Point(282, 46);
            numberOfRuns.Name = "numberOfRuns";
            numberOfRuns.Size = new Size(56, 23);
            numberOfRuns.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(282, 27);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 18;
            label8.Text = "# of runs";
            // 
            // runSpellSimButton
            // 
            runSpellSimButton.Location = new Point(158, 75);
            runSpellSimButton.Name = "runSpellSimButton";
            runSpellSimButton.Size = new Size(178, 60);
            runSpellSimButton.TabIndex = 14;
            runSpellSimButton.Text = "Run Spell Simulation";
            runSpellSimButton.UseVisualStyleBackColor = true;
            runSpellSimButton.Click += runSpellSimButton_Click;
            // 
            // spellSimOutput
            // 
            spellSimOutput.Location = new Point(158, 147);
            spellSimOutput.Multiline = true;
            spellSimOutput.Name = "spellSimOutput";
            spellSimOutput.ReadOnly = true;
            spellSimOutput.ScrollBars = ScrollBars.Vertical;
            spellSimOutput.Size = new Size(178, 94);
            spellSimOutput.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(spellSimOutput);
            Controls.Add(runSpellSimButton);
            Controls.Add(label8);
            Controls.Add(numberOfRuns);
            Controls.Add(label7);
            Controls.Add(spellAttack);
            Controls.Add(label6);
            Controls.Add(spellDeeCee);
            Controls.Add(creatureEntryBox);
            Controls.Add(label1);
            Controls.Add(spellListBox);
            Name = "Form1";
            Text = "PF2E Action Evaluator by Cybersmith";
            Load += Form1_Load;
            creatureEntryBox.ResumeLayout(false);
            creatureEntryBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addCreatureButton;
        private ListBox spellListBox;
        private Label label1;
        private GroupBox creatureEntryBox;
        private Label label2;
        private TextBox creatureWill;
        private TextBox creatureReflex;
        private TextBox creatureFortitude;
        private TextBox creatureAC;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button clearCreatureButton;
        private TextBox CreatureDisplay;
        private TextBox spellDeeCee;
        private Label label6;
        private TextBox spellAttack;
        private Label label7;
        private TextBox numberOfRuns;
        private Label label8;
        private Button runSpellSimButton;
        private TextBox spellSimOutput;
    }
}