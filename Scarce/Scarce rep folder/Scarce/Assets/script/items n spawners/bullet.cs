using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int spd;
    public int dmg;

    private void Start()
    {
        StartCoroutine(DestroyBullet(1));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * spd);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent("destObj"))
        {
            destObj obj = other.GetComponent<destObj>();
            obj.health -= dmg;
        }

        spd = 0;
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(0).gameObject.SetActive(false);
        StartCoroutine(DestroyBullet(.25f));
    }

    IEnumerator DestroyBullet(float t)
    {
        yield return new WaitForSeconds(t);
        Destroy(this.gameObject);
    }
}
