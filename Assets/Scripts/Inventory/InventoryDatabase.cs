using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class InventoryDatabase : MonoBehaviour
{
    public static InventoryDatabase Instance;

    private void Awake()
    {
        Instance = this;
    }
    public List<Item> Items;
    public List<Item> ToolItems;
    public List<Item> EquipmentItems;
    private void Start()
    {
        StartCoroutine(InventoryItems(1));
        StartCoroutine(InventoryItems(2));
        StartCoroutine(InventoryItems(3));
    }

    IEnumerator InventoryItems(int inventoryId)
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormDataSection("InventoryId", inventoryId.ToString()));
        using (UnityWebRequest request = UnityWebRequest.Post("inventoryx44.000webhostapp.com/Inventory.php",formData))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                switch (inventoryId)
                {
                    case 1:
                        ItemsDatabase(request.downloadHandler.text, Items, inventoryId);
                        break;
                    case 2:
                        ItemsDatabase(request.downloadHandler.text, ToolItems, inventoryId);
                        break;
                    case 3:
                        ItemsDatabase(request.downloadHandler.text, EquipmentItems, inventoryId);
                        break;
                }           
              
            }
            else
            {
                Debug.Log("error");

            }
        }
    }


    void ItemsDatabase(string data,List<Item> Item,int inventoryId)
    {
        Item.Clear();     
     
        for (int i = 0; i < data.Split("/").Length / 12; i++)
        {
            Item.Add(new Item(
                            data.Split("/")[i * 12]
                , data.Split("/")[1 + i * 12]
                , int.Parse(data.Split("/")[2 + i * 12])
                , int.Parse(data.Split("/")[3 + i * 12])
                , int.Parse(data.Split("/")[4 + i * 12])
                , int.Parse(data.Split("/")[5 + i * 12])
                , int.Parse(data.Split("/")[6 + i * 12])
      , (ItemType)int.Parse(data.Split("/")[7 + i * 12])
                , int.Parse(data.Split("/")[8 + i * 12])
                , int.Parse(data.Split("/")[9 + i * 12])
                , int.Parse(data.Split("/")[10 + i * 12])
                , float.Parse(data.Split("/")[11 + i * 12])));
        }


        for (int i = 0; i < Item.Count; i++)
        {
            Inventory.Instance.AddItem(Item[i].ItemId, inventoryId, Item);
        }
    }

    IEnumerator AddDatabaseInventoryItem(int itemId,int itemCount,int inventoryId)
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormDataSection("ItemId", itemId.ToString()));
        formData.Add(new MultipartFormDataSection("ItemCount", itemCount.ToString()));
        formData.Add(new MultipartFormDataSection("InventoryId", inventoryId.ToString()));

        using (UnityWebRequest request = UnityWebRequest.Post("inventoryx44.000webhostapp.com/AddInventoryItem.php",formData))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
          
                Debug.Log(request.downloadHandler.text);
                StartCoroutine(InventoryItems(1)); 
            }
            else
            {
                Debug.Log("error");

            }
        }
    }
   public void AddDatabaseItem(int itemId, int itemCount,  int inventoryId)
    {
        StartCoroutine(AddDatabaseInventoryItem(itemId, itemCount, inventoryId));
    }


    public void DbUpdateSlot()
    {
        StartCoroutine(DbUpdate());
    }

    IEnumerator DbUpdate()
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormDataSection("GetSlot", Inventory.Instance.GetSlot.ToString()));
        formData.Add(new MultipartFormDataSection("SetSlot", Inventory.Instance.SetSlot.ToString()));
        formData.Add(new MultipartFormDataSection("GetInventoryId", Inventory.Instance.GetInventoryId.ToString()));
        formData.Add(new MultipartFormDataSection("SetInventoryId", Inventory.Instance.SetInventoryId.ToString()));


        using (UnityWebRequest request = UnityWebRequest.Post("inventoryx44.000webhostapp.com/Inventory_Update.php", formData))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {

                Debug.Log(request.downloadHandler.text);
            }
            else
            {
                Debug.Log("error");

            }
        }
    }

    public void DbUpdateSlotCount(int itemCount, int inventoryId)
    {
        StartCoroutine(DbUpdateCount(itemCount, inventoryId));
    }

    IEnumerator DbUpdateCount(int itemCount, int inventoryId)
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormDataSection("SetSlot", Inventory.Instance.SetSlot.ToString()));
        formData.Add(new MultipartFormDataSection("ItemCount", itemCount.ToString()));
        formData.Add(new MultipartFormDataSection("InventoryId", inventoryId.ToString()));

        using (UnityWebRequest request = UnityWebRequest.Post("inventoryx44.000webhostapp.com/Inventory_Update_Count.php", formData))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {

                Debug.Log(request.downloadHandler.text);
            }
            else
            {
                Debug.Log("error");

            }
        }
    }

    public void DbRemoveSlot(int inventoryId)
    {
        StartCoroutine(RemoveSlot(inventoryId));
    }

    IEnumerator RemoveSlot(int inventoryId)
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormDataSection("GetSlot", Inventory.Instance.GetSlot.ToString()));
        formData.Add(new MultipartFormDataSection("InventoryId", inventoryId.ToString()));

        using (UnityWebRequest request = UnityWebRequest.Post("inventoryx44.000webhostapp.com/Inventory_Remove_Slot.php", formData))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {

                Debug.Log(request.downloadHandler.text);
            }
            else
            {
                Debug.Log("error");

            }
        }
    }

}
