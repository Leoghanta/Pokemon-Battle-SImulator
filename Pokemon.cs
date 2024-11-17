using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_SImulator
{
    /// <summary>
    /// Pokemon Class
    /// </summary>
    public abstract class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public bool IsDefeated {
            get {
                if (HP > 0) {
                    return false;
                }
                else {
                    return true;
                }
             }
            set
            {
                return;
            }
        }

        public Pokemon(string name, string type, int maxHP)
        {
            Name = name;
            Type = type;
            MaxHP = maxHP;
            HP = maxHP;
        }

        public void DisplayPokemon()
        {
            Console.WriteLine($"{Name} - Type: {Type} | HP: {HP}/{MaxHP}");
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;
            if (HP < 0)
            {
                HP = 0;
            }
            Console.WriteLine($"{Name} takes {damage} damage! Remaining HP: {HP}");
        }
    }
}
