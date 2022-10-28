using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;
  
    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mosueY = input.y;
    }
}
