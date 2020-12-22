// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_ReceiveMessage")]
        internal static extern unsafe Error ReceiveMessage(SafeHandle socket, MessageHeader* messageHeader, SocketFlags flags, long* received);
    }
}
