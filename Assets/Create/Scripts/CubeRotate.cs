using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    float RotateSpeed;

    void Start()
    {
        RotateSpeed = 0.1f;
    }


    void Update()
    {
        transform.Rotate(0, RotateSpeed, 0);
    }

    public void RotateDirectionChange()
    {
        RotateSpeed *= -1;
    }


}
