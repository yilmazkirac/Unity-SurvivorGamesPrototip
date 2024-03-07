using JetBrains.Annotations;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    public Animator Animator;
    public bool IsPlayAnim;
    public bool IsLader;
    public bool IsAxe,IsPickAxe,IsSword;
    float speed;
    public float Value;

  
    public void UpdateAnim()
    {
        Vector2 newInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (newInput!=Vector2.zero)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (speed<5)
                {
                    speed += Time.deltaTime * Value;
                }
            }
            else if (!Input.GetKey(KeyCode.LeftShift))
            {
                if (speed < 2.4)
                {
                    speed += Time.deltaTime * Value;
                }
                else if (speed == 2.5)
                {
                    speed = 2.5f;
                }
                else if (speed > 2.6)
                {
                    speed -= Time.deltaTime * Value;                    
                }
            }     
        }
        if (newInput == Vector2.zero)
        {
            if (speed > 0)
            {
                speed -= Time.deltaTime * Value;
            }           
        }
        Animator.SetFloat("Speed", speed);
    }
    public void UpdateVelocty()
    {
        //Vector2 newInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
       Animator.SetFloat("Velocity X", Input.GetAxisRaw("Horizontal"));
       Animator.SetFloat("Velocity Y", Input.GetAxisRaw("Vertical"));

    }
    public void IsPlayAnimTrue()
    {
        IsPlayAnim = true;
    }
    public void IsPlayAnimFalse()
    {
        IsPlayAnim = false;
    }
}
