using UnityEngine;

public class AttackState : IPlayerState
{
    public void EnterState(StateMachineController player)
    {
       //player.PlayerAnimatorController.Animator.CrossFade("Item-Attack-R2", 0.02f);
       player.PlayerAnimatorController.Animator.SetBool("IsAttack", true);
       player.PlayerAnimatorController.Animator.SetBool("IsStrafe", true);
     //  player.PlayerAnimatorController.Animator.SetFloat("Speed", 0);
       
    }

    public void ExitState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.SetBool("IsAttack", false);
        player.PlayerAnimatorController.Animator.SetBool("IsStrafe", false);
    }

    public void UpdateState(StateMachineController player)
    {
        player.PlayerController.Move();
        player.PlayerCameraController.LookAtStrafe();
        player.PlayerAnimatorController.UpdateVelocty();
        if (!Input.GetMouseButton(0))
        {
            player.SwitchState(new MoveState());
        }
    }
}
