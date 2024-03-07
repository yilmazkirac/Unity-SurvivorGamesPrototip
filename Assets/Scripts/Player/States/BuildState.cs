using UnityEngine;

public class BuildState : IPlayerState
{
    public void EnterState(StateMachineController player)
    {
      //  player.PlayerCameraController.FreeLookCam.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        UIManager.Instance.OpenBuild(true);
    }

    public void ExitState(StateMachineController player)
    {
      //  player.PlayerCameraController.FreeLookCam.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        player.PlayerRaycastController.BuildObjcejt.Destroy();
    }

    public void UpdateState(StateMachineController player)
    {
        player.PlayerController.Move();
        player.PlayerCameraController.LookAt();
        player.PlayerAnimatorController.UpdateAnim();
        player.PlayerRaycastController.BuildRay();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            player.SwitchState(new MoveState());
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            player.SwitchState(new BuildState());
        }
    }
}