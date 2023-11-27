namespace CharacterExample.Scripts.Character.StateMachine.States.Grounded
{
    public class DefaultMovingState : RunningState
    {
        public DefaultMovingState(IStateSwitcher stateSwitcher, StateMachineData data, global::Character character) : 
            base(stateSwitcher, data, character) { }

        public override void Enter()
        {
            base.Enter();
            Data.Speed = Config.Speed;
            RunningType = RunningType.Normal;
        }
    }
}