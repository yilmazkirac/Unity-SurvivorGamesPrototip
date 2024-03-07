using UnityEngine;

public class GameScenePlayerSettings : MonoBehaviour
{
    void Start()
    {
       GameObject newPlayer = Instantiate(GameManager.Instance.Player);
        newPlayer.transform.position = Vector3.zero;
        newPlayer.transform.rotation = Quaternion.identity;
    }    
}
