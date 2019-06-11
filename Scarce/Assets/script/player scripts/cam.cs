using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawner;

    public void Shoot()
    {
        Instantiate(bullet, spawner.transform.position, transform.parent.rotation);
    }
}
