using UnityEngine;

public class StateMachineController : MonoBehaviour
{
    private IPlayerState currentState;
    public PlayerController PlayerController;
    public PlayerCameraController PlayerCameraController;
    public PlayerAnimatorController PlayerAnimatorController;
    public PlayerRaycastController PlayerRaycastController;
    public PlayerStats PlayerStats;
    public PlayerItemController PlayerItemController;

    private void Start()
    {
        currentState = new MoveState();
    }
    private void Update()
    {
        currentState.UpdateState(this);
    }
    public void SwitchState(IPlayerState state)
    {
        currentState.ExitState(this);
        currentState = state;
        currentState.EnterState(this);
    }
}
