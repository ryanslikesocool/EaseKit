// Made with <3 by Ryan Boyer http://ryanjboyer.com

using UnityEngine;

namespace Easings.Convenience
{
    // t = time
    // b = start
    // c = delta
    // d = duration
    public static class ConvenienceEasings
    {
        public static float Linear(float t, float b, float c, float d)
        {
            return EasingFunctions.Linear.Ease(t, b, c, d);
        }
        public static Vector2 Linear(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Linear.Ease(t, b.x, c.x, d),
                EasingFunctions.Linear.Ease(t, b.y, c.y, d)
            );
        }
        public static Vector3 Linear(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Linear.Ease(t, b.x, c.x, d),
                EasingFunctions.Linear.Ease(t, b.y, c.y, d),
                EasingFunctions.Linear.Ease(t, b.z, c.z, d)
            );
        }
        public static Vector4 Linear(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                EasingFunctions.Linear.Ease(t, b.x, c.x, d),
                EasingFunctions.Linear.Ease(t, b.y, c.y, d),
                EasingFunctions.Linear.Ease(t, b.z, c.z, d),
                EasingFunctions.Linear.Ease(t, b.w, c.w, d)
            );
        }
        public static Quaternion Linear(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                EasingFunctions.Linear.Ease(t, b.x, c.x, d),
                EasingFunctions.Linear.Ease(t, b.y, c.y, d),
                EasingFunctions.Linear.Ease(t, b.z, c.z, d),
                EasingFunctions.Linear.Ease(t, b.w, c.w, d)
            );
        }

        public static float ExpoEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Expo.EaseOut(t, b, c, d);
        }
        public static Vector2 ExpoEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Expo.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Expo.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 ExpoEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Expo.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Expo.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Expo.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 ExpoEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Expo.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Expo.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Expo.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Expo.EaseOut(t, b.w, c.w, d)
             );
        }
        public static Quaternion ExpoEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Expo.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Expo.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Expo.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Expo.EaseOut(t, b.w, c.w, d)
             );
        }

        public static float ExpoEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Expo.EaseIn(t, b, c, d);
        }
        public static Vector2 ExpoEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Expo.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Expo.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 ExpoEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Expo.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Expo.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Expo.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 ExpoEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Expo.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Expo.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Expo.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Expo.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion ExpoEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Expo.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Expo.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Expo.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Expo.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float ExpoEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Expo.EaseInOut(t, b, c, d);
        }
        public static Vector2 ExpoEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Expo.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Expo.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 ExpoEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Expo.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Expo.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Expo.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 ExpoEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Expo.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Expo.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Expo.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Expo.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion ExpoEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Expo.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Expo.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Expo.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Expo.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float ExpoEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Expo.EaseOutIn(t, b, c, d);
        }
        public static Vector2 ExpoEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Expo.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Expo.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 ExpoEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Expo.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Expo.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Expo.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 ExpoEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Expo.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Expo.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Expo.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Expo.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion ExpoEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Expo.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Expo.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Expo.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Expo.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float CircEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Circ.EaseOut(t, b, c, d);
        }
        public static Vector2 CircEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Circ.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Circ.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 CircEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Circ.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Circ.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Circ.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 CircEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Circ.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Circ.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Circ.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Circ.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion CircEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Circ.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Circ.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Circ.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Circ.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float CircEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Circ.EaseIn(t, b, c, d);
        }
        public static Vector2 CircEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Circ.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Circ.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 CircEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Circ.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Circ.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Circ.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 CircEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Circ.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Circ.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Circ.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Circ.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion CircEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Circ.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Circ.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Circ.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Circ.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float CircEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Circ.EaseInOut(t, b, c, d);
        }
        public static Vector2 CircEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Circ.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Circ.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 CircEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Circ.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Circ.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Circ.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 CircEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Circ.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Circ.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Circ.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Circ.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion CircEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Circ.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Circ.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Circ.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Circ.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float CircEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Circ.EaseOutIn(t, b, c, d);
        }
        public static Vector2 CircEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Circ.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Circ.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 CircEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Circ.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Circ.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Circ.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 CircEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Circ.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Circ.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Circ.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Circ.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion CircEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Circ.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Circ.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Circ.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Circ.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float QuadEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Quad.EaseOut(t, b, c, d);
        }
        public static Vector2 QuadEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quad.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Quad.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuadEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quad.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Quad.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Quad.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuadEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quad.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Quad.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Quad.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Quad.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuadEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quad.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Quad.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Quad.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Quad.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float QuadEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Quad.EaseIn(t, b, c, d);
        }
        public static Vector2 QuadEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quad.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Quad.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuadEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quad.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Quad.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Quad.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuadEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quad.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Quad.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Quad.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Quad.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuadEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quad.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Quad.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Quad.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Quad.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float QuadEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Quad.EaseInOut(t, b, c, d);
        }
        public static Vector2 QuadEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quad.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Quad.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuadEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quad.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Quad.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Quad.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuadEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quad.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Quad.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Quad.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Quad.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuadEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quad.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Quad.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Quad.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Quad.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float QuadEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Quad.EaseOutIn(t, b, c, d);
        }
        public static Vector2 QuadEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quad.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Quad.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuadEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quad.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Quad.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Quad.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuadEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quad.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Quad.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Quad.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Quad.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuadEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quad.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Quad.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Quad.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Quad.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float SineEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Sine.EaseOut(t, b, c, d);
        }
        public static Vector2 SineEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Sine.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Sine.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 SineEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Sine.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Sine.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Sine.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 SineEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Sine.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Sine.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Sine.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Sine.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion SineEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Sine.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Sine.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Sine.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Sine.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float SineEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Sine.EaseIn(t, b, c, d);
        }
        public static Vector2 SineEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Sine.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Sine.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 SineEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Sine.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Sine.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Sine.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 SineEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Sine.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Sine.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Sine.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Sine.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion SineEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Sine.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Sine.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Sine.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Sine.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float SineEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Sine.EaseInOut(t, b, c, d);
        }
        public static Vector2 SineEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Sine.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Sine.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 SineEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Sine.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Sine.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Sine.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 SineEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Sine.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Sine.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Sine.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Sine.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion SineEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Sine.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Sine.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Sine.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Sine.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float SineEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Sine.EaseOutIn(t, b, c, d);
        }
        public static Vector2 SineEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Sine.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Sine.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 SineEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Sine.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Sine.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Sine.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 SineEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Sine.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Sine.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Sine.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Sine.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion SineEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Sine.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Sine.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Sine.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Sine.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float CubicEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Cubic.EaseOut(t, b, c, d);
        }
        public static Vector2 CubicEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Cubic.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Cubic.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 CubicEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Cubic.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Cubic.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Cubic.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 CubicEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Cubic.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Cubic.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Cubic.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Cubic.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion CubicEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Cubic.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Cubic.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Cubic.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Cubic.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float CubicEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Cubic.EaseIn(t, b, c, d);
        }
        public static Vector2 CubicEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Cubic.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Cubic.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 CubicEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Cubic.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Cubic.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Cubic.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 CubicEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Cubic.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Cubic.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Cubic.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Cubic.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion CubicEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Cubic.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Cubic.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Cubic.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Cubic.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float CubicEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Cubic.EaseInOut(t, b, c, d);
        }
        public static Vector2 CubicEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Cubic.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Cubic.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 CubicEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Cubic.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Cubic.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Cubic.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 CubicEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Cubic.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Cubic.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Cubic.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Cubic.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion CubicEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Cubic.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Cubic.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Cubic.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Cubic.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float CubicEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Cubic.EaseOutIn(t, b, c, d);
        }
        public static Vector2 CubicEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Cubic.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Cubic.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 CubicEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Cubic.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Cubic.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Cubic.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 CubicEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Cubic.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Cubic.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Cubic.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Cubic.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion CubicEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Cubic.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Cubic.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Cubic.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Cubic.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float QuartEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Quart.EaseOut(t, b, c, d);
        }
        public static Vector2 QuartEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quart.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Quart.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuartEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quart.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Quart.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Quart.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuartEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quart.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Quart.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Quart.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Quart.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuartEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quart.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Quart.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Quart.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Quart.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float QuartEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Quart.EaseIn(t, b, c, d);
        }
        public static Vector2 QuartEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quart.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Quart.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuartEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quart.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Quart.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Quart.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuartEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quart.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Quart.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Quart.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Quart.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuartEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quart.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Quart.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Quart.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Quart.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float QuartEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Quart.EaseInOut(t, b, c, d);
        }
        public static Vector2 QuartEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quart.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Quart.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuartEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quart.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Quart.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Quart.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuartEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quart.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Quart.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Quart.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Quart.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuartEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quart.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Quart.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Quart.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Quart.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float QuartEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Quart.EaseOutIn(t, b, c, d);
        }
        public static Vector2 QuartEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quart.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Quart.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuartEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quart.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Quart.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Quart.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuartEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quart.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Quart.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Quart.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Quart.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuartEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quart.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Quart.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Quart.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Quart.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float QuintEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Quint.EaseOut(t, b, c, d);
        }
        public static Vector2 QuintEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quint.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Quint.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuintEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quint.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Quint.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Quint.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuintEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quint.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Quint.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Quint.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Quint.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuintEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quint.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Quint.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Quint.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Quint.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float QuintEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Quint.EaseIn(t, b, c, d);
        }
        public static Vector2 QuintEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quint.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Quint.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuintEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quint.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Quint.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Quint.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuintEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quint.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Quint.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Quint.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Quint.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuintEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quint.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Quint.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Quint.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Quint.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float QuintEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Quint.EaseInOut(t, b, c, d);
        }
        public static Vector2 QuintEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quint.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Quint.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuintEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quint.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Quint.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Quint.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuintEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quint.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Quint.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Quint.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Quint.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuintEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quint.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Quint.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Quint.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Quint.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float QuintEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Quint.EaseOutIn(t, b, c, d);
        }
        public static Vector2 QuintEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Quint.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Quint.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 QuintEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Quint.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Quint.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Quint.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 QuintEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Quint.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Quint.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Quint.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Quint.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion QuintEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Quint.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Quint.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Quint.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Quint.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float ElasticEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Elastic.EaseOut(t, b, c, d);
        }
        public static Vector2 ElasticEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Elastic.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Elastic.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 ElasticEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Elastic.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Elastic.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Elastic.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 ElasticEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Elastic.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Elastic.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Elastic.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Elastic.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion ElasticEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Elastic.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Elastic.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Elastic.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Elastic.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float ElasticEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Elastic.EaseIn(t, b, c, d);
        }
        public static Vector2 ElasticEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Elastic.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Elastic.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 ElasticEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Elastic.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Elastic.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Elastic.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 ElasticEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Elastic.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Elastic.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Elastic.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Elastic.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion ElasticEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Elastic.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Elastic.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Elastic.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Elastic.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float ElasticEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Elastic.EaseInOut(t, b, c, d);
        }
        public static Vector2 ElasticEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Elastic.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Elastic.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 ElasticEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Elastic.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Elastic.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Elastic.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 ElasticEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Elastic.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Elastic.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Elastic.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Elastic.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion ElasticEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Elastic.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Elastic.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Elastic.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Elastic.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float ElasticEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Elastic.EaseOutIn(t, b, c, d);
        }
        public static Vector2 ElasticEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Elastic.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Elastic.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 ElasticEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Elastic.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Elastic.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Elastic.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 ElasticEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Elastic.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Elastic.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Elastic.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Elastic.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion ElasticEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Elastic.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Elastic.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Elastic.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Elastic.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float BounceEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Bounce.EaseOut(t, b, c, d);
        }
        public static Vector2 BounceEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Bounce.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Bounce.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 BounceEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Bounce.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Bounce.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Bounce.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 BounceEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Bounce.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Bounce.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Bounce.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Bounce.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion BounceEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Bounce.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Bounce.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Bounce.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Bounce.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float BounceEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Bounce.EaseIn(t, b, c, d);
        }
        public static Vector2 BounceEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Bounce.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Bounce.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 BounceEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Bounce.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Bounce.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Bounce.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 BounceEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Bounce.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Bounce.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Bounce.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Bounce.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion BounceEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Bounce.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Bounce.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Bounce.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Bounce.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float BounceEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Bounce.EaseInOut(t, b, c, d);
        }
        public static Vector2 BounceEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Bounce.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Bounce.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 BounceEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Bounce.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Bounce.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Bounce.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 BounceEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Bounce.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Bounce.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Bounce.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Bounce.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion BounceEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Bounce.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Bounce.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Bounce.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Bounce.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float BounceEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Bounce.EaseOutIn(t, b, c, d);
        }
        public static Vector2 BounceEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Bounce.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Bounce.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 BounceEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Bounce.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Bounce.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Bounce.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 BounceEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Bounce.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Bounce.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Bounce.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Bounce.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion BounceEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Bounce.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Bounce.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Bounce.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Bounce.EaseOutIn(t, b.w, c.w, d)
            );
        }

        public static float BackEaseOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Back.EaseOut(t, b, c, d);
        }
        public static Vector2 BackEaseOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Back.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Back.EaseOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 BackEaseOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Back.EaseOut(t, b.x, c.x, d),
                EasingFunctions.Back.EaseOut(t, b.y, c.y, d),
                EasingFunctions.Back.EaseOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 BackEaseOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Back.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Back.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Back.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Back.EaseOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion BackEaseOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Back.EaseOut(t, b.x, c.x, d),
                 EasingFunctions.Back.EaseOut(t, b.y, c.y, d),
                 EasingFunctions.Back.EaseOut(t, b.z, c.z, d),
                 EasingFunctions.Back.EaseOut(t, b.w, c.w, d)
            );
        }

        public static float BackEaseIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Back.EaseIn(t, b, c, d);
        }
        public static Vector2 BackEaseIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Back.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Back.EaseIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 BackEaseIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Back.EaseIn(t, b.x, c.x, d),
                EasingFunctions.Back.EaseIn(t, b.y, c.y, d),
                EasingFunctions.Back.EaseIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 BackEaseIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Back.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Back.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Back.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Back.EaseIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion BackEaseIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Back.EaseIn(t, b.x, c.x, d),
                 EasingFunctions.Back.EaseIn(t, b.y, c.y, d),
                 EasingFunctions.Back.EaseIn(t, b.z, c.z, d),
                 EasingFunctions.Back.EaseIn(t, b.w, c.w, d)
            );
        }

        public static float BackEaseInOut(float t, float b, float c, float d)
        {
            return EasingFunctions.Back.EaseInOut(t, b, c, d);
        }
        public static Vector2 BackEaseInOut(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Back.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Back.EaseInOut(t, b.y, c.y, d)
            );
        }
        public static Vector3 BackEaseInOut(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Back.EaseInOut(t, b.x, c.x, d),
                EasingFunctions.Back.EaseInOut(t, b.y, c.y, d),
                EasingFunctions.Back.EaseInOut(t, b.z, c.z, d)
            );
        }
        public static Vector4 BackEaseInOut(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Back.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Back.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Back.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Back.EaseInOut(t, b.w, c.w, d)
            );
        }
        public static Quaternion BackEaseInOut(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Back.EaseInOut(t, b.x, c.x, d),
                 EasingFunctions.Back.EaseInOut(t, b.y, c.y, d),
                 EasingFunctions.Back.EaseInOut(t, b.z, c.z, d),
                 EasingFunctions.Back.EaseInOut(t, b.w, c.w, d)
            );
        }

        public static float BackEaseOutIn(float t, float b, float c, float d)
        {
            return EasingFunctions.Back.EaseOutIn(t, b, c, d);
        }
        public static Vector2 BackEaseOutIn(float t, Vector2 b, Vector2 c, float d)
        {
            return new Vector2(
                EasingFunctions.Back.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Back.EaseOutIn(t, b.y, c.y, d)
            );
        }
        public static Vector3 BackEaseOutIn(float t, Vector3 b, Vector3 c, float d)
        {
            return new Vector3(
                EasingFunctions.Back.EaseOutIn(t, b.x, c.x, d),
                EasingFunctions.Back.EaseOutIn(t, b.y, c.y, d),
                EasingFunctions.Back.EaseOutIn(t, b.z, c.z, d)
            );
        }
        public static Vector4 BackEaseOutIn(float t, Vector4 b, Vector4 c, float d)
        {
            return new Vector4(
                 EasingFunctions.Back.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Back.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Back.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Back.EaseOutIn(t, b.w, c.w, d)
            );
        }
        public static Quaternion BackEaseOutIn(float t, Quaternion b, Quaternion c, float d)
        {
            return new Quaternion(
                 EasingFunctions.Back.EaseOutIn(t, b.x, c.x, d),
                 EasingFunctions.Back.EaseOutIn(t, b.y, c.y, d),
                 EasingFunctions.Back.EaseOutIn(t, b.z, c.z, d),
                 EasingFunctions.Back.EaseOutIn(t, b.w, c.w, d)
            );
        }
    }
}
