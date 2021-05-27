using System;
using BlazorExamples.Domain.TrafficLight;
using Microsoft.AspNetCore.Components;

namespace BlazorExamples.Pages.TrafficLight
{
    public class TrafficLightBasePM : ComponentBase
    {
        protected ITrafficLightState Lights { get; set; } = new StopState();

        protected void Toggle()
        {
            Lights = Lights switch
            {
                StopState _ =>  new GetReadyToGoState(),
                GetReadyToGoState _ => new GoState(),
                GoState _ => new GetReadyToStopState(),
                GetReadyToStopState _ => new StopState(),
                _ => throw new ArgumentOutOfRangeException(nameof(Lights))
            };
        }
    }
}