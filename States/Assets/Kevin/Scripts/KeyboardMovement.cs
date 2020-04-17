using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveForward();
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveLeft();
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveBackward();
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveRight();
        }
    }

    void moveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void moveBackward()
    {
        transform.Translate(Vector3.forward * -speed * Time.deltaTime);
    }
    void moveLeft()
    {
        transform.Translate(Vector3.right * -speed * Time.deltaTime);
    }
    void moveRight()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
