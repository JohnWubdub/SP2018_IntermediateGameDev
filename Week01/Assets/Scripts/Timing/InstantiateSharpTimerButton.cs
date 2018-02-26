﻿using JetBrains.Annotations;
using UnityEngine;

namespace Timing
{
    public class InstantiateSharpTimerButton : MonoBehaviour
    {
        [UsedImplicitly]
        public void InstantiateSharpTimer(float time)
        {
            DebugHelper.DebugMessage("Timer start!", "green")(); // You need the extra () because DebugMessage returns a delegate (a function)
            var newTimer = new SharpTimer();
            newTimer.StartTimer(time, DebugHelper.DebugMessage("Timer" + Time.frameCount.ToString("D") + " end!", "red"));
            TimeLord.Instance.AddTimer(newTimer);
        }
    }
}