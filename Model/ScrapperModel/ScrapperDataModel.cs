using System.Collections.Generic;

namespace FFXIVApp.Model.ScrapperModel
{
    public class Bonuses_DataClass
    {
        // Main Stats
        public int? Strength { get; set; }
        public int? Intelligence { get; set; }
        public int? Dexterity { get; set; }
        public int? Mind { get; set; }

        // Bonus Stats
        public int? Vitality { get; set; }
        public int? Critical_hit { get; set; }
        public int? Direct_Hit_Rate { get; set; }
        public int? Determination { get; set; }
        public int? Skill_Speed { get; set; }
        public int? Spell_Speed { get; set; }
        public int? Piety { get; set; }
        public int? Tenacity { get; set; }

        // DOH/DOL Bonus Stats
        public int? Control { get; set; }
        public int? Craftsmanship { get; set; }
        public int? CP { get; set; }
        public int? Gathering { get; set; }
        public int? Perception { get; set; }
        public int? GP { get; set; }
    }

    public class CraftingRepairs_DataClass
    {
        public string? Repair_level { get; set; }
        public string? Materials { get; set; }
        public string? Materia_melding { get; set; }
        public bool Extractable { get; set; }
        public bool Projectable { get; set; }
        public bool Desynthesizable { get; set; }
        public bool Dyable { get; set; }
    }

    public class Effects_DataClass
    {
        // Main Stats
        public string? Strength { get; set; }
        public string? Intelligence { get; set; }
        public string? Dexterity { get; set; }
        public string? Mind { get; set; }

        // Bonus Stats
        public string? Direct_Hit_Rate { get; set; }
        public string? Vitality { get; set; }
        public string? Determination { get; set; }
        public string? Critical_hit { get; set; }
        public string? Skill_Speed { get; set; }
        public string? Spell_Speed { get; set; }
        public string? Piety { get; set; }
        public string? Tenacity { get; set; }
    }

    public class ArmsToolsArmorAccessories_DataClass
    {
        public string? TypeClassification { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public List<string>? Classes_jobs { get; set; }
        public int Item_level { get; set; }
        public bool Unique { get; set; }
        public bool Tradeable { get; set; }
        public bool Company_crests { get; set; }
        public bool Glamour_dresser { get; set; }
        public bool Armoire { get; set; }
        public int Physical_damage { get; set; }
        public double Auto_attack { get; set; }
        public double Delay { get; set; }
        public Bonuses_DataClass? Bonuses { get; set; }
        public int Materiaslots { get; set; }
        public CraftingRepairs_DataClass? Crafting_repairs { get; set; }
        public bool Advanced_melding { get; set; }
        public bool Available_purchase { get; set; }
        public bool Purchasable { get; set; }
        public bool Sellable { get; set; }
        public List<string>? Aquired_from { get; set; }
    }

    public class MedicineMeals_DataClass
    {
        public string? TypeClassification { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Item_level { get; set; }
        public bool Tradeable { get; set; }
        public bool Company_crests { get; set; }
        public bool Glamour_dresser { get; set; }
        public bool Armoire { get; set; }
        public bool Available_purchase { get; set; }
        public bool Market_prohitibited { get; set; }
        public int Recast { get; set; }
        public Effects_DataClass? Effects { get; set; }
        public string? Description { get; set; }
        public bool Purchasable { get; set; }
        public bool Sellable { get; set; }
        public int? SalePrice { get; set; }
        public int? SellsPrice { get; set; }
        public List<string>? ObtainedFrom { get; set; }
    }

    public class Materials_DataClass
    {
        public string? TypeClassification { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public bool Unique { get; set; }
        public bool Tradeable { get; set; }
        public bool Company_crests { get; set; }
        public bool Glamour_dresser { get; set; }
        public bool Armoire { get; set; }
        public string? Description { get; set; }
        public bool Purchasable { get; set; }
        public bool Sellable { get; set; }
        public int? SalePrice { get; set; }
        public int? SellsPrice { get; set; }
        public bool Market_prohitibited { get; set; }
        public List<string>? ObtainedFrom { get; set; }
    }

    public class Other_DataClass
    {
        public string? TypeClassification { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public bool Unique { get; set; }
        public bool Tradeable { get; set; }
        public bool Company_crests { get; set; }
        public bool Glamour_dresser { get; set; }
        public bool Armoire { get; set; }
        public string? Description { get; set; }
        public bool Purchasable { get; set; }
        public bool Sellable { get; set; }
        public int? SalePrice { get; set; }
        public int? SellsPrice { get; set; }
        public bool Market_prohitibited { get; set; }
        public List<string>? ObtainedFrom { get; set; }
    }

    public class ArmsToolsArmorAccessories
    {
        public ArmsToolsArmorAccessories_DataClass? Item { get; set; }
    }

    public class MedicinesMeals
    {
        public MedicineMeals_DataClass? Item { get; set; }
    }

    public class Materials
    {
        public Materials_DataClass? Item { get; set; }
    }

    public class Other
    {
        public Other_DataClass? Item { get; set; }
    }

    public class Items
    {
        public ArmsToolsArmorAccessories? ItemType_Arms { get; set; }
        public Materials? ItemType_Materials { get; set; }
        public MedicinesMeals? ItemType_Medicines { get; set; }
        public Other? ItemType_Other { get; set; }
    }

    public partial class ScrapperData
    {
        public Items? Items { get; set; }

        private string? _activeCategory;

        public string? ActiveCategory
        {
            get { return _activeCategory; }
            set { _activeCategory = CheckActiveCategory(value!); }
        }

    }
}
