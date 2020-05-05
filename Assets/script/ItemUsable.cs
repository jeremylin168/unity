using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemUsable : Item
{
    public float useSpeed = 1f;
    public float cooldown = 0f;
    public abstract void Use(Vector2 worldPos);
}
