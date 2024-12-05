using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public float RotateSpeed;

    void Start()
    {
        RotateSpeed = 20f;
    }


    void Update()
    {
        transform.Rotate(0, RotateSpeed * Time.deltaTime, 0);
    }

    public void RotateDirectionChange()
    {
        RotateSpeed *= -1;
    }


}
