using Cinemachine;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    public float TurnSpeed;
    Camera MainCamera;
    public GameObject Cam;
    public CinemachineFreeLook FreeLookCam;
    private void Start()
    {  
        MainCamera = Camera.main;
    }
    public void LookAt()
    {
        if (Input.GetKey(KeyCode.W))
        {
            float yCamera = MainCamera.transform.eulerAngles.y;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yCamera, 0), Time.deltaTime * TurnSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            float yCamera = MainCamera.transform.eulerAngles.y;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yCamera+180, 0), Time.deltaTime * TurnSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            float yCamera = MainCamera.transform.eulerAngles.y;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yCamera-90, 0), Time.deltaTime * TurnSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            float yCamera = MainCamera.transform.eulerAngles.y;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yCamera+90, 0), Time.deltaTime * TurnSpeed);
        }
    }

    public void LookAtStrafe()
    {
         float yCamera = MainCamera.transform.eulerAngles.y;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yCamera, 0), Time.deltaTime * TurnSpeed);
             
    }
}
