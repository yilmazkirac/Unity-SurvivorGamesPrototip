using UnityEngine;

public class Tree : MonoBehaviour
{
    int health = 20;
    [SerializeField] Transform _spawnPoint;
    [SerializeField] GameObject _preObject;
    [SerializeField] Enviormentype _enviormentype;
    
    private void OnTriggerEnter(Collider other)
    {
        switch (_enviormentype)
        {            
            case Enviormentype.Rock:
                if (other.gameObject.CompareTag("PickAxe"))
                {
                    if (health > 0)
                    {
                        health -= 2;
                        if (health % 5 == 0)
                        {
                            Instantiate(_preObject, _spawnPoint.position, Quaternion.identity);
                        }
                        if (health <= 0)
                        {
                            Destroy(gameObject);
                        }
                    }
                }
                break;
            case Enviormentype.Tree:
                if (other.gameObject.CompareTag("Axe"))
                {
                    if (health > 0)
                    {
                        health -= 2;
                        if (health % 5 == 0)
                        {
                            Instantiate(_preObject, _spawnPoint.position, Quaternion.identity);
                        }
                        if (health <= 0)
                        {
                            Destroy(gameObject);
                        }
                    }
                }
                break;
           
        }
        
    }
}
