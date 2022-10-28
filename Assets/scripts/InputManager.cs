using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    private Playerinput playerInput;
    private Playerinput.OnFootActions onFoot;

    private PlayerMoter motor;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new Playerinput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMoter>();
        onFoot.Jump.performed += ctx => motor.Jump();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //tell the playermoter to  move using the value form our movement action
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void OnDisable()
    {
        onFoot.Disable();
    }
}
