using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private void OnEnable() // Adds a Prenemuration on out method
    {
        ButtonInput.OnLeft += ButtonInput_OnLeft;
        ButtonInput.OnRight += ButtonInput_OnRight;

    }

    private void OnDisable()
    {
        ButtonInput.OnLeft -= ButtonInput_OnLeft;
        ButtonInput.OnRight -= ButtonInput_OnRight;
    }

    private void ButtonInput_OnLeft()
    {
        Debug.Log("PIP-LEFT");
    }

    private void ButtonInput_OnRight()
    {
        Debug.Log("PIP-RIGHT");
    }
}
