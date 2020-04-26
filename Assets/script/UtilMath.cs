using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilMath
{
    public static float Atan2(Vector2 v)
    {
        return Mathf.Atan2(v.y, v.x);
    }

    public static Vector2 Polar2Vector2(float length, float radians)
    {
        return new Vector2(Mathf.Cos(radians), Mathf.Sin(radians)) * length;
    }
}
