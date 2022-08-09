using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public int Speed = 0;
    Vector3 DirectionPlayer;
    public float RotationX = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotationCamera();
        DirectionPlayer = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            DirectionPlayer += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            DirectionPlayer += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A))
        {
            DirectionPlayer += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            DirectionPlayer += Vector3.right;
        }

        Movement(DirectionPlayer);
    }

    void Movement(Vector3 Direction)
    {
        transform.Translate(Direction * Speed * Time.deltaTime);
    }

    void RotationCamera()
    {
        RotationX += Input.GetAxis("Mouse X");
        Quaternion NewRotation = Quaternion.Euler(0, RotationX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, NewRotation, 6f * Time.deltaTime);
    }
}
