using System.Runtime.CompilerServices;

namespace System
{
	partial class MathF
	{
		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Acos (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Acosh (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Asin (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Asinh (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Atan (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Atan2 (float y, float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Atanh (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Cbrt (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Ceiling (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Cos (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Cosh (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Exp (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Floor (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Log (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Log10 (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Pow (float x, float y);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Sin (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Sinh (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Sqrt (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Tan (float x);

		[MethodImpl (MethodImplOptions.InternalCall)]
		public static extern float Tanh (float x);

		// [Intrinsic] TODO: implement intrinsic  (FMA)
		[MethodImpl  (MethodImplOptions.InternalCall)]
		public static extern float FusedMultiplyAdd (float x, float y, float z);

		[MethodImpl  (MethodImplOptions.InternalCall)]
		public static extern int ILogB (float x);

		[MethodImpl  (MethodImplOptions.InternalCall)]
		public static extern float Log2 (float x);

		[MethodImpl  (MethodImplOptions.InternalCall)]
		public static extern float ScaleB (float x, int n);

		[MethodImpl (MethodImplOptions.InternalCall)]
		static extern float FMod (float x, float y);
		
		[MethodImpl (MethodImplOptions.InternalCall)]
		static extern unsafe float ModF (float x, float* intptr);		
	}
}