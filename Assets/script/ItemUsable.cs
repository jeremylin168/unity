using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemUsable : Item
{
    public float useTime = 1f;
    public float useCD = 0f;
    public abstract void Use(Vector2 worldPos);
}
