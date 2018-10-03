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

namespace Dogen.TestModels.CSharpModel.Package1
{
    public sealed class AssociationInPackage
    {
        #region Properties
        public Dogen.TestModels.CSharpModel.PrimitiveBuiltins Prop0 { get; set; }
        public Dogen.TestModels.CSharpModel.ComplexBuiltins Prop1 { get; set; }
        public Dogen.TestModels.CSharpModel.Package1.Class1 Prop2 { get; set; }
        #endregion

        #region Constructors
        public AssociationInPackage() { }

        public AssociationInPackage(
            Dogen.TestModels.CSharpModel.PrimitiveBuiltins prop0,
            Dogen.TestModels.CSharpModel.ComplexBuiltins prop1,
            Dogen.TestModels.CSharpModel.Package1.Class1 prop2)
        {
            Prop0 = prop0;
            Prop1 = prop1;
            Prop2 = prop2;
        }
        #endregion

        #region Equality
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            var value = obj as AssociationInPackage;
            if (value == null) return false;

            return
                Prop0 != null && value.Prop0 != null &&
                Prop0.Equals(value.Prop0) &&
                Prop1 != null && value.Prop1 != null &&
                Prop1.Equals(value.Prop1) &&
                Prop2 != null && value.Prop2 != null &&
                Prop2.Equals(value.Prop2);
        }

        public static bool operator ==(AssociationInPackage lhs, AssociationInPackage rhs)
        {
            if (Object.ReferenceEquals(lhs, rhs))
                return true;

            return !Object.ReferenceEquals(null, lhs) && lhs.Equals(rhs);
        }

        public static bool operator !=(AssociationInPackage lhs, AssociationInPackage rhs)
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
                hash = (hash * HashingMultiplier) ^
                    (!object.ReferenceEquals(null, Prop0) ? Prop0.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^
                    (!object.ReferenceEquals(null, Prop1) ? Prop1.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^
                    (!object.ReferenceEquals(null, Prop2) ? Prop2.GetHashCode() : 0);
                return hash;
            }
        }
        #endregion
    }
}
