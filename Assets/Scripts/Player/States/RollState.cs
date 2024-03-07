using UnityEngine;

public class RollState : IPlayerState
{
    public void EnterState(StateMachineController player)
    {
        player.PlayerController.CharCont.height = 1;
        player.PlayerController.CharCont.center= new Vector3(0, 0.5f, 0);        
        player.PlayerAnimatorController.Animator.CrossFade("Roll", 0.02f);        
        player.PlayerAnimatorController.IsPlayAnim = false;        
    }

    public void ExitState(StateMachineController player)
    {
        player.PlayerController.CharCont.height= 2;
        player.PlayerController.CharCont.center = new Vector3(0, 1, 0);
    }

    public void UpdateState(StateMachineController player)
    {
        if (player.PlayerAnimatorController.IsPlayAnim)
        {
            player.SwitchState(new MoveState());
        }
    }    
}
