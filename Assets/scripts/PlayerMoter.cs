using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoter : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponet<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //receive the inputs for our InputManager.cs and apply them to our character controller.
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(Transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
    }
}
