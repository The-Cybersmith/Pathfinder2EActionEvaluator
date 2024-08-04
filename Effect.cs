using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pathfinder2EActionEvaluator
{

    enum Result
    {
        CriticalSuccess,
        Success,
        Failure,
        CriticalFailure
    }

    class DeeTwenty
    {
        public static Result roll(int target, int modifier)
        {
            Random rnd = new Random();
            int die = rnd.Next(1, 21);

            bool nat20 = die == 20;
            bool nat1 = die == 1;

            die = die + modifier;
            
            if (die >= (target + 10)){
                if (nat1) { return Result.Success; } else { return Result.CriticalSuccess; }
            }else if (die >= target){
                if (nat20) { return Result.CriticalSuccess; } else if (nat1) { return Result.Failure; } else { return Result.Success; }
            }else if (die <= (target - 10)){
                if (nat20) { return Result.Failure; } else { return Result.CriticalFailure; }
            }else{
                if (nat20) { return Result.CriticalSuccess; } else if (nat1) { return Result.Failure; } else { return Result.Success; }
            }
        }
    }

    //I wish the version of C# I'm using had interfaces.
    class Creature
    {
        public Result attackAC(int toHit)
        {
            return DeeTwenty.roll(this.armour, toHit);
        }
        public Result hitReflex(int toHit)
        {
            return DeeTwenty.roll(this.armour, toHit);
        }
        public Result hitFortitude(int toHit)
        {
            return DeeTwenty.roll(this.armour, toHit);
        }
        public Result hitWill(int toHit)
        {
            return DeeTwenty.roll(this.armour, toHit);
        }
        public Result reflexSave(int deeCee)
        {
            return DeeTwenty.roll(deeCee, this.reflex);
        }

        private int armour;
        private int reflex;
        private int fortitude;
        private int will;
    }

    abstract class Effect
    {
        abstract public List<int> getAtionInvestments();

        //if this returns empty array, assume any number of targets is valid, such as a burst effect.
        abstract public List<int> getMaxTargets();

        abstract public float getActionCostForEnemies(List<Creature> enemies);

    }

    abstract class Spell : Effect
    {

    }

    class PhantasmalCalamity : Spell
    {
        //This is a burst, any number of targets is valid
        override public List<int> getMaxTargets()
        {
            return new List<int>();
        }

        //This spell always costs two actions to cast
        override public List<int> getAtionInvestments()
        {
            List<int> l = new List<int>();
            l.Add(2);
            return l;
        }



    }
}
