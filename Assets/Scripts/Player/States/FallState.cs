public class FallState : IPlayerState
{
    public void EnterState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.CrossFade("Falling", 0.02f);
    }

    public void ExitState(StateMachineController player)
    {
        
    }

    public void UpdateState(StateMachineController player)
    {
        if (player.PlayerController.isGrounded)
        {
            player.SwitchState(new MoveState());
        }
    }       
}
