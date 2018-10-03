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

namespace dogen.test_models.LAMModel
{
    public sealed class Builtins
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
        public char Prop0 { get; set; }
        public byte Prop1 { get; set; }
        public sbyte Prop2 { get; set; }
        public System.Int16 Prop3 { get; set; }
        public System.Int32 Prop4 { get; set; }
        public System.Int64 Prop5 { get; set; }
        public int Prop6 { get; set; }
        public float Prop7 { get; set; }
        public double Prop8 { get; set; }
        public bool Prop9 { get; set; }
        #endregion

        #region Constructors
        public Builtins() { }

        public Builtins(
            char prop0,
            byte prop1,
            sbyte prop2,
            System.Int16 prop3,
            System.Int32 prop4,
            System.Int64 prop5,
            int prop6,
            float prop7,
            double prop8,
            bool prop9)
        {
            Prop0 = prop0;
            Prop1 = prop1;
            Prop2 = prop2;
            Prop3 = prop3;
            Prop4 = prop4;
            Prop5 = prop5;
            Prop6 = prop6;
            Prop7 = prop7;
            Prop8 = prop8;
            Prop9 = prop9;
        }
        #endregion

        #region Equality
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            var value = obj as Builtins;
            if (value == null) return false;

            return
                Prop0 == value.Prop0 &&
                Prop1 == value.Prop1 &&
                Prop2 == value.Prop2 &&
                Prop3 == value.Prop3 &&
                Prop4 == value.Prop4 &&
                Prop5 == value.Prop5 &&
                Prop6 == value.Prop6 &&
                NearlyEqual(Prop7, value.Prop7) &&
                NearlyEqual(Prop8, value.Prop8) &&
                Prop9 == value.Prop9;
        }

        public static bool operator ==(Builtins lhs, Builtins rhs)
        {
            if (Object.ReferenceEquals(lhs, rhs))
                return true;

            return !Object.ReferenceEquals(null, lhs) && lhs.Equals(rhs);
        }

        public static bool operator !=(Builtins lhs, Builtins rhs)
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
                hash = (hash * HashingMultiplier) ^ Prop0.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop1.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop2.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop3.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop4.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop5.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop6.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop7.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop8.GetHashCode();
                hash = (hash * HashingMultiplier) ^ Prop9.GetHashCode();
                return hash;
            }
        }
        #endregion
    }
}