using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    public bool left; // Left is true, Box in unity ticked

    public delegate void ButtonPressed();
    public static event ButtonPressed OnLeft;
    public static event ButtonPressed OnRight;

    // public FiremanController fireman; // Reference to communicate on firemancontroller.

    private void OnMouseDown()
    {
        if (OnLeft != null && left) // checks if we have at least one prenumeration on our event
        {
            OnLeft();
            //fireman.OnLeftPressed();
            //Debug.Log("Touch Left!");
        } else if (OnRight != null) // checks if we have at least one prenumeration on our event
        {
            OnRight();
            //fireman.OnRightPressed();
            //Debug.Log("Touch Right!");
        }
    }
}
