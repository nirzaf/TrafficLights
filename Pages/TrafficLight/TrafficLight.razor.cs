using Microsoft.AspNetCore.Components;

namespace BlazorExamples.Pages.TrafficLight
{
    public enum State
    {
        Stop,
        GetReadyToGo,
        Go,
        GetReadyToStop
    }

    public class TrafficLightState
    {
        public bool RedOn { get; }
        public bool AmberOn { get; }
        public bool GreenOn { get; }
    
        public TrafficLightState(bool redOn, bool amberOn, bool greenOn)
        {
            RedOn = redOn;
            AmberOn = amberOn;
            GreenOn = greenOn;
        }
        
        public static TrafficLightState Resolve(State state)
        {
            return state switch
            {
                State.Stop => new TrafficLightState(true, false, false),
                State.GetReadyToGo => new TrafficLightState(true, true, false),
                State.Go => new TrafficLightState(false, false, true),
                State.GetReadyToStop => new TrafficLightState(false, true, false),
                _ => new TrafficLightState(true, false, false)
            };
        }
    }
    
    public class TrafficLightBase : ComponentBase
    {
        private State _currentState = State.Stop;
        protected TrafficLightState Lights => 
            TrafficLightState.Resolve(_currentState);

        public void Toggle()
        {
            _currentState = _currentState switch
            {
                State.Stop => State.GetReadyToGo,
                State.GetReadyToGo => State.Go,
                State.Go => State.GetReadyToStop,
                State.GetReadyToStop => State.Stop,
                _ => _currentState
            };
        }
    }
}