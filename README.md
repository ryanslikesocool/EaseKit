# Unity-Easings
41 easing methods to make transitions nicer in Unity

## Requirements and Installation
**Requirements**\
This package requires the `Unity.Mathematics` library.  It can be installed manually via the Package Manager, or added automatically when installing via the Package Manager.\
 The DOTS folder requires the DOTS packages.  These are hidden from the Package Manager but [can still be installed](https://forum.unity.com/threads/visibility-changes-for-preview-packages-in-2020-1.910880/).

**RECOMMENDED INSTALLATION**\
Add via the Unity Package Manager\
"Add package from git URL..."\
`https://github.com/ryanslikesocool/Easings.git`\
Add

**Not-so Recommended Installation**\
Get the latest [release](https://github.com/ryanslikesocool/Easings/releases)\
Open with the desired Unity project\
Import into the Plugins folder

## Core
Just the functions.  All default functions return a `float` and takes the 4 `float` parameters.

### Usage
`using Easings;`\
You can call an easing function with either `EasingFunctions.Category.Function` or `EasingFunctions.CategoryFunction`, like this
```cs
EasingFunctions.Quad.EaseOut(time, start, delta, duration);
EasingFunctions.QuadOut(time, start, delta, duration);
```
These functions take 4 `float` parameters
- `time` - the time of the interpolation.  Between 0 and `duration` is best
- `start` - the start value.  This can be any number
- `delta` - the change from the start value
- `duration` - how long the interpolation will last
- returns `t` - the value between `start` and `start + delta` sampled by `time / duration`

There are also extension methods that can make life easier, if desired.
 `EasingType.QuadOut.Ease(time, start, delta, duration);`\
`start` and `delta` can be any of the following types, and will return the same type
- `float`
- `Vector2`
- `Vector3`
- `Vector4`
- `Quaternion`
- `Color`

## Interpolator
The Interpolator stores easing data in a class, meant for reuse.
 Interpolator provides all easing methods with the return type of `float`, meant for use with the default interpolation methods that Unity provides (`Vector3.Lerp(a, b, t)`, `Color.Lerp(a, b, t)`, etc.). 
 Interpolator works similarly to Unity's default interpolation method, taking a start value and end value.

### Usage
`using Easings.Interpolator;`\
Create an Interpolator with an easing type, input the start value, end value, and duration in `Begin(a, b, d)`.  The call its `Update()` method over time.

```cs
IEnumerator LinearEase()
{
    // Create the Interpolator
    // This comes with an overload for choosing the easing function.
    // The default function is Linear with an overload for setting a specific function
    Interpolator interpolator = new Interpolator();
    // Start value = 0
    // End value = 1
    // Duration = 1
    interpolator.Begin(0, 1, 1);

    while (!interpolator.Done)
    {
        // Update the time with Interpolator.Update().  This is necessary to get out of the loop
        // Interpolator.Update() comes with 2 overloads if you want to use a custom deltaTime or unscaled time, and returns the current Interpolator value
        // Do something with the value, such as:
        transform.position = Vector3.Lerp(Vector3.zero, Vector3.up, interpolator.Update());
        
        yield return null;
    }
    
    // Finalizing the interpolation is only necessary if the duration is 0
    transform.position = Vector3.up;
}
```
Or, if you're looking for something a little more readable, there's a coroutine in Interpolator that handles a lot of the boilerplate.\
Interpolator.While takes 4 parameters: 
- `Action<Interpolator> updateAction` - the action to execute while the Interpolator is updating (called once a frame until the Interpolator is done)
- `Action<Interpolator> doneAction` (optional) - the action to execute once the Interpolator is done (called once)
- `float deltaTime` (optional) - the delta time to use every frame.  Leave at the default `-1` to use `Time.deltaTime`
- `bool unscaled` (optional) - uses unscaled time if set to `true`.  Only works if `deltaTime` is the default `-1`
```cs
thisMonoBehaviour.StartCoroutine(interpolator.While((Interpolator i) =>
{
    transform.position = Vector3.Lerp(Vector3.zero, Vector3.up, i.value);
}, (Interpolator i) =>
{
    transform.position = Vector3.up;
}, -1, false));
```

## Entities
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
- Required methods and objects are stored in the Core folder.  Both Interpolator and Easings require them.

## Credits
[Robert Penner's Easing Functions](http://robertpenner.com/easing/)\
[acron0's C# port of Robert Penner's Easing Functions](https://github.com/acron0/Easings)
