using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class ItemInv : ScriptableObject
{
    [Header("Основные характеристики")]
    public string Name = "Empty";
    public Sprite Icon = null;
    public int ItemCount = 1;

    public bool canEquip;
    public bool canUse;
    public bool canDrop;

    public string ItemDescription;

    public enum Rarity
    {
        Common,
        Rare,
        Unique,
        Legendary
    }
    public enum Class
    {
        Weapon,
        Armor,
        Accessories,

        Medication,

        Currency,

        Material,

        Other
    }

    public Rarity ItemRarity;

    public Class ItemClass;

}
