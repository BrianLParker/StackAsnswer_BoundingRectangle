// ------------------------------------------------------------
// Copyright (c) Brian Parker All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ------------------------------------------------------------

namespace BoundingRectangle.Extensions;

public static class TimerExtensions
{
    public static void Restart(this System.Timers.Timer timer)
    {
        timer.Stop();
        timer.Start();
    }
}
