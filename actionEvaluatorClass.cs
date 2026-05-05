using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2EActionEvaluator
{
    //To limit interface entangling, this is its own separate class.
    class actionEvaluatorClass
    {
        //this allows the program to "lazily" delay instantiation until needed, speeding up loading.
        private static readonly Lazy<actionEvaluatorClass> InstanceInWaiting = new Lazy<actionEvaluatorClass>(() => new actionEvaluatorClass());
        //This ensures the class will operate as a singleton, there should never be two copies of it
        public static actionEvaluatorClass Instance = InstanceInWaiting.Value;

        private Spell? currentEffect;
        private List<Creature> currentEnemies;
        private Dictionary<string, Type> spells;

        private actionEvaluatorClass()
        {
            var baseType = typeof(Spell);
            var assembly = baseType.Assembly;
            this.spells = new Dictionary<string, Type>();
            foreach (Type s in assembly.GetTypes().Where(t => t.IsSubclassOf(baseType)))
            {
                this.spells[s.Name] = s;
            }
            this.currentEnemies = new List<Creature>();

        }

        public List<string> getEnemyStatistics()
        {
            List<string> retList = new List<string>();
            foreach (Creature c in this.currentEnemies)
            {
                retList.Add(c.getStatistics());
            }
            return retList;
        }

        public void addEnemy(int a, int r, int f, int w)
        {
            this.currentEnemies.Add(new Creature(a, r, f, w));
        }

        public void clearEnemies()
        {
            this.currentEnemies.Clear();
        }

        public List<string> getSpellNameList()
        {
            return spells.Keys.ToList();
        }

        //set the current spell
        public void assignSpell(string name, int dc, int at, Tradition t)
        {
            Type type = spells[name];
            if (type != null)
            {
                object[] paramArray = { dc, at, t };
                this.currentEffect = (Spell)Activator.CreateInstance(type, paramArray);
            }
        }

        //run a set number of times, and take an average
        public simulationResultClass executeSimulation(int runs)
        {
            double actions = 0.0;
            double reactions = 0.0;
            if (runs > 0 && this.currentEffect != null)
            {
                (double t1, double t2) temps = (0.0, 0.0);
                for (int i = 0; i < runs; i++)
                {
                    temps = currentEffect.simulateActionCostForEnemies(currentEnemies);
                    actions += temps.t1;
                    reactions += temps.t2;
                }
                actions = actions / (double) runs;
                reactions = reactions / (double)runs;
            }
            simulationResultClass output = new(SimulationName : "Placeholder", SimulationTime : DateTime.Now, AverageActions : actions, AverageReactions : reactions, NumberOfRuns : runs, NumberOfTargets : currentEnemies.Count);
            return output;
        }

    }

}
