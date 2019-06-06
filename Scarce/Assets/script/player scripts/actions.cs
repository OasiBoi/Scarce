using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actions : MonoBehaviour
{
    public plyrObj player;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(float x, float y, float z, int spd)
    {
        transform.Translate(x * spd * Time.deltaTime, 0, z * spd * Time.deltaTime);
        transform.Rotate(0, y, 0);
    }

    public void Jump(int j)
    {
        rb.AddForce(Vector3.up * j * 10);
        if (Input.GetButton("Jump"))
        {
            rb.AddForce(Vector3.up * j * 10);
        }
        rb.AddForce(Vector3.down * j / 200);
        if (Input.GetButtonUp("Jump"))
        {
            rb.AddForce(Vector3.down * j * 50);
        }
    }
}
