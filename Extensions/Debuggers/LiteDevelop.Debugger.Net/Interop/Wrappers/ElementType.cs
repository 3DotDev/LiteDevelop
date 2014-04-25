﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiteDevelop.Debugger.Net.Interop.Wrappers
{
    public enum ElementType : int
    {
        None = 0,
        Void = 1,
        Boolean = 2,
        Char = 3,
        I1 = 4,
        U1 = 5,
        U2 = 7,
        I2 = 6,
        I4 = 8,
        U4 = 9,
        I8 = 10,
        U8 = 11,
        R4 = 12,
        R8 = 13,
        String = 14,
        Ptr = 15,
        ByRef = 16,
        ValueType = 17,
        Class = 18,
        Var = 19,
        Array = 20,
        GenericInst = 21,
        TypedByRef = 22,
        I = 24,
        U = 25,
        FnPtr = 27,
        Object = 28,
        SzArray = 29,
        MVar = 30,
        CModReqD = 31,
        CModOpt = 32,
        Internal = 33,
        Modifier = 64,
        Sentinel = 65,
        Pinned = 69,
        Type = 80,
        Boxed = 81,
        Enum = 85,
    }
}
