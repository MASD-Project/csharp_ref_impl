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
using System.Collections;
using System.Collections.Generic;

namespace Dogen.TestModels.CSharpModel
{
    /// <summary>
    /// Generates sequences of ChildOfAChild1.
    /// </summary>
    public static class ChildOfAChild1SequenceGenerator
    {
        static internal void Populate(ChildOfAChild1 value, uint position)
        {
            Dogen.TestModels.CSharpModel.ThirdChildWithMembersSequenceGenerator.Populate(value, position);
            value.Prop2 = AssistantSequenceGenerator.CreateInt(position + 0);
        }

        static internal ChildOfAChild1 Create(uint position)
        {
            var result = new ChildOfAChild1();
            Populate(result, position);
            return result;
        }

        #region Enumerator
        private class ChildOfAChild1Enumerator : IEnumerator, IEnumerator<ChildOfAChild1>, IDisposable
        {
            #region Properties
            private uint _position;
            private ChildOfAChild1 _current;
            #endregion

            private void PopulateCurrent()
            {
                _current = ChildOfAChild1SequenceGenerator.Create(_position);
            }

            #region IDisposable
            public void Dispose()
            {
            }
            #endregion

            #region IEnumerator implementation
            public bool MoveNext()
            {
                ++_position;
                PopulateCurrent();
                return true;
            }

            public void Reset()
            {
                _position = 0;
                PopulateCurrent();
            }

            public object Current {
                get
                {
                    return _current;
                }
            }

            ChildOfAChild1 IEnumerator<ChildOfAChild1>.Current
            {
                get
                {
                    return _current;
                }
            }
            #endregion

            public ChildOfAChild1Enumerator()
            {
                PopulateCurrent();
            }
        }
        #endregion

        #region Enumerable
        private class ChildOfAChild1Enumerable : IEnumerable, IEnumerable<ChildOfAChild1>
        {
            #region IEnumerable implementation
            public IEnumerator GetEnumerator()
            {
                return new ChildOfAChild1Enumerator();
            }

            IEnumerator<ChildOfAChild1> IEnumerable<ChildOfAChild1>.GetEnumerator()
            {
                return new ChildOfAChild1Enumerator();
            }
            #endregion
        }
        #endregion

        static public IEnumerable<ChildOfAChild1> Sequence()
        {
            return new ChildOfAChild1Enumerable();
        }
    }
}
