public interface IPlayerState
{
  void EnterState(StateMachineController player);
  void UpdateState(StateMachineController player);
  void ExitState(StateMachineController player);
}
