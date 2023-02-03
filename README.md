# EaseKit
40 non-linear easing methods to make transitions nicer in Unity.

## Dependencies and Installation
**Dependencies**\
- Unity 2021.3 or greater

**Recommended Installation** (Unity Package Manager)
- "Add package from git URL..."
- `https://github.com/ryanslikesocool/Easings.git`

**Alternate Installation** (Not recommended)
- Get the latest [release](https://github.com/ryanslikesocool/EaseKit/releases)
- Open with the desired Unity project
- Import into the Plugins folder

## Usage

### Basic
```cs
using EaseKit;
// The entire EaseKit library is now available.
```
`// TODO`

### Advanced
`// TODO`

### With Other Packages
EaseKit has optional support for 2 other packages.
If [Unity.Mathematics](https://docs.unity3d.com/Packages/com.unity.mathematics@1.2/manual/index.html) (1.2.4) is included in the project, interpolators for types provided by the library are enabled.\
Supported `Unity.Mathematics` interpolator types include:
- All `float` vectors
- `double` and all `double` vectors
- `quaternion`

If [ClockKit](https://github.com/ryanslikesocool/ClockKit) (2.0.0 or later) is included in the project, convenience functions to start animations with easings and interpolators are enabled.

## Acknowledgements
[Robert Penner's Easing Functions](http://robertpenner.com/easing/)\
[acron0's C# port of Robert Penner's Easing Functions](https://github.com/acron0/Easings)
