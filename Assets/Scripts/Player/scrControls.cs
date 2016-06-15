using UnityEngine;
using System.Collections;

public static class scrControls
{
    public static float vertical()
    {
        return Input.GetAxis("Vertical");
    }

    public static float horizontal()
    {
        return Input.GetAxis("Horizontal");
    }

    public static bool jumpDown()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    public static bool use()
    {
        return Input.GetKeyDown(KeyCode.E);
    }
}
