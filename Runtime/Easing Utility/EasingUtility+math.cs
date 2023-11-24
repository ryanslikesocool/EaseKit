// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
#if UNITY_MATHEMATICS
using Unity.Mathematics;
#endif

namespace EaseKit {
	public static partial class EasingUtility {
		internal delegate float f_f_delegate(float v);
		internal delegate float ff_f_delegate(float v, float n);
		internal delegate float fff_f_delegate(float x, float y, float t);
#if UNITY_MATHEMATICS
		internal const float PI = math.PI;
		internal const float TAU = PI * 2;
		internal static readonly f_f_delegate sqrt = math.sqrt;
		internal static readonly ff_f_delegate pow = math.pow;
		internal static readonly f_f_delegate exp = math.exp;
		internal static readonly f_f_delegate sin = math.sin;
		internal static readonly f_f_delegate cos = math.cos;
		internal static readonly f_f_delegate sinh = math.sinh;
		internal static readonly f_f_delegate cosh = math.cosh;
		internal static readonly f_f_delegate abs = math.abs;
		internal static readonly fff_f_delegate lerp = math.lerp;
#else
        internal const float PI = Mathf.Pi;
        internal const float TAU = PI * 2;
        internal static readonly f_f_delegate sqrt = Mathf.Sqrt;
        internal static readonly ff_f_delegate pow = Mathf.Pow;
        internal static readonly f_f_delegate exp = Mathf.Exp;
        internal static readonly f_f_delegate sin = Mathf.Sin;
        internal static readonly f_f_delegate cos = Mathf.Cos;
        internal static readonly f_f_delegate sinh = Mathf.Sinh;
        internal static readonly f_f_delegate cosh = Mathf.Cosh;
        internal static readonly f_f_delegate abs = Mathf.Abs;
        internal static readonly fff_f_delegate lerp = Mathf.Lerp;
#endif

#if FOUNDATION_PACKAGE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Function GetFirstDerivativeFunction(this Easing easing, float epsilon = Foundation.Extensions.EPSILON7)
			=> easing.GetFunction().GetFirstDerivativeFunction(epsilon);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Function GetFirstDerivativeFunction(this Function func, float epsilon = Foundation.Extensions.EPSILON7) {
			float function(float t, float b, float c, float d) {
				return Foundation.Extensions.DerivativeOf(t => func(t, b, c, d), t, epsilon);
			}

			return function;
		}
#endif
	}
}