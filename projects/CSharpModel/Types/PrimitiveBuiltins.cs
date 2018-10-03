// -*- mode: csharp; tab-width: 4; indent-tabs-mode: nil; c-basic-offset: 4 -*-
//
// Copyright (C) 2012-2015 Marco Craveiro <marco.craveiro@gmail.com>
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
// MA 02110-1301, USA.
//
using System;

namespace Dogen.TestModels.CSharpModel
{
    /// <summary>
    /// This is a class made up of just built-in types.
    /// </summary>
    /// <remarks>
    /// This is a remark.
    /// </remarks>
    public sealed class PrimitiveBuiltins
    {
        #region Helpers
        /// <summary>
        /// Compare floating point numbers, taking precision into account (float version).
        /// </summary>
        static private bool NearlyEqual(float lhs, float rhs)
        {
            float epsilon = Math.Max(Math.Abs(lhs), Math.Abs(rhs)) * float.Epsilon;
            return Math.Abs(lhs - rhs) <= epsilon;
        }
        /// <summary>
        /// Compare floating point numbers, taking precision into account (double version).
        /// </summary>
        static private bool NearlyEqual(double lhs, double rhs)
        {
            double epsilon = Math.Max(Math.Abs(lhs), Math.Abs(rhs)) * double.Epsilon;
            return Math.Abs(lhs - rhs) <= epsilon;
        }
        #endregion

        #region Properties
        /// <summary>
        /// A comment at property level.
        /// </summary>
        public byte ByteProperty { get; set; }
        /// <summary>
        /// A comment at property level.
        /// </summary>
        /// <remarks>
        /// This is a remark.
        /// </remarks>
        public sbyte ShortByteProperty { get; set; }
        public int IntProperty { get; set; }
        public uint UIntProperty { get; set; }
        public short ShortProperty { get; set; }
        public ushort UShortProperty { get; set; }
        public long LongProperty { get; set; }
        public ulong ULongProperty { get; set; }
        public float FloatPropertyOne { get; set; }
        /// <summary>
        /// Second float to ensure helpers are generated correctly.
        /// </summary>
        public float FloatPropertyTwo { get; set; }
        public double DoublePropertyOne { get; set; }
        /// <summary>
        /// Second double to ensure helpers are generated correctly.
        /// </summary>
        public double DoublePropertyTwo { get; set; }
        public char CharProperty { get; set; }
        public bool BoolProperty { get; set; }
        public decimal DecimalProperty { get; set; }
        #endregion

        #region Constructors
        public PrimitiveBuiltins() { }

        public PrimitiveBuiltins(
            byte byteProperty,
            sbyte shortByteProperty,
            int intProperty,
            uint uIntProperty,
            short shortProperty,
            ushort uShortProperty,
            long longProperty,
            ulong uLongProperty,
            float floatPropertyOne,
            float floatPropertyTwo,
            double doublePropertyOne,
            double doublePropertyTwo,
            char charProperty,
            bool boolProperty,
            decimal decimalProperty)
        {
            ByteProperty = byteProperty;
            ShortByteProperty = shortByteProperty;
            IntProperty = intProperty;
            UIntProperty = uIntProperty;
            ShortProperty = shortProperty;
            UShortProperty = uShortProperty;
            LongProperty = longProperty;
            ULongProperty = uLongProperty;
            FloatPropertyOne = floatPropertyOne;
            FloatPropertyTwo = floatPropertyTwo;
            DoublePropertyOne = doublePropertyOne;
            DoublePropertyTwo = doublePropertyTwo;
            CharProperty = charProperty;
            BoolProperty = boolProperty;
            DecimalProperty = decimalProperty;
        }
        #endregion

        #region Equality
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            var value = obj as PrimitiveBuiltins;
            if (value == null) return false;

            return
                ByteProperty == value.ByteProperty &&
                ShortByteProperty == value.ShortByteProperty &&
                IntProperty == value.IntProperty &&
                UIntProperty == value.UIntProperty &&
                ShortProperty == value.ShortProperty &&
                UShortProperty == value.UShortProperty &&
                LongProperty == value.LongProperty &&
                ULongProperty == value.ULongProperty &&
                NearlyEqual(FloatPropertyOne, value.FloatPropertyOne) &&
                NearlyEqual(FloatPropertyTwo, value.FloatPropertyTwo) &&
                NearlyEqual(DoublePropertyOne, value.DoublePropertyOne) &&
                NearlyEqual(DoublePropertyTwo, value.DoublePropertyTwo) &&
                CharProperty == value.CharProperty &&
                BoolProperty == value.BoolProperty &&
                DecimalProperty == value.DecimalProperty;
        }

        public static bool operator ==(PrimitiveBuiltins lhs, PrimitiveBuiltins rhs)
        {
            if (Object.ReferenceEquals(lhs, rhs))
                return true;

            return !Object.ReferenceEquals(null, lhs) && lhs.Equals(rhs);
        }

        public static bool operator !=(PrimitiveBuiltins lhs, PrimitiveBuiltins rhs)
        {
            return !(lhs == rhs);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                // Choose large primes to avoid hashing collisions
                const int HashingBase = (int) 2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ ByteProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ ShortByteProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ IntProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ UIntProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ ShortProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ UShortProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ LongProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ ULongProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ FloatPropertyOne.GetHashCode();
                hash = (hash * HashingMultiplier) ^ FloatPropertyTwo.GetHashCode();
                hash = (hash * HashingMultiplier) ^ DoublePropertyOne.GetHashCode();
                hash = (hash * HashingMultiplier) ^ DoublePropertyTwo.GetHashCode();
                hash = (hash * HashingMultiplier) ^ CharProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ BoolProperty.GetHashCode();
                hash = (hash * HashingMultiplier) ^ DecimalProperty.GetHashCode();
                return hash;
            }
        }
        #endregion
    }
}
