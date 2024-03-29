﻿namespace Veldrid.OpenXR.Native
{
    /// <summary>
    /// A boolean value stored in a 4-byte unsigned integer.
    /// </summary>
    /// <remarks>
    /// Constructs a new <see cref="XrBool32"/> with the given raw value. 
    /// </remarks>
    /// <param name="value"></param>
    public struct XrBool32(uint value) : IEquatable<XrBool32>
    {
        /// <summary>
        /// Represents the boolean "true" value. Has a raw value of 1.
        /// </summary>
        public static readonly XrBool32 True = new(1);

        /// <summary>
        /// Represents the boolean "true" value. Has a raw value of 0.
        /// </summary>
        public static readonly XrBool32 False = new(0);

        /// <summary>
        /// The raw value of the <see cref="XrBool32"/>. A value of 0 represents "false", all other values represent "true".
        /// </summary>
        public uint Value = value;

        /// <summary>
        /// Returns whether another <see cref="XrBool32"/> value is considered equal to this one.
        /// Two <see cref="XrBool32"/>s are considered equal when their raw values are equal.
        /// </summary>
        /// <param name="other">The value to compare to.</param>
        /// <returns>True if the other value's underlying raw value is equal to this instance's. False otherwise.</returns>
        public readonly bool Equals(XrBool32 other)
        {
            return Value.Equals(other.Value);
        }

        public override readonly bool Equals(object obj)
        {
            return obj is XrBool32 b && Equals(b);
        }

        public override readonly int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override readonly string ToString()
        {
            return $"{(this ? "True" : "False")} ({Value})";
        }

        public static implicit operator bool(XrBool32 b) => b.Value != 0;
        public static implicit operator uint(XrBool32 b) => b.Value;
        public static implicit operator XrBool32(bool b) => b ? True : False;
        public static implicit operator XrBool32(uint value) => new(value);

        public static bool operator ==(XrBool32 left, XrBool32 right) => left.Value == right.Value;
        public static bool operator !=(XrBool32 left, XrBool32 right) => left.Value != right.Value;
        public static bool operator true(XrBool32 value) => value;
        public static bool operator false(XrBool32 value) => !value;
    }
}
