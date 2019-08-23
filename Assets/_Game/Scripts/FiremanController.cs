using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiremanController : MonoBehaviour
{

    public List<Transform> positions = new List<Transform>(); // List of 3 positions, red dots on Unity

    private int currentPosition = 1;

    private void OnEnable() // Starts before START
    {
        ButtonInput.OnLeft += OnLeftPressed;  // Adds our left method to buttoninput.
        ButtonInput.OnRight += OnRightPressed; // Adds our right method to buttoninput.
    }

    private void OnDisable() // Disables right now our method if the objects gets killed.
    {
        ButtonInput.OnLeft -= OnLeftPressed;
        ButtonInput.OnRight -= OnRightPressed;
    }

    private void Start()
    {
        UpdatePosition(); // Move fireman to the middle position.
    }


    public void OnLeftPressed()
    {
        //Debug.Log("Move Left!");

        if (currentPosition > 0)
        {
            currentPosition--;

            UpdatePosition();
        }
        
    }


    public void OnRightPressed()
    {
        //Debug.Log("Move Right!");
        if (currentPosition < positions.Count -1)
        {
            currentPosition++;
            UpdatePosition();
        }
        
    }


    private void UpdatePosition()
    {
        transform.position = positions[currentPosition].position;
    }
}
