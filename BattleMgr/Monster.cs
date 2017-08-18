using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleMgr
{
    public class Monster
    {
        public string name { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string alignment { get; set; }
        public int armor_class { get; set; }
        public int hit_points { get; set; }
        public int currHP { get; set; }
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

        public Monster()
        {

        }

        public Monster(Monster m)
        {
            name = m.name;
            size = m.size;
            type = m.type;
            subtype = m.subtype;
            alignment = m.alignment;
            armor_class = m.armor_class;
            hit_points = m.hit_points;
            currHP = m.hit_points;
            hit_dice = m.hit_dice;
            speed = m.speed;
            strength = m.strength;
            dexterity = m.dexterity;
            constitution = m.constitution;
            intelligence = m.intelligence;
            wisdom = m.wisdom;
            charisma = m.charisma;
            damage_vulnerabilities = m.damage_vulnerabilities;
            damage_resistances = m.damage_resistances;
            damage_immunities = m.damage_immunities;
            condition_immunities = m.condition_immunities;
            senses = m.senses;
            languages = m.languages;
            challenge_rating = m.challenge_rating;
            notes = m.notes;
            special_abilities = m.special_abilities;
            actions = m.actions;
            legendary_actions = m.legendary_actions;
        }
                
    }
    
    public class SpecialAbility
    {
        public int attack_bonus { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
        public string print()
        {
            return name + ": attack bonus: " + attack_bonus + Environment.NewLine + desc;
        }
    }
    
    public class Action
    {
        public int attack_bonus { get; set; }
        public int damage_bonus { get; set; }
        public string damage_dice { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
        public string print()
        {
            return name + ": attack bonus: " + attack_bonus + " damage bonus: " + damage_bonus + " damage dice: " + damage_dice + Environment.NewLine + desc;
        }
    }
    
    public class LegendaryAction
    {
        public int attack_bonus { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
        public string print()
        {
            return name + ": attack bonus: " + attack_bonus + Environment.NewLine + desc;
        }
    }
}
