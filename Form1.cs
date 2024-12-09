using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinder2EActionEvaluator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private actionEvaluatorClass evaluator;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.spellListBox.Items.Clear();
            this.evaluator = new actionEvaluatorClass();
            this.spellListBox.DataSource = new BindingSource(this.evaluator.getSpellNameList(), null);
            this.spellListBox.DisplayMember = "Key";

        }

        //This exists just to disentangle function from presentation.
        private void displayWarning(string message)
        {
            MessageBox.Show(message);
        }

        private void addNewEnemy(int a, int r, int f, int w)
        {
            this.evaluator.addEnemy(a, r, f, w);
            this.refreshDisplay();
        }

        private void simulateSpell(string spellName, int dc, int at, int runs)
        {
            //for the moment, hardcode as arcane, future versions may actually deal with tradition
            this.evaluator.assignSpell(spellName, dc, at, Tradition.Arcane);
            (double actions, double reactions) = this.evaluator.executeSimulation(runs);
            string printString = "" + actions + " actions \n" + reactions + " reactions";
            displaySimResult(printString);
        }

        private void displaySimResult(string result)
        {
            this.spellSimOutput.Text = result;
        }

        private void refreshDisplay()
        {
            this.CreatureDisplay.Text = "";
            //Fill in the Creature Display
            foreach (string creature in this.evaluator.getEnemyStatistics())
            {
                this.CreatureDisplay.Text += creature;
                this.CreatureDisplay.Text += "\r\n";
            }

        }

        private void clearEnemies()
        {
            this.evaluator.clearEnemies();
        }

        private void clearCreatureButton_Click(object sender, EventArgs e)
        {
            this.clearEnemies();
            this.CreatureDisplay.Text = "";
        }

        private void addCreatureButton_Click(object sender, EventArgs e)
        {
            int a, r, f, w;
            if (int.TryParse(creatureAC.Text, out a) && int.TryParse(creatureReflex.Text, out r) && int.TryParse(creatureFortitude.Text, out f) && int.TryParse(creatureWill.Text, out w))
            {
                this.addNewEnemy(a, r, f, w);
            }
            else
            {
                displayWarning("Oopsie! You did a heckin bad input! Integers only!");
            }
        }

        private void runSpellSimButton_Click(object sender, EventArgs e)
        {
            string spellName;
            int dc, at, runs;
            if (!int.TryParse(this.spellDeeCee.Text, out dc) || !int.TryParse(this.spellAttack.Text, out at) || !int.TryParse(this.numberOfRuns.Text, out runs))
            {
                displayWarning("Oopsie! You did a heckin bad input! Integers only!");
            }
            else
            {
                spellName = this.spellListBox.SelectedItem.ToString();
                simulateSpell(spellName, dc, at, runs);
            }
        }
    }
}