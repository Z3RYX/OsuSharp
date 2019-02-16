﻿using System;

namespace OsuSharp
{
    public sealed class OsuSharpLogger
    {
        /// <summary>
        ///     Events that will fire each time <see cref="OsuSharpLogger.LogMessage(string)"/> has been called.
        /// </summary>
        public event Action<string> LogMessageReceived;

        internal void LogMessage(string message)
        {
            LogMessageReceived?.Invoke(message);
        }
    }
}
