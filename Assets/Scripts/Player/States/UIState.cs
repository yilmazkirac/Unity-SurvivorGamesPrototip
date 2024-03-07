using UnityEngine;
public class UIState :  IPlayerState
{
    public void EnterState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.SetFloat("Speed", 0);
        player.PlayerCameraController.FreeLookCam.gameObject.SetActive(false);
        Cursor.lockState=CursorLockMode.None;
        UIManager.Instance.OpenInventory();
     
    }

    public void ExitState(StateMachineController player)
    {
        player.PlayerCameraController.FreeLookCam.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        UIManager.Instance.OpenInventory();
    }

    public void UpdateState(StateMachineController player)
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            player.SwitchState(new MoveState());
        }
    }   
}
