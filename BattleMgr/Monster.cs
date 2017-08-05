using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleMgr
{
    class Monster
    {
        public string name { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string alignment { get; set; }
        public int armor_class { get; set; }
        public int hit_points { get; set; }
        public string hit_dice { get; set; }
        public string speed { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; } 
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
        public string damage_vulnerabilities { get; set; }
        public string damage_resistances { get; set; }
        public string damage_immunities { get; set; }
        public string condition_immunities { get; set; }
        public string senses { get; set; }
        public string languages { get; set; }
        public double challenge_rating { get; set; }
        public string notes { get; set; }
        public List<SpecialAbility> special_abilities { get; set; }
        public List<Action> actions { get; set; }
        public List<LegendaryAction> legendary_actions { get; set; }
                
    }
    
    class SpecialAbility
    {
        public int attack_bonus { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
    }
    
    class Action
    {
        public int attack_bonus { get; set; }
        public int damage_bonus { get; set; }
        public string damage_dice { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
    }
    
    class LegendaryAction
    {
        public int attack_bonus { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
    }
}
