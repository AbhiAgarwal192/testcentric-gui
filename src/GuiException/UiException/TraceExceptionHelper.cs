﻿// ***********************************************************************
// Copyright (c) 2018 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NUnit.UiException
{
    /// <summary>
    /// (formerly named TraceExceptionHelper)
    /// 
    /// Exposes static methods to assert predicates and throw exceptions
    /// as needed.
    /// </summary>
    public class UiExceptionHelper
    {
        /// <summary>
        /// Asserts that reference is not null; otherwise throws an
        /// ArgumentNullException.
        /// </summary>
        /// <param name="value">The reference to be tested.</param>
        /// <param name="paramName">The name of this reference</param>
        [DebuggerStepThrough]
        public static void CheckNotNull(object value, string paramName)
        {
            if (value == null)
                throw new ArgumentNullException(paramName);

            return;
        }

        /// <summary>
        /// Asserts that 'test' is true or throws an ArgumentException.
        /// </summary>
        /// <param name="test">The boolean to be tested.</param>
        /// <param name="message">The error message.</param>
        /// <param name="paramName">The parameter name to be passed to ArgumentException.</param>
        [DebuggerStepThrough]
        public static void CheckTrue(bool test, string message, string paramName)
        {
            if (!test)
                throw new ArgumentException(message, paramName);

            return;
        }

        /// <summary>
        /// Asserts that 'test' is false or throws an ArgumentException.
        /// </summary>
        /// <param name="test">The boolean to be tested.</param>
        /// <param name="message">The error message.</param>
        /// <param name="paramName">The parameter name to be passed to ArgumentException.</param>
        [DebuggerStepThrough]
        public static void CheckFalse(bool test, string message, string paramName)
        {
            if (test)
                throw new ArgumentException(message, paramName);

            return;
        }

        /// <summary>
        /// Throws an ApplicationException with the given message.
        /// </summary>
        /// <param name="message">The error message.</param>
        [DebuggerStepThrough]
        public static void Fail(string message)
        {
            throw new ApplicationException(message);
        }        
    }
}
