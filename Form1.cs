using System.Collections.Generic;

namespace Pathfinder2EActionEvaluator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.currentEffect = null;
            this.setUpTypes();
            this.spellListBox.Items.Clear();
            this.spellListBox.DataSource = new BindingSource(this.spells, null);
            this.spellListBox.DisplayMember = "Key";
            this.spellListBox.ValueMember = "Value";

        }

        private void setUpTypes()
        {
            var baseType = typeof(Spell);
            var assembly = baseType.Assembly;
            this.spells = new Dictionary<string, Type>();
            foreach (Type s in assembly.GetTypes().Where(t => t.IsSubclassOf(baseType)))
            {
                this.spells[s.Name] = s;
            }
        }

        private void addNewEnemy()
        {
            int a = 0;
            int r = 0;
            int f = 0;
            int w = 0;

            if (int.TryParse(creatureAC.Text, out a) && int.TryParse(creatureReflex.Text, out r) && int.TryParse(creatureFortitude.Text, out f) && int.TryParse(creatureWill.Text, out w))
            {
                Creature c = new Creature(a, r, f, w);

            }
            else
            {
                MessageBox.Show("Oopsie! You did a heckin bad input! Integers only!");
            }
        }

        private void simulateSpell()
        {

        }

        private void outputSpellSimulationResult(int runs, float result)
        {

        }

        private void clearEnemies()
        {
            this.CreatureDisplay.Clear();
        }

        private Spell currentEffect;
        private List<Creature> currentEnemies;
        private Dictionary<string, Type> spells;

    }
}