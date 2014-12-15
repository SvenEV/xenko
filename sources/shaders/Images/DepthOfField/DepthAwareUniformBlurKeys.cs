﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System.Linq;

namespace SiliconStudio.Paradox.Effects.Images
{
    /// <summary>
    /// Keys used by the DepthAwareUniformBlurEffect
    /// </summary>
    public static class DepthAwareUniformBlurKeys
    {
        public static readonly ParameterKey<int> Count = ParameterKeys.New<int>();
    }
}