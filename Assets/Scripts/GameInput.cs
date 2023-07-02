using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    public event EventHandler OnInteractAction;
    public event EventHandler OnInteractAlternateAction;

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.Interact.performed += Interact_performed;
        playerInputActions.Player.InteractAlternate.performed += InteractAlternate_performed;
    }

    private void InteractAlternate_performed(InputAction.CallbackContext obj)
    {
        OnInteractAlternateAction?.Invoke(this, EventArgs.Empty);
    }

    private void Interact_performed(InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>(); //new Vector2(0, 0);
        //Use playerInputActions.Player.Move to replace this code
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    inputVector.y = +1;
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    inputVector.y = -1;
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    inputVector.x = -1;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    inputVector.x = +1;
        //}

        inputVector = inputVector.normalized;

        return inputVector;
    }
}
