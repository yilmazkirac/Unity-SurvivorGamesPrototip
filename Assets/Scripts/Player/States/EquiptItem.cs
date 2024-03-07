using UnityEngine;

public class EquiptItem : IPlayerState
{
    public void EnterState(StateMachineController player)
    {
        player.PlayerAnimatorController.Animator.SetBool("IsSword", false);
        player.PlayerAnimatorController.Animator.SetBool("IsAxe", false);
        player.PlayerAnimatorController.Animator.SetBool("IsPickAxe", false);
        player.PlayerAnimatorController.Animator.SetBool("IsBow", false);
        player.PlayerAnimatorController.Animator.SetBool("IsEquip", false);

        switch (player.PlayerStats.CurrentItem.ItemType)
        {
            case ItemType.None:
                player.PlayerAnimatorController.Animator.SetBool("IsSword", false);
                player.PlayerAnimatorController.Animator.SetBool("IsAxe", false);
                player.PlayerAnimatorController.Animator.SetBool("IsPickAxe", false);
                player.PlayerAnimatorController.Animator.SetBool("IsBow", false);
                player.PlayerAnimatorController.Animator.SetBool("IsEquip", false);
                break;
            case ItemType.Tool:
                player.PlayerAnimatorController.Animator.SetBool("IsSword", true);
                player.PlayerAnimatorController.Animator.SetBool("IsEquip", true);
                player.PlayerAnimatorController.Animator.CrossFade("Equip", 0.02f);
                break;
            case ItemType.Axe:
                player.PlayerAnimatorController.Animator.SetBool("IsAxe", true);
                player.PlayerAnimatorController.Animator.SetBool("IsEquip", true);
                player.PlayerAnimatorController.Animator.CrossFade("Equip", 0.02f);
                break;
            case ItemType.Pickaxe:
                player.PlayerAnimatorController.Animator.SetBool("IsPickAxe", true);
                player.PlayerAnimatorController.Animator.SetBool("IsEquip", true);
                player.PlayerAnimatorController.Animator.CrossFade("Equip", 0.02f);
                break;
            case ItemType.Bow:
                player.PlayerAnimatorController.Animator.SetBool("IsBow", true);
                player.PlayerAnimatorController.Animator.SetBool("IsEquip", true);
                player.PlayerAnimatorController.Animator.CrossFade("Equip", 0.02f);
                break;
        }
       
    }

    public void ExitState(StateMachineController player)
    {
       
    }

    public void UpdateState(StateMachineController player)
    {
        player.SwitchState(new MoveState());
    }
}
