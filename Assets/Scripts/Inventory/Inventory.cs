using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public static Inventory Instance;

    private void Awake()
    {
        Instance = this;
    }

    public List<Item> Items;
    public List<Item> ToolItems;
    public List<Item> EquipmentItems;

    public InventoryDatabase ItemDatabase;
    public GameObject  DragItem;
    public bool IsItemDrag;
    public Item ItemDragItem;


    public int GetSlot, SetSlot;

    public int GetInventoryId, SetInventoryId;

    public Transform ToolInventory,EquipmentInventory;

    public const int InventoryId=1;
    public const int ToolInventoryId = 2;
    public const int EquipmentInventoryId = 3;

    private void Start()
    {
        for (int i = 0; i < 42; i++)
        {
            GameObject slots = Instantiate(Resources.Load<GameObject>("Item"));
            slots.transform.SetParent(transform);
            slots.GetComponent<InventorySlot>().SlotIndex = i;
            slots.GetComponent<InventorySlot>().InventoryId = InventoryId;
            slots.GetComponent<InventorySlot>().ItemType = 0;
            slots.name = "Slot " + i;
            Items.Add(new Item());
        }
        for (int i = 0; i < 4; i++)
        {
            GameObject slots = Instantiate(Resources.Load<GameObject>("Item"));
            slots.transform.SetParent(ToolInventory);
            slots.GetComponent<InventorySlot>().SlotIndex = i;
            slots.GetComponent<InventorySlot>().InventoryId = ToolInventoryId;
            slots.GetComponent<InventorySlot>().ItemType = 1;
            slots.GetComponent<InventorySlot>().ItemType2 = 8;
            slots.GetComponent<InventorySlot>().ItemType3 = 9;
            slots.GetComponent<InventorySlot>().ItemType4 = 10;
            slots.name = "Slot " + i;
            ToolItems.Add(new Item());
        }
        for (int i = 0; i < 4; i++)
        {
            GameObject slots = Instantiate(Resources.Load<GameObject>("Item"));
            slots.transform.SetParent(EquipmentInventory);
            slots.GetComponent<InventorySlot>().SlotIndex = i;
            slots.GetComponent<InventorySlot>().InventoryId = EquipmentInventoryId;
            slots.GetComponent<InventorySlot>().ItemType = 4+i;
            slots.name = "Slot " + i;
            EquipmentItems.Add(new Item());
        }
        UIManager.Instance.InventoryPanel.SetActive(false);
    }
    private void Update()
    {
        if (IsItemDrag)
        {
            DragItem.transform.GetChild(0).GetComponent<Image>().sprite = ItemDragItem.ItemSprite;
            DragItem.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = ItemDragItem.ItemCount.ToString();
            DragItem.gameObject.GetComponent<RectTransform>().position = Input.mousePosition;
        }
    }
    public void AddItem(int id,int inventoryId,List<Item> Item)
    {
        for (int i = 0; i < Item.Count; i++)
        {
            if (Item[i].ItemId == id)
            {
                Item item = new Item(Item[i].ItemName, Item[i].ItemDescription, Item[i].ItemId, Item[i].ItemCount
                    , Item[i].ItemMaxCount, Item[i].ItemDamage, Item[i].ItemArmor, Item [i].ItemType, Item[i].SlotIndex, Item[i].MaxItemDurability
                    , Item[i].CurrentItemDurability, Item[i].ItemWeight);
                switch (inventoryId)
                {
                    case 1:
                        AddInventory(item, Items);
                        break;
                    case 2:
                        AddInventory(item, ToolItems);
                        break;
                    case 3:
                        AddInventory(item, EquipmentItems);
                        break;
                }
            
            }
        }
    }

    /// <summary>
    /// Inventory'a item ekler
    /// </summary>
    /// <param name="item"></param>
    /// <param name="Item"></param>
    public void AddInventory(Item item,List<Item> Item)
    {
        for (int i = 0; i < Item.Count; i++)
        {
            if (Item[i].ItemName == null)
            {
               
                if (item.ItemCount >= 1)
                {
                    if (item.SlotIndex == i)
                    {
                        Item[i] = item;
                        return;
                    }
                }
            }
        }
    }


    public void IsNullSlot(Item item)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].ItemType == ItemType.None && Items[i].ItemName == null)
            {
                Items[i] = item;
                break;
            }
        }
    }

    public void ItemStack(Item item)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].ItemId == item.ItemId)
            {
                Items[i].ItemCount += item.ItemCount;
                break;
            }
            else if (i == Items.Count - 1)
            {
                IsNullSlot(item);
                break;
            }
        }
    }

    public void ActiveDragObject(Item item)
    {
        ItemDragItem = item;
        IsItemDrag = true;
        DragItem.SetActive(true);
    }
    public void DeActiveDragObject()
    {
        ItemDragItem = null;
        IsItemDrag = false;
        DragItem.SetActive(false);
    }

}

