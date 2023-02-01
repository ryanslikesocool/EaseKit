// Developed With Love by Ryan Boyer http://ryanjboyer.com <3

using UnityEngine;

namespace EaseKit {
    public enum Easing : byte {
        [InspectorName("Linear")] Linear,
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
        [InspectorName("Sine Out")] SineOut,
        [InspectorName("Sine In")] SineIn,
        [InspectorName("Sine In Out")] SineInOut,
        [InspectorName("Sine Out In")] SineOutIn,
        [InspectorName("Cubic Out")] CubicOut,
        [InspectorName("Cubic In")] CubicIn,
        [InspectorName("Cubic In Out")] CubicInOut,
        [InspectorName("Cubic Out In")] CubicOutIn,
        [InspectorName("Quartic Out")] QuartOut,
        [InspectorName("Quartic In")] QuartIn,
        [InspectorName("Quartic In Out")] QuartInOut,
        [InspectorName("Quartic Out In")] QuartOutIn,
        [InspectorName("Quintic Out")] QuintOut,
        [InspectorName("Quintic In")] QuintIn,
        [InspectorName("Quintic In Out")] QuintInOut,
        [InspectorName("Quintic Out In")] QuintOutIn,
        [InspectorName("Elastic Out")] ElasticOut,
        [InspectorName("Elastic In")] ElasticIn,
        [InspectorName("Elastic In Out")] ElasticInOut,
        [InspectorName("Elastic Out In")] ElasticOutIn,
        [InspectorName("Bounce Out")] BounceOut,
        [InspectorName("Bounce Out In")] BounceIn,
        [InspectorName("Bounce In Out")] BounceInOut,
        [InspectorName("Bounce Out In")] BounceOutIn,
        [InspectorName("Back Out")] BackOut,
        [InspectorName("Back In")] BackIn,
        [InspectorName("Back In Out")] BackInOut,
        [InspectorName("Back Out In")] BackOutIn
    }
}