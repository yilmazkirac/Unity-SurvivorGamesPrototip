using System;
using UnityEngine;
[Serializable]
public class Item 
{
    public string ItemName;
    public string ItemDescription;
    public int ItemId, ItemCount, ItemMaxCount, ItemDamage, ItemArmor, SlotIndex, MaxItemDurability, CurrentItemDurability;
    public float ItemWeight;
    public Sprite ItemSprite;
    public ItemType ItemType;

    public Item(string itemName, string itemDescription, int itemId, int itemCount, int itemMaxCount, int itemDamage, int itemArmor, ItemType itemType, int slotIndex,int maxItemDurability,int currentItemDurability,float itemWeight)
    {
        ItemName = itemName;
        ItemDescription = itemDescription;
        ItemId = itemId;
        ItemCount = itemCount;
        ItemMaxCount = itemMaxCount;
        ItemDamage = itemDamage;
        ItemArmor = itemArmor;
        ItemType = itemType;
        SlotIndex = slotIndex;
        MaxItemDurability = maxItemDurability;
        CurrentItemDurability = currentItemDurability;
        ItemWeight = itemWeight;

        ItemSprite = Resources.Load<Sprite>("Items/" + itemId.ToString());
    }
    public Item()
    {

    }
}
