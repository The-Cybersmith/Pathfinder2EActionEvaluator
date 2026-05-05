using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2EActionEvaluator
{
    //This class helps to disentanglerisificate the logic and UI layers
    //It could be a struct, but this makes it a bit more extensible, as
    //data that might be added in the future might make it unwieldly to
    //pass by value.
    record class simulationResultClass
    {
        public simulationResultClass(string SimulationName, DateTime SimulationTime, double AverageActions, double AverageReactions, int NumberOfRuns, int NumberOfTargets)
        {
            this.SimulationName = SimulationName;
            this.SimulationTime = SimulationTime;
            this.AverageActions = AverageActions;
            this.AverageReactions = AverageReactions;
            this.NumberOfRuns = NumberOfRuns;
            this.NumberOfTargets = NumberOfTargets;
        }

        public string SimulationName { get; init; } = string.Empty;
        public DateTime SimulationTime { get; init; }
        public double AverageActions { get; init; } = 0.0;
        public double AverageReactions { get; init; } = 0.0;
        public int NumberOfRuns { get; init; } = 1;
        public int NumberOfTargets { get; init; } = 1;
    }

    /*Not currently used, but might be useful at some point.
    record class spellSimulationResultClass : simulationResultClass
    {
        //Currently these are defaults/placeholders
        public Tradition Tradition { get; init; } = Tradition.Arcane;
        public int NumberOfActions { get; init; } = 2;
    }*/
}
