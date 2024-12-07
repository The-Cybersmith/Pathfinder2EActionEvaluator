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
            return DeeTwenty.roll(this.reflex+10, toHit);
        }
        public Result hitFortitude(int toHit)
        {
            return DeeTwenty.roll(this.fortitude+10, toHit);
        }
        public Result hitWill(int toHit)
        {
            return DeeTwenty.roll(this.will+10, toHit);
        }
        public Result reflexSave(int deeCee)
        {
            return DeeTwenty.roll(deeCee, this.reflex);
        }
        public Result willSave(int deeCee)
        {
            return DeeTwenty.roll(deeCee, this.will);
        }
        public Result fortitudeSave(int deeCee)
        {
            return DeeTwenty.roll(deeCee, this.fortitude);
        }

        private int armour;
        private int reflex;
        private int fortitude;
        private int will;

        public Creature (int a, int r, int f, int w)
        {
            this.armour = a;
            this.reflex = r;
            this.fortitude = f;
            this.will = w;
        }
    }

    abstract class Effect
    {
        abstract public List<int> getAtionInvestments();

        //if this returns empty array, assume any number of targets is valid, such as a burst effect.
        abstract public List<int> getMaxTargets();

        //Runs a single instance on a single enemy group. If a statistical model is needed, run multiple
        //times, and take an average. Always returns integers, because there is no half-action. Actions and
        //reactions are returned separately.
        abstract public (int actions, int reactions) simulateActionCostForEnemies(List<Creature> enemies);

    }

    enum Tradition
    {
        Arcane,
        Occult,
        Primal,
        Divine,
        Elemental
    }

    abstract class Spell : Effect
    {
        protected int spellDeeCee;
        protected int spellAttack;
        protected Tradition trad;
        public Spell(int dc, int at, Tradition t)
        {
            this.spellDeeCee = dc;
            this.spellAttack = at;
            this.trad = t;
        }
    }

    class PhantasmalCalamity : Spell
    {
        //Pretty Boilerplate, nothing special to specify
        public PhantasmalCalamity(int dc, int at, Tradition t) : base(dc, at, t)
        {
        }

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

        override public (int actions, int reactions) simulateActionCostForEnemies(List<Creature> enemies)
        {
            int actions = 0;
            int reactions = 0;

            foreach (Creature c in enemies){
                Result r = c.reflexSave(this.spellDeeCee);
                Result w = c.willSave(this.spellDeeCee);
                if (w == Result.CriticalFailure && (r == Result.CriticalFailure || r == Result.Failure))
                {
                    actions += 3;
                    reactions += 1;

                    //now the subsequent saves, up to 9 of them (spell only lasts 1 minute)
                    for (int i = 1; i < 10; i++)
                    {
                        w = c.willSave(this.spellDeeCee);
                        if (w == Result.CriticalFailure || w == Result.Failure)
                        { actions += 3;reactions += 1; } else { break; }
                    }
                }
            }

            return (actions, reactions);
        }

    }
}
