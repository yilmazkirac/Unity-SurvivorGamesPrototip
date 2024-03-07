using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public GameObject Player;
    public GraphicRaycaster GraphicRaycaster;
    public Transform Croos;

    public BuildObjcejt BuildObjcejt;

    private void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }    
}
