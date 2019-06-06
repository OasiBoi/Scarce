using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xpObj : MonoBehaviour
{

    public int points;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent("hitCollider"))
        {
            Destroy(this.gameObject);
        }

    }


}
