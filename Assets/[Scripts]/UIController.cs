using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class UIController : MonoBehaviour
{
    public static bool jumpButton;

   public void OnJumpButtonDown()
    {
        jumpButton = true;
    }
    public void OnJumpButtonUp()
    {
        jumpButton = false;
    }
}
