namespace CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class WalkingState : RunningState
    {
        public WalkingState(IStateSwitcher stateSwitcher, StateMachineData data, global::Character character) : 
            base(stateSwitcher, data, character) { }

        public override void Enter()
        {
            base.Enter();
            Data.Speed = Config.WalkingSpeed;
            RunningType = RunningType.Walking;
        }
    }
}