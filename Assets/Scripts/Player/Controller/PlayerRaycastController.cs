using UnityEngine;

public class PlayerRaycastController : MonoBehaviour
{
    [SerializeField] private Transform _playerHead;
    [SerializeField] private Transform _playerBody;
    private Transform croos;
   private Vector3 _CroosPos;
    RaycastHit hit;
    public bool IsWallHead;
    public bool IsWallBody;

   public BuildObjcejt BuildObjcejt;

    private void Start()
    {

         BuildObjcejt=  GameManager.Instance.BuildObjcejt;
         croos=  GameManager.Instance.Croos;
        _CroosPos = croos.transform.position;
    }
    public void StartRay()
    {
        if (Physics.Raycast(_playerHead.position, _playerHead.forward, out hit, 0.5f))
        {

            GameObject newObject = hit.collider.gameObject;

            if (newObject.tag == "Wall")
            {
                IsWallHead = true;
            }
            else if ((newObject.tag != "Wall"))
            {
                IsWallHead = false;
            }

        }
        if (Physics.Raycast(_playerBody.position, _playerBody.forward, out hit, 0.5f))
        {

            GameObject newObject = hit.collider.gameObject;
            if (newObject.tag == "Wall")
            {
                IsWallBody = true;
            }
            else if ((newObject.tag != "Wall"))
            {
                IsWallBody = false;
            }
        }


        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 10f))
        {
            ICommand command = hit.collider.GetComponent<ICommand>();
            if (command != null)
            {
                command.Execute();
            }
        }
    }
    public void BuildRay()
    {

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 20f))
        {
         
            if (BuildObjcejt.CurrentObje != null)
            {  
                switch (BuildObjcejt.CurrentId)
                {
                    case 0:
                        if (hit.collider.CompareTag("Slot"))
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.collider.gameObject.transform.position;
                            BuildObjcejt.CurrentObje.transform.rotation = hit.collider.gameObject.transform.rotation;
                        }
                        else
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.point;
                        }
                        break;

                    case 1:
                        if (hit.collider.CompareTag("WallSlot"))
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.collider.gameObject.transform.position;
                            BuildObjcejt.CurrentObje.transform.rotation = hit.collider.gameObject.transform.rotation;                           
                        }
                        else
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.point;
                        }
                        break;
                    case 2:
                        if (hit.collider.CompareTag("WallSlot"))
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.collider.gameObject.transform.position;
                            BuildObjcejt.CurrentObje.transform.rotation = hit.collider.gameObject.transform.rotation;                           
                        }
                        else
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.point;
                        }
                        break;
                    case 3:
                        if (hit.collider.CompareTag("WallSlot"))
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.collider.gameObject.transform.position;
                            BuildObjcejt.CurrentObje.transform.rotation = hit.collider.gameObject.transform.rotation;                           
                        }
                        else
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.point;
                        }
                        break;
                    case 4:
                        if (hit.collider.CompareTag("FloorSoket"))
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.collider.gameObject.transform.position;
                            BuildObjcejt.CurrentObje.transform.rotation = hit.collider.gameObject.transform.rotation;                        
                        }
                        else
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.point;
                        }
                        break;
                    case 5:
                        if (hit.collider.CompareTag("LaderSoket"))
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.collider.gameObject.transform.position;
                            BuildObjcejt.CurrentObje.transform.rotation = hit.collider.gameObject.transform.rotation;                       
                        }
                        else
                        {
                            BuildObjcejt.CurrentObje.transform.position = hit.point;
                        }
                        break;                         
                }
               
            }

            if (Input.GetKey(KeyCode.Q))
            {
                BuildObjcejt.CurrentObje.transform.Rotate(0, 1, 0);
            }
            if (Input.GetKey(KeyCode.E))
            {
                BuildObjcejt.CurrentObje.transform.Rotate(0, -1, 0);
            }
            if (Input.GetMouseButtonDown(0))
            {
                switch (BuildObjcejt.CurrentId)
                {
                    case 0:
                        if (hit.collider.CompareTag("Ground") || hit.collider.CompareTag("Slot"))
                        {
                            Instantiate(BuildObjcejt.BuildObject[BuildObjcejt.CurrentId], BuildObjcejt.CurrentObje.transform.position, BuildObjcejt.CurrentObje.transform.rotation);
                        }
                        break;

                    case 1:
                        if (hit.collider.CompareTag("WallSlot"))
                        {
                            Instantiate(BuildObjcejt.BuildObject[BuildObjcejt.CurrentId], BuildObjcejt.CurrentObje.transform.position, BuildObjcejt.CurrentObje.transform.rotation);
                        }
                        break;
                    case 2:
                        if (hit.collider.CompareTag("WallSlot"))
                        {
                            Instantiate(BuildObjcejt.BuildObject[BuildObjcejt.CurrentId], BuildObjcejt.CurrentObje.transform.position, BuildObjcejt.CurrentObje.transform.rotation);
                        }
                        break;
                    case 3:
                        if (hit.collider.CompareTag("WallSlot"))
                        {
                            Instantiate(BuildObjcejt.BuildObject[BuildObjcejt.CurrentId], BuildObjcejt.CurrentObje.transform.position, BuildObjcejt.CurrentObje.transform.rotation);
                        }
                        break;
                    case 4:
                        if (hit.collider.CompareTag("FloorSoket"))
                        {
                            Instantiate(BuildObjcejt.BuildObject[BuildObjcejt.CurrentId], BuildObjcejt.CurrentObje.transform.position, BuildObjcejt.CurrentObje.transform.rotation);
                        }
                        break;
                    case 5:
                        if (hit.collider.CompareTag("LaderSoket"))
                        {
                            Instantiate(BuildObjcejt.BuildObject[BuildObjcejt.CurrentId], BuildObjcejt.CurrentObje.transform.position, BuildObjcejt.CurrentObje.transform.rotation);
                        }
                        break;

                }
            }

        }
    }
}

