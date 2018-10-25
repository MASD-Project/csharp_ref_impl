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

namespace Masd.CSharpRefImpl.DirectorySettings
{
    /// <summary>
    /// Generates sequences of Class0.
    /// </summary>
    public static class Class0SequenceGenerator
    {
        static internal void Populate(Class0 value, uint position)
        {
            value.Prop0 = AssistantSequenceGenerator.CreateInt(position + 0);
        }

        static internal Class0 Create(uint position)
        {
            var result = new Class0();
            Populate(result, position);
            return result;
        }

        #region Enumerator
        private class Class0Enumerator : IEnumerator, IEnumerator<Class0>, IDisposable
        {
            #region Properties
            private uint _position;
            private Class0 _current;
            #endregion

            private void PopulateCurrent()
            {
                _current = Class0SequenceGenerator.Create(_position);
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

            Class0 IEnumerator<Class0>.Current
            {
                get
                {
                    return _current;
                }
            }
            #endregion

            public Class0Enumerator()
            {
                PopulateCurrent();
            }
        }
        #endregion

        #region Enumerable
        private class Class0Enumerable : IEnumerable, IEnumerable<Class0>
        {
            #region IEnumerable implementation
            public IEnumerator GetEnumerator()
            {
                return new Class0Enumerator();
            }

            IEnumerator<Class0> IEnumerable<Class0>.GetEnumerator()
            {
                return new Class0Enumerator();
            }
            #endregion
        }
        #endregion

        static public IEnumerable<Class0> Sequence()
        {
            return new Class0Enumerable();
        }
    }
}
