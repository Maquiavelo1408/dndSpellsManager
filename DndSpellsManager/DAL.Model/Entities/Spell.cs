﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model.Entities
{
    [Table("spell")]
    public class Spell
    {
        public Spell()
        {
            SpellSpellbooks = new HashSet<SpellSpellbook>();
            SpellMaterials = new HashSet<SpellMaterial>();
            SpellClasses = new HashSet<SpellClass>();
        }

        [Column("id_spell")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("level")]
        public int Level { get; set; }

        [Column("spell_type")]
        public SpellType SpellType { get; set; }

        [Column("deleted")]
        public bool Deleted { get; set; }

        [InverseProperty("Spell")]
        public ICollection<SpellSpellbook> SpellSpellbooks { get; set; }

        [InverseProperty("Spell")]
        public ICollection<SpellMaterial> SpellMaterials { get; set; }

        [InverseProperty("Spell")]
        public ICollection<SpellClass> SpellClasses { get; set; }
    }

    public enum SpellType
    {
        Damage = 1,
        Healing = 2,
        Utility = 3,
        Mobility = 4
    }
}
