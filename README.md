# Easings
40 non-linear easing methods to make transitions nicer in Unity.

## Requirements and Installation
**Requirements**\
The [Timer](https://github.com/ryanslikesocool/Timer) package is a required dependency.\
This package requires the `Unity.Mathematics` library.  It can be installed via the Package Manager.\

**Recommended Installation** (Unity Package Manager)\
- "Add package from git URL..."
- `https://github.com/ryanslikesocool/Easings.git`

**Alternate Installation**\
- Get the latest [release](https://github.com/ryanslikesocool/Easings/releases)
- Open with the desired Unity project
- Import into the Plugins folder

All default functions return a `float` and takes the 4 `float` parameters.  There are multiple ways to call them.

## Usage
```cs
// Replace "SineIn" with the desired easing
float time = 0;
float start = 0;
float delta = 1;
float duration = 1;
float result;

// Best for hardcoded easing functions
result = EasingFunctions.SineIn.Ease(time, start, delta, duration);

// Best for editor support
EasingType easingType = EasingType.SineIn;
result = easingType.Ease(time, start, delta, duration);

// The EasingType.SineIn.Ease() function also has overloads for easing Unity types, like vectors and colors
```

The function itself can also be stored as an object.
```cs
// Replace "SineIn" with the desired easing
float time = 0;
float start = 0;
float delta = 1;
float duration = 1;
float result;

EasingType easingType = EasingType.SineIn;
Function easeFunction = easingType.GetFunction();
result = easeFunction.Ease(time, start, delta, duration);
```

## Interpolator
The Interpolator methods handle updating for you, and works with all built-in easing methods.\
Interpolator works similarly to Unity's default interpolation methods, taking a start value and end value.\

### Usage
`using Easings;`\
`Interpolator.Ease` has multiple overloads with different parameters to fit your needs.\
All `Interpolator.Ease` methods return a `Coroutine`, which can be stopped by calling `Timer.Stop(coroutine)` from the Timer package, or `coroutine.Stop()`.

```cs
// "start" and "end" are optional values, but if you have one you must have both.
float start = 5; // default 0
float end = 7; // default 1
float duration = 2;
EasingType easing = EasingType.SineIn;
bool unscaledTime = false; // Optional value, "false" by default

Coroutine coroutine = Interpolator.Ease(start, end, duration, easing, easeData => {
    // This lambda will be called each time the interpolator updates, usually once a frame.

    // easeData contains the state of the easing, with values like
    // - the current easing type
    // - the current value
    // - the change between the current and previous value
}, () => {
    // Optional lamba, called one time when the easing is complete.
}, unscaledTime);
```

## Acknowledgements
[Robert Penner's Easing Functions](http://robertpenner.com/easing/)\
[acron0's C# port of Robert Penner's Easing Functions](https://github.com/acron0/Easings)
