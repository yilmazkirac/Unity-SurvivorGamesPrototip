using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Item CurrentItem;
    public int ItemDamage, ItemArmor;
    public float ItemWeight;
    int currentItemIndex = -1;
    [SerializeField] private PlayerItemController _playerItemController;
    private void Update()
    {
       SetStats();
    }
    
    public void SellectItem(int currentItemIndex)
    {
        if (this.currentItemIndex == currentItemIndex)
        {
            this.currentItemIndex = -1;
            CurrentItem = new Item();
            _playerItemController.AllDeActiveTool();
        }
        else
        {
            this.currentItemIndex = currentItemIndex;
            CurrentItem = Inventory.Instance.ToolItems[currentItemIndex];
        }
        _playerItemController.SetTool(CurrentItem.ItemId.ToString());
    }
    private void SetStats()
    {
        ItemDamage = 0;
        ItemArmor = 0;

   
      

        ItemDamage += CurrentItem.ItemDamage;
        ItemArmor += CurrentItem.ItemArmor;


        foreach (var item in Inventory.Instance.EquipmentItems)
        {
            ItemDamage += item.ItemDamage;
            ItemArmor += item.ItemArmor;
        }

        UIManager.Instance.LvlText.text = "LEVEL : 99";
        UIManager.Instance.DamageText.text = " " + ItemDamage.ToString();
        UIManager.Instance.ArmorText.text = " " + ItemArmor.ToString();
        UIManager.Instance.HealthText.text = " 100";
        UIManager.Instance.NameText.text = "PLAYER";
        UIManager.Instance.ExpBar.value = 64;
    } 
}
