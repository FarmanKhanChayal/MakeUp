using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public struct ToolObject
{
    public ToolType toolType;
    public List<Sprite> thumbSprites;
    public List<Sprite> useSprites;
    public Transform useTransform;
}