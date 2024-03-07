using UnityEngine;

public class GetItem : MonoBehaviour, ICommand
{
    public int ItemId;
    public int ItemCount;

    public void Execute()
    {
        InventoryDatabase.Instance.AddDatabaseItem(ItemId, ItemCount,1);
        Destroy(gameObject);
    }  
}
