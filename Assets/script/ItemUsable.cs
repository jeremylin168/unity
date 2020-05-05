using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemUsable : Item
{
    public abstract void Use(Vector2 worldPos);
}
