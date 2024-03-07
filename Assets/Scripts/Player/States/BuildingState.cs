using UnityEngine;

public class BuildingState : IPlayerState
{ 
    public void EnterState(StateMachineController player)
    {
       
    }


    public void ExitState(StateMachineController player)
    {
      
    }

    public void UpdateState(StateMachineController player)
    {
        player.PlayerController.Move();
        player.PlayerCameraController.LookAt();
        player.PlayerAnimatorController.UpdateAnim();
        player.PlayerRaycastController.BuildRay();


       
    }
}
