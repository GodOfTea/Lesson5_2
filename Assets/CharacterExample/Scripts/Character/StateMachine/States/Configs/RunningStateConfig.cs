using System;
using UnityEngine;

[Serializable]
public class RunningStateConfig
{
    [SerializeField, Range(0, 10)] private float _speed;
    [SerializeField] private float _walkingModifier;
    [SerializeField] private float _fastRunModifier;

    public float Speed => _speed;
    public float WalkingSpeed => _speed * _walkingModifier;
    public float FastRunSpeed => _speed * _fastRunModifier;
}
