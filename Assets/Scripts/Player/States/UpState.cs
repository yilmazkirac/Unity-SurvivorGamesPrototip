public class UpState : IPlayerState
{
    public void EnterState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.CrossFade("Braced Hang To Crouch", 0.02f);
    }

    public void ExitState(StateMachineController player)
    {
        
    }

    public void UpdateState(StateMachineController player)
    {
        if (player.PlayerAnimatorController.IsPlayAnim)
        {
            player.SwitchState(new MoveState());
        }
    }
}
