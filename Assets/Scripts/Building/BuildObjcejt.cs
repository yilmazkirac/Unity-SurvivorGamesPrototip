using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildObjcejt : MonoBehaviour
{
    public GameObject[] PreviewObject;
    public GameObject[] BuildObject;
    public GameObject CurrentObje;
    public int CurrentId=-1;

    public void CurrentObject(int value)
    {
        CurrentId = value;
        CurrentObje = Instantiate(PreviewObject[CurrentId]);
        GameManager.Instance.Player.GetComponent<PlayerCameraController>().FreeLookCam.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    } 
    public void Destroy()
    {
        Destroy(CurrentObje);
        CurrentId = -1;
    }
}
