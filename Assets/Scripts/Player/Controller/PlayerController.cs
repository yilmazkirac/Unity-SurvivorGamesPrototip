using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 3f, RunSpeed = 5f;
    private float activeMooveSpeed;
    private Vector3 moveDir;
    private Vector3 movement;

    public CharacterController CharCont;


    public float JumpForce = 12f, GravityMod = 2.5f;
    public Transform GroundChechPoint;
    public bool isGrounded;
    public LayerMask GroundLayer;

    Camera cam;

    private void Start()
    {
        cam = Camera.main;
       
        activeMooveSpeed = MoveSpeed;
    }

    public void Move()
    {        
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            activeMooveSpeed = RunSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            activeMooveSpeed = MoveSpeed;
        }
        float yVel = movement.y;
        movement = ((cam.transform.forward * moveDir.z) + (cam.transform.right * moveDir.x)).normalized * activeMooveSpeed;

        movement.y = yVel;

        if (CharCont.isGrounded)
        {
            movement.y = 0;
        }
        isGrounded = Physics.Raycast(GroundChechPoint.position, Vector3.down, .3f, GroundLayer);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            movement.y = JumpForce;
        }
        movement.y += Physics.gravity.y * Time.deltaTime * GravityMod;
        CharCont.Move(movement * Time.deltaTime);
    }
 
}
