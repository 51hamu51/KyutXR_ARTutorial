using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletForce = 0.05f;
    public Rigidbody rb;
    void Start()
    {
        Destroy(this.gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, bulletForce, ForceMode.Impulse);
    }
}
