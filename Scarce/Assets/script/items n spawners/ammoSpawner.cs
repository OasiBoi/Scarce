using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoSpawner : MonoBehaviour
{
    public GameObject ammo;
    public int time;

    private void Start()
    {
        Instantiate(ammo, transform);
    }

    public void StartSpawn()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(time);
        Instantiate(ammo, transform);
    }
}
