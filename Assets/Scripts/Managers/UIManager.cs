using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public Slider Slider;
    public Canvas Canvas;
    public GameObject EatPanel;

    public GameObject InventoryPanel;
    public bool IsInventory;

    public GameObject BuildPanel;
    public bool IsBuild;


    public TextMeshProUGUI DamageText;
    public TextMeshProUGUI ArmorText;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI LvlText;
    public Slider ExpBar;


    [Header("PANELS-------------------------------")]
    [SerializeField] private GameObject _buildPanel;
    [SerializeField] private GameObject _craftPanel;
    [SerializeField] private GameObject _creatPanel;

    public void DeActivePanel()
    {
        EatPanel.SetActive(false);
    }

    public void OpenInventory()
    {
        IsInventory = !IsInventory;
        InventoryPanel.SetActive(IsInventory);
    }
    public void OpenBuild(bool value)
    {
        _buildPanel.SetActive(value);
    }
}

