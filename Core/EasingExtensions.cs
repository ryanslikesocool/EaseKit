// Made with <3 by Ryan Boyer http://ryanjboyer.com

using UnityEngine;
using System.Runtime.CompilerServices;

namespace Easings
{
    public static class EasingExtensions
    {
        public static float Ease(this EasingType type, float time, float start, float delta, float duration)
        {
            Function func = type.GetFunction();
            return func.Ease(time, start, delta, duration);
        }

        public static Vector2 Ease(this EasingType type, float time, Vector2 start, Vector2 delta, float duration)
        {
            Function func = type.GetFunction();
            return new Vector2(
                func.Ease(time, start.x, delta.x, duration),
                func.Ease(time, start.y, delta.y, duration)
            );
        }

        public static Vector3 Ease(this EasingType type, float time, Vector3 start, Vector3 delta, float duration)
        {
            Function func = type.GetFunction();
            return new Vector3(
                func.Ease(time, start.x, delta.x, duration),
                func.Ease(time, start.y, delta.y, duration),
                func.Ease(time, start.z, delta.z, duration)
            );
        }

        public static Vector4 Ease(this EasingType type, float time, Vector4 start, Vector4 delta, float duration)
        {
            Function func = type.GetFunction();
            return new Vector4(
                func.Ease(time, start.x, delta.x, duration),
                func.Ease(time, start.y, delta.y, duration),
                func.Ease(time, start.z, delta.z, duration),
                func.Ease(time, start.w, delta.w, duration)
            );
        }

        public static Quaternion Ease(this EasingType type, float time, Quaternion start, Quaternion delta, float duration)
        {
            Function func = type.GetFunction();
            return new Quaternion(
                func.Ease(time, start.x, delta.x, duration),
                func.Ease(time, start.y, delta.y, duration),
                func.Ease(time, start.z, delta.z, duration),
                func.Ease(time, start.w, delta.w, duration)
            );
        }

        public static Color Ease(this EasingType type, float time, Color start, Color delta, float duration)
        {
            Function func = type.GetFunction();
            return new Color(
                func.Ease(time, start.r, delta.r, duration),
                func.Ease(time, start.g, delta.g, duration),
                func.Ease(time, start.b, delta.b, duration),
                func.Ease(time, start.a, delta.a, duration)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Function GetFunction(this EasingType easing)
        {
            switch (easing)
            {
                default:
                case EasingType.Linear:
                    return EasingFunctions.LinearEase;
                case EasingType.ExpoIn:
                    return EasingFunctions.ExpoIn;
                case EasingType.ExpoOut:
                    return EasingFunctions.ExpoOut;
                case EasingType.ExpoOutIn:
                    return EasingFunctions.ExpoOutIn;
                case EasingType.ExpoInOut:
                    return EasingFunctions.ExpoInOut;
                case EasingType.CircIn:
                    return EasingFunctions.CircIn;
                case EasingType.CircOut:
                    return EasingFunctions.CircOut;
                case EasingType.CircOutIn:
                    return EasingFunctions.CircOutIn;
                case EasingType.CircInOut:
                    return EasingFunctions.CircInOut;
                case EasingType.QuadIn:
                    return EasingFunctions.QuadIn;
                case EasingType.QuadOut:
                    return EasingFunctions.QuadOut;
                case EasingType.QuadOutIn:
                    return EasingFunctions.QuadOutIn;
                case EasingType.QuadInOut:
                    return EasingFunctions.QuadInOut;
                case EasingType.SineIn:
                    return EasingFunctions.SineIn;
                case EasingType.SineOut:
                    return EasingFunctions.SineOut;
                case EasingType.SineOutIn:
                    return EasingFunctions.SineOutIn;
                case EasingType.SineInOut:
                    return EasingFunctions.SineInOut;
                case EasingType.CubicIn:
                    return EasingFunctions.CubicIn;
                case EasingType.CubicOut:
                    return EasingFunctions.CubicOut;
                case EasingType.CubicOutIn:
                    return EasingFunctions.CubicOutIn;
                case EasingType.CubicInOut:
                    return EasingFunctions.CubicInOut;
                case EasingType.QuartIn:
                    return EasingFunctions.QuartIn;
                case EasingType.QuartOut:
                    return EasingFunctions.QuartOut;
                case EasingType.QuartOutIn:
                    return EasingFunctions.QuartOutIn;
                case EasingType.QuartInOut:
                    return EasingFunctions.QuartInOut;
                case EasingType.QuintIn:
                    return EasingFunctions.QuintIn;
                case EasingType.QuintOut:
                    return EasingFunctions.QuintOut;
                case EasingType.QuintOutIn:
                    return EasingFunctions.QuintOutIn;
                case EasingType.QuintInOut:
                    return EasingFunctions.QuintInOut;
                case EasingType.ElasticIn:
                    return EasingFunctions.ElasticIn;
                case EasingType.ElasticOut:
                    return EasingFunctions.ElasticOut;
                case EasingType.ElasticOutIn:
                    return EasingFunctions.ElasticOutIn;
                case EasingType.ElasticInOut:
                    return EasingFunctions.ElasticInOut;
                case EasingType.BounceIn:
                    return EasingFunctions.BounceIn;
                case EasingType.BounceOut:
                    return EasingFunctions.BounceOut;
                case EasingType.BounceOutIn:
                    return EasingFunctions.BounceOutIn;
                case EasingType.BounceInOut:
                    return EasingFunctions.BounceInOut;
                case EasingType.BackIn:
                    return EasingFunctions.BackIn;
                case EasingType.BackOut:
                    return EasingFunctions.BackOut;
                case EasingType.BackOutIn:
                    return EasingFunctions.BackOutIn;
                case EasingType.BackInOut:
                    return EasingFunctions.BackInOut;
            }
        }
    }
}