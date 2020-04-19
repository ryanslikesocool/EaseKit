# Unity-Easings
## About
41 easing methods based on acron0's C# port of Robert Penner's Easing Functions with three flavors (Core, Interpolator, Entities).  Core and Interpolator are meant to be called over time, such as in a coroutine or in the Update loop.  Entities are updated automatically with an optional custom delta time.

## Core
Core provides extensions for each of the different easing methods, each with return types of `float`, `Vector2`, `Vector3`,  `Vector4`, and `Quaternion`.

### Usage
All easing functions are called with four parameters: `t` (time), `b` (initial value), `c` (delta value), and `d` (duration).
If `time == 0`, then the result of the method is `b`, the initial value.  If `time == duration`, then the result of the method is `b + c`, the initial value plus the delta value.

```csharp
IEnumerator LinearEase()
{
    float time = 0;
    float initial = 0;
    float delta = 1;
    float duration = 1;

    while (time < duration)
    {
        // Update the time.  This is necessary to get out of the loop
        time += Time.deltaTime;
        
        // Get the current interpolator value
        float value = Easings.Linear(time, initial, delta, duration);
        
        // Do something with the value, such as:
        transform.position = Vector3.Lerp(Vector3.zero, Vector3.up, value);

        yield return null;
    }
    
    // Finalizing the interpolation is only necessary if the duration is 0
    transform.position = Vector3.up;
}
```

## Interpolator
Interpolator stores easing data in a class, meant for reuse.  Interpolator provides all easing methods with the return type of `float`, meant for use with the default interpolation methods that Unity provides (`Vector3.Lerp()`, `Color.Lerp()`, etc.).  Interpolator works similarly to Unity's default interpolation method, taking a start value and end value.

### Usage
Create an Interpolator with an easing type, input the start value, end value, and duration in `Begin()`.  The call its `Update()` method over time.

```csharp
IEnumerator LinearEase()
{
    // Create the Interpolator
    // This comes with an overload for choosing the easing function.
    // The default function is Linear
    Interpolator interpolator = new Interpolator();
    // Start value = 0
    // End value = 1
    // Duration = 1
    interpolator.Begin(0, 1, 1);

    while (!interpolator.Done)
    {
        // Update the time.  This is necessary to get out of the loop
        // This comes with an overload if you want to use a custom deltaTime
        interpolator.Update();

        float value = interpolator.Value;

        // Do something with the value, such as:
        transform.position = Vector3.Lerp(Vector3.zero, Vector3.up, value);
        
        yield return null;
    }
    
    // Finalizing the interpolation is only necessary if the duration is 0
    transform.position = Vector3.up;
}
```

## Entities
The Entities flavor is meant for use with Unity's Data Oriented Tech Stack (DOTS).  The Entities flavor does not require a manual update.  Instead, you can add the `Interpolator` component to an entity.  An `InterpolatorAuthoring` MonoBehaviour is included for quick testing.  The Entities flavor is meant for use with other systems, as the included `InterpolationSystem` is only used for updating the `Interpolator` component.

### Usage
Add an `Interpolator` component to an entity.  There are three ways to create the struct required.  The main overload takes the initial value, the target value, and the duration, with an optional boolean to trigger component removal when the interpolation is complete.  Other overloads include easing function specification and custom delta time, instead of using the default.  By default, the `Interpolator` component will be removed when the easing is completed.

```csharp
[BurstCompile]
struct MoveWithInterpolatorJob : IJobForEach<Translation, Interpolator>
{        
    public void Execute(ref Translation translation, ref Interpolator interpolator)
    {
        // This changes the entity's X position based on the interpolator value
        float3 position = translation.Value;
        position.x = interpolator.Value;
        translation.Value = position;

        // This bit replaces the completed Interpolator with a new one to ping-pong the easing
        // It only works if the original Interpolator's RemoveOnDone boolean is set to false
        if(interpolator.Done)
        {
            interpolator = new Interpolator(interpolator.Target, interpolator.Initial, interpolator.Duration, interpolator.Function, interpolator.RemoveOnDone);
        }
    }
}
```

## Notes
- Unused flavors can be removed.  For example, if your project is not DOTS based, the Entities folder can be deleted.  If you only plan on using the Interpolator flavor, Core and Entites can be deleted.
- The core methods that are required are stored in the root folder.  Flavors will not work without them.

## Dependencies
- Core - Root folder scripts
- Interpolator - Root folder scripts
- Entities - Root folder scripts, DOTS packages (found in the Unity Package Manager)

## Credits
Robert Penner's Easing Functions
http://robertpenner.com/easing/

acron0's C# port
https://github.com/acron0/Easings
