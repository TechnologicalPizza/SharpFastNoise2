﻿using System.Runtime.CompilerServices;
using SharpFastNoise2.Functions;

namespace SharpFastNoise2.Distance
{
    public struct DistanceHybrid<m32, f32, i32, F> : IDistanceFunction<m32, f32, i32, F>
        where m32 : unmanaged
        where f32 : unmanaged
        where i32 : unmanaged
        where F : IFunctionList<m32, f32, i32, F>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static f32 CalcDistance(f32 dX, f32 dY)
        {
            f32 both = F.FMulAdd_f32(dX, dX, F.Abs(dX));
            both = F.Add(both, F.FMulAdd_f32(dY, dY, F.Abs(dY)));
            return both;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static f32 CalcDistance(f32 dX, f32 dY, f32 dZ)
        {
            f32 both = F.FMulAdd_f32(dX, dX, F.Abs(dX));
            both = F.Add(both, F.FMulAdd_f32(dY, dY, F.Abs(dY)));
            both = F.Add(both, F.FMulAdd_f32(dZ, dZ, F.Abs(dZ)));
            return both;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static f32 CalcDistance(f32 dX, f32 dY, f32 dZ, f32 dW)
        {
            f32 both = F.FMulAdd_f32(dX, dX, F.Abs(dX));
            both = F.Add(both, F.FMulAdd_f32(dY, dY, F.Abs(dY)));
            both = F.Add(both, F.FMulAdd_f32(dZ, dZ, F.Abs(dZ)));
            both = F.Add(both, F.FMulAdd_f32(dW, dW, F.Abs(dW)));
            return both;
        }
    }
}
