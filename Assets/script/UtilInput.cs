using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilInput
{
    public static Vector2 GetCursorWorldPos()
    {
        return GetCursorRelativePos() + (Vector2)Camera.main.transform.position;
    }

    public static Vector2 GetCursorRelativePos()
    {
        return new Vector2(Input.mousePosition.x - Screen.width / 2,
                           Input.mousePosition.y - Screen.height / 2) / Screen.height * Camera.main.orthographicSize * 2;
    }
}
