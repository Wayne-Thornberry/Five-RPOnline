﻿using System;

namespace Proline.ClassicOnline.Engine.Component
{
    [Serializable]
    internal class ComponentScriptDoesNotExistException : Exception
    {
        public ComponentScriptDoesNotExistException()
        {
        }

        public ComponentScriptDoesNotExistException(string message) : base(message)
        {
        }

        public ComponentScriptDoesNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}