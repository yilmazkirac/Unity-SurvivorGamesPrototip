using UnityEngine;

public class MoveState : IPlayerState
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

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
           player.PlayerStats.SellectItem(0);
            player.SwitchState(new EquiptItem());
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.PlayerStats.SellectItem(1);
            player.SwitchState(new EquiptItem());
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.PlayerStats.SellectItem(2);
            player.SwitchState(new EquiptItem());
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            player.PlayerStats.SellectItem(3);
            player.SwitchState(new EquiptItem());
        }




        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.SwitchState(new RollState());
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.SwitchState(new JumpState());
        }

        if (!player.PlayerController.isGrounded)
        {
            player.SwitchState(new JumpState());
        }
      
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.PlayerRaycastController.StartRay();
            if (player.PlayerRaycastController.IsWallHead&& player.PlayerRaycastController.IsWallBody)
            {
                player.SwitchState(new LaderState());
            }  
        }

        if (Input.GetMouseButton(0))
        {
            player.SwitchState(new AttackState());
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            player.SwitchState(new UIState());            
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            player.SwitchState(new BuildState());
        }

    }
}
