using UnityEngine;

public class PlayerItemController : MonoBehaviour
{
    
    [SerializeField] private Transform _R_Tool;

   
    public void SetTool(string toolId)
    {
        AllDeActiveTool();
      GameObject tool=  _R_Tool.Find(toolId).gameObject;
        if (tool!=null)
        {
            tool.SetActive(true);
        }
    }
    public void AllDeActiveTool()
    {
        for (int i = 0; i < _R_Tool.childCount; i++)
        {
            _R_Tool.GetChild(i).gameObject.SetActive(false);
        }
    }
}
