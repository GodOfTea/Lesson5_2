namespace CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class SprintingState : RunningState
    {
        public SprintingState(IStateSwitcher stateSwitcher, StateMachineData data, global::Character character) : 
            base(stateSwitcher, data, character) { }

        public override void Enter()
        {
            base.Enter();
            Data.Speed = Config.FastRunSpeed;
            RunningType = RunningType.Fast;
        }

    }
}