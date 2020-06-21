# Unity-Easings
## About
41 easing methods based on acron0's C# port of Robert Penner's Easing Functions with three flavors (Core, Interpolator, Entities).  Core and Interpolator are meant to be called over time, such as in a coroutine or in the Update loop.  Entities are updated automatically.

## Core
Core provides extensions for each of the different easing methods, each with return types of `float`, `Vector2`, `Vector3`,  `Vector4`, and `Quaternion`.

### Namespaces
`ifelse.Easings.Core`

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

### Namespaces
`ifelse.Easings.Interpolator`

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
The Entities flavor is meant for use with Unity's Data Oriented Tech Stack (DOTS).  The Entities flavor does not require a manual update.  Instead, you can add the `Interpolator` component to an entity.  An `InterpolatorAuthoring` MonoBehaviour is included for quick testing.  The Entities flavor is meant for use with other systems, as the included `InterpolationSystems.cs` is only used for updating interpolator components.

### Namespaces
`ifelse.Easings.Entities`

### Usage
Take a peek inside `InterpolatorAuthoring.cs` to see the required setup for entity interpolation.  The core components required for interpolation are as follows
- `InterpolatorStartTime`
- `InterpolatorDuration`
- `InterpolatorLocalTime`
- `InterpolatorPercent`
- `InterpolatorValue`
- `InterpolatorDone`
- one of the many `Ease` structs, found in `InterpolatorComponents.cs`

```csharp
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
- Unused flavors can be removed.  For example, if your project is not DOTS based, the Entities folder can be deleted.  If you only plan on using the Interpolator flavor, Core and Entites can be deleted.
- The core methods that are required are stored in the Root folder.  Core and Interpolator flavors will not work without them.

## Dependencies
- Core - Root folder scripts
- Interpolator - Root folder scripts
- Entities - DOTS packages (found in the Unity Package Manager)

## Credits
Robert Penner's Easing Functions
http://robertpenner.com/easing/

acron0's C# port
https://github.com/acron0/Easings
