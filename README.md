# Unity-Easings
## About
41 easing methods based on acron0's C# port of Robert Penner's Easing Functions with two flavors (Core, Interpolator).  Both flavors are meant to be called over time, such as in a coroutine (recommended) or in the Update loop.

## Core
The classic flavor of Unity Easings.  It provides all easing methods, each with return types of `float` (recommended), `Vector2`, `Vector3`, and `Vector4`.

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
}
```

## Interpolator
New, improved, and more user-friendly than Core!  It provides all easing methods with the return type of `float`, meant for use with the default interpolation methods that Unity provides (`Vector3.Lerp()`, `Color.Lerp()`, etc.).  The Interpolator flavor works similarly to Unity's default interpolation method, taking a start value and end value, unlike Core, which requires a start value and delta value.

### Usage
Create an Interpolator with an easing type, input the start value, end value, and duration in `Begin()`.  The call its `Update()` method over time.

```csharp
IEnumerator LinearEase()
{
    Interpolator interpolator = new Interpolator(EasingType.Linear);
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
}
```

## Credits
Robert Penner's Easing Functions
http://robertpenner.com/easing/

acron0's C# port
https://github.com/acron0/Easings
