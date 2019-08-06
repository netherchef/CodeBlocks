using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region Direction __________________________________________________________

    public static bool Pressing_Left ()
    {
        return Input.GetAxisRaw ("Horizontal") < 0;
    }

    public static bool Pressing_Right ()
    {
        return Input.GetAxisRaw ("Horizontal") > 0;
    }

    public static bool Going_LeftRight ()
    {
        return Pressing_Left () || Pressing_Right ();
    }

    public static float Amount_X ()
    {
        return Input.GetAxisRaw ("Horizontal");
    }

    public static float Amount_Y ()
    {
        return Input.GetAxisRaw ("Vertical");
    }

    #endregion

    #region Button _____________________________________________________________

    public static bool Holding_Submit ()
    {
        return Input.GetButton ("Submit");
    }

    public static bool Tap_Jump ()
    {
        return Input.GetButtonDown ("Jump");
    }

    #endregion
}
