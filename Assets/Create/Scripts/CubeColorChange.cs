using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChange : MonoBehaviour
{

    [SerializeField]
    Material[] materialArray = new Material[3];
    int count;
    void Start()
    {
        count = 0;
    }

    void Update()
    {

    }

    public void ChangeColor()
    {
        count++;
        if (count > 2)
        {
            count = 0;
        }
        GetComponent<MeshRenderer>().material = materialArray[count];
    }
}
