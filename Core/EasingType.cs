// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using UnityEngine;

namespace Easings {
    public enum EasingType {
        Linear,
        [InspectorName("Exponential Out")] ExpoOut,
        [InspectorName("Exponential In")] ExpoIn,
        [InspectorName("Exponential In Out")] ExpoInOut,
        [InspectorName("Exponential Out In")] ExpoOutIn,
        [InspectorName("Circular Out")] CircOut,
        [InspectorName("Circular In")] CircIn,
        [InspectorName("Circular In Out")] CircInOut,
        [InspectorName("Circular Out In")] CircOutIn,
        [InspectorName("Quadratic Out")] QuadOut,
        [InspectorName("Quadratic In")] QuadIn,
        [InspectorName("Quadratic In Out")] QuadInOut,
        [InspectorName("Quadratic Out In")] QuadOutIn,
        SineOut,
        SineIn,
        SineInOut,
        SineOutIn,
        CubicOut,
        CubicIn,
        CubicInOut,
        CubicOutIn,
        [InspectorName("Quartic Out")] QuartOut,
        [InspectorName("Quartic In")] QuartIn,
        [InspectorName("Quartic In Out")] QuartInOut,
        [InspectorName("Quartic Out In")] QuartOutIn,
        [InspectorName("Quintic Out")] QuintOut,
        [InspectorName("Quintic In")] QuintIn,
        [InspectorName("Quintic In Out")] QuintInOut,
        [InspectorName("Quintic Out In")] QuintOutIn,
        ElasticOut,
        ElasticIn,
        ElasticInOut,
        ElasticOutIn,
        BounceOut,
        BounceIn,
        BounceInOut,
        BounceOutIn,
        BackOut,
        BackIn,
        BackInOut,
        BackOutIn
    }
}