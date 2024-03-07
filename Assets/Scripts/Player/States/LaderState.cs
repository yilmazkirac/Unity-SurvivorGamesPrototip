using UnityEngine;

public class LaderState : IPlayerState
{
    public void EnterState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.CrossFade("Climbing Ladder", 0.02f);
        player.PlayerAnimatorController.Animator.SetBool("IsLader",true);
    }

    public void ExitState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.SetBool("IsLader", false);
        player.PlayerAnimatorController.Animator.StopPlayback();
    }

    public void UpdateState(StateMachineController player)
    {
        player.PlayerRaycastController.StartRay();
        if (player.PlayerRaycastController.IsWallHead || player.PlayerRaycastController.IsWallBody)
        {
            if (Input.GetKey(KeyCode.W))
            {              
                player.PlayerAnimatorController.Animator.StopPlayback();
            }
            if (!Input.GetKey(KeyCode.W))
            {
                player.PlayerAnimatorController.Animator.StartPlayback();
            }
        }
        else if (!player.PlayerRaycastController.IsWallHead && !player.PlayerRaycastController.IsWallBody)
        {                        
          player.SwitchState(new UpState());
        }
        
        if (Input.GetKey(KeyCode.X))
        {
            player.PlayerRaycastController.IsWallHead = false;
            player.PlayerRaycastController.IsWallBody = false;
            player.SwitchState(new MoveState());
        }
    }
}
