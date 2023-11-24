// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EaseKit {
	public readonly struct ColorInterpolator : IInterpolator<Color> {
		public static readonly ColorInterpolator shared = new ColorInterpolator();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Color Evaluate(in Color start, in Color end, float percent)
			=> Color.Lerp(start, end, percent);
	}
}