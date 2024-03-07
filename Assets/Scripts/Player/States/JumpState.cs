using UnityEngine;

public class JumpState : IPlayerState
{
    public void EnterState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.CrossFade("Jump", 0.02f);
        player.PlayerAnimatorController.Animator.SetBool("IsGrounded",false);
    }

    public void ExitState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.SetBool("IsGrounded", true);
    }

    public void UpdateState(StateMachineController player)
    {
        player.PlayerController.Move();
        player.PlayerCameraController.LookAt();
        if (player.PlayerController.isGrounded)
        {
            player.SwitchState(new MoveState());
        }
    }
}
