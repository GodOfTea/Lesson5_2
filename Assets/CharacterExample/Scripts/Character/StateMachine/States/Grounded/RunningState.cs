using CharacterExample.Scripts.Character.StateMachine.States.Grounded;
using UnityEngine.InputSystem;

public class RunningState : GroundedState
{
    protected readonly RunningStateConfig Config;

    protected RunningType RunningType;

    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => Config = character.Config.RunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    protected override void AddInputActionsCallbacks()
    {
        base.AddInputActionsCallbacks();
        
        Input.Movement.Acceleration.performed += AccelerationPerformed;
        Input.Movement.Walk.performed += WalkPerformed;
    }

    protected override void RemoveInputActionsCallback()
    {
        base.RemoveInputActionsCallback();
        
        Input.Movement.Acceleration.performed -= AccelerationPerformed;
        Input.Movement.Walk.performed -= WalkPerformed;
    }

    private void AccelerationPerformed(InputAction.CallbackContext obj)
    {
        if (RunningType == RunningType.Fast)
            StateSwitcher.SwitchState<DefaultMovingState>();
        else
            StateSwitcher.SwitchState<SprintingState>();        
    }

    private void WalkPerformed(InputAction.CallbackContext obj)
    {
        if (RunningType == RunningType.Walking)
            StateSwitcher.SwitchState<DefaultMovingState>();
        else
            StateSwitcher.SwitchState<WalkingState>();    
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }
}
