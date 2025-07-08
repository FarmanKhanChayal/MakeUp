using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public struct CarObject
{
    public CarToolType CarToolType;
    public List<Sprite> useSprites;
    public Transform useTransform;
}