using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBox : MonoBehaviour
{
    float xSpeed = 0.0f;
    float ySpeed = 0.0f;
    float zSpeed = 0.0f;
    float rotateSpeed = 10f;
    public bool Rotate = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDrag()
    {
        float xSpeed = Input.GetAxis("Mouse X") * rotateSpeed;
        float ySpeed = Input.GetAxis("Mouse Y") * rotateSpeed;

        transform.Rotate(Vector3.down, xSpeed);
        transform.Rotate(Vector3.right, ySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Rotate)
        {
            ySpeed = 50;
        }
        else
        {
            ySpeed = 0;
        }
        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);
    }

    public void ChangeBool()
    {
        Rotate = !Rotate;
    }
}
