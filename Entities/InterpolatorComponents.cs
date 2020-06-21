// Made with <3 by Ryan Boyer http://ryanjboyer.com

using System;
using Unity.Entities;

namespace ifelse.Easings.Entities
{
    #region Base

    [Serializable]
    public struct InterpolatorStartTime : IComponentData
    {
        public float Value;
    }

    [Serializable]
    public struct InterpolatorDuration : IComponentData
    {
        public float Value;
    }

    [Serializable]
    public struct InterpolatorLocalTime : IComponentData
    {
        public float Value;
    }

    [Serializable]
    public struct InterpolatorPercent : IComponentData
    {
        public float Value;
    }

    [Serializable]
    public struct InterpolatorValue : IComponentData
    {
        public float Value;
    }

    [Serializable]
    public struct InterpolatorDone : IComponentData
    {
        public bool Value;
    }

    #endregion

    #region Easing Types

    #region Linear

    [Serializable]
    public struct EaseLinear : IComponentData
    {
        public float Value;
    }

    #endregion

    #region Expo

    [Serializable]
    public struct EaseExpoIn : IComponentData { }

    [Serializable]
    public struct EaseExpoOut : IComponentData { }

    [Serializable]
    public struct EaseExpoInOut : IComponentData { }

    [Serializable]
    public struct EaseExpoOutIn : IComponentData { }

    #endregion

    #region Circ

    [Serializable]
    public struct EaseCircIn : IComponentData { }

    [Serializable]
    public struct EaseCircOut : IComponentData { }

    [Serializable]
    public struct EaseCircInOut : IComponentData { }

    [Serializable]
    public struct EaseCircOutIn : IComponentData { }

    #endregion

    #region Quad

    [Serializable]
    public struct EaseQuadIn : IComponentData { }

    [Serializable]
    public struct EaseQuadOut : IComponentData { }

    [Serializable]
    public struct EaseQuadInOut : IComponentData { }

    [Serializable]
    public struct EaseQuadOutIn : IComponentData { }

    #endregion

    #region Sine

    [Serializable]
    public struct EaseSineIn : IComponentData { }

    [Serializable]
    public struct EaseSineOut : IComponentData { }

    [Serializable]
    public struct EaseSineInOut : IComponentData { }

    [Serializable]
    public struct EaseSineOutIn : IComponentData { }

    #endregion

    #region Cubic

    [Serializable]
    public struct EaseCubicIn : IComponentData { }

    [Serializable]
    public struct EaseCubicOut : IComponentData { }

    [Serializable]
    public struct EaseCubicInOut : IComponentData { }

    [Serializable]
    public struct EaseCubicOutIn : IComponentData { }

    #endregion

    #region Quart

    [Serializable]
    public struct EaseQuartIn : IComponentData { }

    [Serializable]
    public struct EaseQuartOut : IComponentData { }

    [Serializable]
    public struct EaseQuartInOut : IComponentData { }

    [Serializable]
    public struct EaseQuartOutIn : IComponentData { }

    #endregion

    #region Quint

    [Serializable]
    public struct EaseQuintIn : IComponentData { }

    [Serializable]
    public struct EaseQuintOut : IComponentData { }

    [Serializable]
    public struct EaseQuintInOut : IComponentData { }

    [Serializable]
    public struct EaseQuintOutIn : IComponentData { }

    #endregion

    #region Elastic

    [Serializable]
    public struct EaseElasticIn : IComponentData { }

    [Serializable]
    public struct EaseElasticOut : IComponentData { }

    [Serializable]
    public struct EaseElasticInOut : IComponentData { }

    [Serializable]
    public struct EaseElasticOutIn : IComponentData { }

    #endregion

    #region Bounce

    [Serializable]
    public struct EaseBounceIn : IComponentData { }

    [Serializable]
    public struct EaseBounceOut : IComponentData { }

    [Serializable]
    public struct EaseBounceInOut : IComponentData { }

    [Serializable]
    public struct EaseBounceOutIn : IComponentData { }

    #endregion

    #region Back

    [Serializable]
    public struct EaseBackIn : IComponentData { }

    [Serializable]
    public struct EaseBackOut : IComponentData { }

    [Serializable]
    public struct EaseBackInOut : IComponentData { }

    [Serializable]
    public struct EaseBackOutIn : IComponentData { }

    #endregion

    #endregion
}