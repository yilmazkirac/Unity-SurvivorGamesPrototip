using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public Image ItemSprite;
    [SerializeField] private GameObject ItemWeight;
    [SerializeField] private TextMeshProUGUI ItemCountText;
    [SerializeField] private Slider ItemDurabilityCount;

    public Item Item;
    public int SlotIndex;

    public Inventory Inventory;

    public int InventoryId;

    public int ItemType;
    public int ItemType2;
    public int ItemType3;
    public int ItemType4;
    private void Start()
    {
        Inventory = Inventory.Instance;
    }
    private void Update()
    {
        SetItem();
    }

    private void SetItem()
    {
        if (InventoryId == 1)
        {
            Item = Inventory.Items[SlotIndex];
        }
        else if (InventoryId == 2)
        {
            Item = Inventory.ToolItems[SlotIndex];
        }
        else if (InventoryId == 3)
        {
            Item = Inventory.EquipmentItems[SlotIndex];
        }

        if (Item.ItemName != null)
        {
            if (Item.ItemType==global::ItemType.Use || Item.ItemType == global::ItemType.Consumable)
            {
                ItemCountText.enabled = true;
            }
            else
            {
                ItemCountText.enabled = false;
            }
            ItemSprite.enabled = true;          
            ItemWeight.SetActive(true);
            ItemWeight.GetComponentInChildren<TextMeshProUGUI>().text = Item.ItemWeight.ToString();
            ItemSprite.sprite = Item.ItemSprite;
            ItemCountText.text = Item.ItemCount.ToString();            
        }


        else
        {
            ItemSprite.enabled = false;
            ItemCountText.enabled = false;
            ItemWeight.SetActive(false);
            ItemDurabilityCount.enabled = false;
        }
    }
    private void SetItems()
    {
        Inventory.ItemDragItem = new Item();
        Inventory.DeActiveDragObject();
        Inventory.SetSlot = SlotIndex;
        Inventory.SetInventoryId = InventoryId;
        InventoryDatabase.Instance.DbUpdateSlot();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (!Inventory.IsItemDrag && Item.ItemName != null)
            {
                Debug.Log(Item.ItemName);
                if (InventoryId == 1)
                {
                    Inventory.Items[SlotIndex] = Inventory.ItemDragItem;
                    Inventory.Items[SlotIndex] = new Item();
                }

                else if (InventoryId == 2)
                {
                    Inventory.ToolItems[SlotIndex] = Inventory.ItemDragItem;
                    Inventory.ToolItems[SlotIndex] = new Item();
                }
                else if (InventoryId == 3)
                {
                    Inventory.EquipmentItems[SlotIndex] = Inventory.ItemDragItem;
                    Inventory.EquipmentItems[SlotIndex] = new Item();
                }
                Inventory.ActiveDragObject(Item);
                Inventory.GetSlot = SlotIndex;
                Inventory.GetInventoryId = InventoryId;
            }
            else
            {       
                if (Item.ItemName == null&& Inventory.IsItemDrag)
                {
                    if (InventoryId == 1)
                    {
                        Inventory.Items[SlotIndex] = Inventory.ItemDragItem;
                        SetItems();
                    }

                    else if (InventoryId == 2)
                    {

                        if (Inventory.Instance.ItemDragItem.ItemType == (ItemType)ItemType)
                        {
                            Inventory.ToolItems[SlotIndex] = Inventory.ItemDragItem;
                            SetItems();
                        }
                        else if (Inventory.Instance.ItemDragItem.ItemType == (ItemType)ItemType2)
                        {
                            Inventory.ToolItems[SlotIndex] = Inventory.ItemDragItem;
                            SetItems();
                        }
                        else if (Inventory.Instance.ItemDragItem.ItemType == (ItemType)ItemType3)
                        {
                            Inventory.ToolItems[SlotIndex] = Inventory.ItemDragItem;
                            SetItems();
                        }
                        else if (Inventory.Instance.ItemDragItem.ItemType == (ItemType)ItemType4)
                        {
                            Inventory.ToolItems[SlotIndex] = Inventory.ItemDragItem;
                            SetItems();
                        }


                    }
                    else if (InventoryId == 3)
                    {
                        if (Inventory.Instance.ItemDragItem.ItemType == (ItemType)ItemType)
                        {
                            Inventory.EquipmentItems[SlotIndex] = Inventory.ItemDragItem;
                            SetItems();
                        }                     
                    }
               
                }
                else if (Inventory.IsItemDrag&& Item.ItemName == Inventory.ItemDragItem.ItemName&&Item.ItemMaxCount>1)
                {
                    Inventory.Items[SlotIndex].ItemCount += Inventory.ItemDragItem.ItemCount;
                    Inventory.SetSlot = SlotIndex;
                    Inventory.SetInventoryId = InventoryId;
                    Inventory.ItemDragItem = new Item();
                    Inventory.DeActiveDragObject();
                    InventoryDatabase.Instance.DbRemoveSlot(Inventory.Instance.GetInventoryId);
                    InventoryDatabase.Instance.DbUpdateSlotCount(Inventory.Items[SlotIndex].ItemCount, Inventory.Instance.SetInventoryId);
                }
            }
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
     
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
