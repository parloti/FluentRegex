﻿namespace FluentRegex
{
    /// <summary>
    /// Represents a set of characters from which another set can be subtracted.
    /// </summary>
    internal interface ISubtractable
    {
        /// <summary>
        /// Set of characters to be used in subtraction.
        /// </summary>
        string Set { get; }
    }
}
