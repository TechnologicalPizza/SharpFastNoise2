﻿using SharpFastNoise2;

namespace Benchmarks
{
    public class BenchNoiseBase<mask32v, float32v, int32v, TFunc>
        where TFunc : IFunctionList<mask32v, float32v, int32v>, new()
    {
        private const int Seed = 1234;
        private const float Mul = 0.01f;

        public void Generate1D<TGen>(int count)
            where TGen : INoiseGenerator1D<float32v, int32v>, new()
        {
            var noise = new TGen();
            var fn = new TFunc();
            var seed = fn.Broad_i32(Seed);
            for (int x = 0; x < count; x += noise.Count)
            {
                noise.Gen(seed, fn.Broad_f32(x * Mul));
            }
        }

        public void Generate2D<TGen>(int count)
            where TGen : INoiseGenerator2D<float32v, int32v>, new()
        {
            var noise = new TGen();
            var fn = new TFunc();
            var seed = fn.Broad_i32(Seed);
            for (int x = 0; x < count; x += noise.Count)
            {
                noise.Gen(seed, fn.Broad_f32(x * Mul), default);
            }
        }

        public void Generate3D<TGen>(int count)
            where TGen : INoiseGenerator3D<float32v, int32v>, new()
        {
            var noise = new TGen();
            var fn = new TFunc();
            var seed = fn.Broad_i32(Seed);
            for (int x = 0; x < count; x += noise.Count)
            {
                noise.Gen(seed, fn.Broad_f32(x * Mul), default, default);
            }
        }

        public void Generate4D<TGen>(int count)
            where TGen : INoiseGenerator4D<float32v, int32v>, new()
        {
            var noise = new TGen();
            var fn = new TFunc();
            var seed = fn.Broad_i32(Seed);
            for (int x = 0; x < count; x += noise.Count)
            {
                noise.Gen(seed, fn.Broad_f32(x * Mul), default, default, default);
            }
        }
    }
}