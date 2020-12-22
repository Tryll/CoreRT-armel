// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class User32
    {
        [DllImport(Libraries.User32, CharSet=CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr FindWindowW(string lpClassName, string lpWindowName);
    }
}