﻿using System;
using NextLevelSeven.Diagnostics;

namespace NextLevelSeven.Core
{
    /// <summary>
    ///     Represents an exception that would be raised for HL7 element specific errors.
    /// </summary>
    public class ElementException : Exception
    {
        /// <summary>
        ///     Create an element exception.
        /// </summary>
        public ElementException(ErrorCode code) : base(ErrorMessages.Get(code))
        {
        }
    }
}