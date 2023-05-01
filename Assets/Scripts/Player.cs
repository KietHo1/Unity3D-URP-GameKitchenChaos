using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);
        if(Input.GetKeyDown(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            inputVector.x = +1;
        }
        inputVector = inputVector.normalized;
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        Debug.Log(Time.deltaTime);
    }
}