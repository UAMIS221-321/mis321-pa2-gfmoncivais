using System;
using mis321_pa2_gfmoncivais.Interfaces;

namespace mis321_pa2_gfmoncivais
{
    public class Character
    {
        public string CharacterName{get;set;}
        public int MaxPower{get;set;}
        public int Health{get;set;}
        public int AttackStrength{get;set;}
        public int DefensiveBehavior{get;set;}

        //interface thingy: attack
        public IAttack attackBehavior {get;set;}
        // interface thingy : defend
        public IDefend defendBehavior {get;set;}
        public Character()
        {
            //interface thingy
            attackBehavior = new IAttack();
            defendBehavior = new IDefend();
        }
        public void SetAttackBehavior(IAttack attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }
        public void SetDefendBehavior(IDefend defendBehavior)
        {
            this.defendBehavior = defendBehavior;
        }
        
    }
}
