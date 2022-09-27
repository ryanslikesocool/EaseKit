# Easings
40 non-linear easing methods to make transitions nicer in Unity.

## Requirements and Installation
**Requirements**\
The [Timer](https://github.com/ryanslikesocool/Timer) package is a required dependency.\
This package requires the `Unity.Mathematics` library.  It can be installed manually via the Package Manager, or added automatically when installing via the Package Manager.\
The Entities folder requires the DOTS packages.  These are hidden from the Package Manager but [can still be installed](https://forum.unity.com/threads/visibility-changes-for-preview-packages-in-2020-1.910880/).

**Recommended Installation** (Unity Package Manager)\
- "Add package from git URL..."
- `https://github.com/ryanslikesocool/Easings.git`

**Alternate Installation**\
- Get the latest [release](https://github.com/ryanslikesocool/Easings/releases)
- Open with the desired Unity project
- Import into the Plugins folder

## Core
Just the functions.  State and updating is handled by the developer (you!).\
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
Interpolator works similarly to Unity's default interpolation method, taking a start value and end value.\
Interpolator requires the [Timer package](https://github.com/ryanslikesocool/Timer) to work.\
Be sure to add `DWL_TIMER` to your scripting define symbols.

### Usage
`using Easings;`\
`Interpolator.Ease` has multiple overloads, so make sure to choose the right one.\
All `Interpolator.Ease` methods return a `Coroutine`, which can be stopped by calling `Timer.Stop(coroutine)` from the Timer package.

```cs
// "start" and "end" are optional values, but if you have one you must have both.
float start = 5; // default 0
float end = 7; // default 1
float duration = 2;
EasingType easing = EasingType.SineIn;
bool unscaledTime = false; // Optional value, "false" by default

Interpolator.Ease(start, end, duration, easing, easeData => {
    // This lambda will be called each time the interpolator updates, usually once a frame.

    // easeData contains the state of the easing, with values like
    // - the current easing type
    // - the current value
    // - the change between the current and previous value
}, () => {
    // Optional lamba, called one time when the easing is complete.
}, unscaledTime);
```

## Entities (NOT MAINTAINED)
Entities is meant for use with Unity's Data Oriented Tech Stack (DOTS).
 Entities does not require a manual update.
 Instead, you can add the required components to an entity and it will update automatically over time.
 An `InterpolatorAuthoring` MonoBehaviour is included for quick testing.
 Entities is meant for use with other systems, as the included `InterpolationSystems.cs` is only used for updating interpolator components.

### Usage
`using Easings.Entities;`\
Take a peek inside `InterpolatorAuthoring.cs` to see the required setup for entity interpolation.  The core components required for interpolation are as follows
- `InterpolatorStartTime`
- `InterpolatorDuration`
- `InterpolatorLocalTime`
- `InterpolatorPercent`
- `InterpolatorValue`
- `InterpolatorDone`
- one of the many `Ease` structs, found in `InterpolatorComponents.cs`
You can also use one of the extension methods to add, remove, and modify the Entities interpolator.  `EntityManager` can be replaced with `EntityCommandBuffer.ParallelWriter` for use inside of Jobs
- `EntityManager.AddInterpolator(Entity, EasingType);` - Adds all required components
- `EntityManager.RemoveInterpolator(Entity, EasingType);` - Removes all required components
- `EntityManager.AddEasing(Entity, EasingType)` - Adds only the easing function
- `EntityManager.RemoveEasing(Entity, EasingType)` - Removes only the easing function
- `EntityManager.SwapEasing(Entity, EasingType, EasingType)` - Removes the first easing function and adds the second

```cs
//Inside a System
protected override void OnUpdate()
{
    //Quick and dirty job, iterating over components with a Translation and InterpolatorValue.
    Entities.ForEach((ref Translation translation, in InterpolatorValue value) =>
    {
        //This moves the entity's position from -2 to 2 on the x axis
        //In this example, value.Value is unclamped, the entity will keep moving at that rate after the value is greater than one
        translation.Value.x = math.lerp(-2, 2, value.Value);
    }).Schedule();
}
```

## Notes
- Unused folders can be removed.  For example, if your project does not use DOTS, the Entities folder can be deleted.
- Required methods and objects are stored in the Core folder.

## Credits
[Robert Penner's Easing Functions](http://robertpenner.com/easing/)\
[acron0's C# port of Robert Penner's Easing Functions](https://github.com/acron0/Easings)
