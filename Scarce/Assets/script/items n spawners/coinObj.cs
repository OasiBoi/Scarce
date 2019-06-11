using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinObj : MonoBehaviour
{
    public int worth;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent("hitCollider"))
        {
            Destroy(this.gameObject);
        }

    }
}
