using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destObj : MonoBehaviour
{
    public int health = 5;

    public GameObject xp;
    public GameObject [] coin = new GameObject [3];
    public int dropNum;

    public Vector3[] pos = new Vector3[4];

    private void Update()
    {
        if (health <= 0)
        {
            SelectCoin(dropNum);
            Destroy(this.gameObject);
        }
    }
    private void SelectCoin(int i)
    {
        while (i > 0){
            int n = Random.Range(1, 10);
            int p = Random.Range(0, 3);


            if (n == 1)
            {
                Instantiate(coin[0], transform.position + pos[p], coin[0].transform.rotation);
            }
            else if (n > 1 && n <= 5)
            {
                Instantiate(coin[1], transform.position + pos[p], coin[1].transform.rotation);
            }
            else
            {
                Instantiate(coin[2], transform.position + pos[p], coin[2].transform.rotation);
            }
            Instantiate(xp, transform.position + pos[p], transform.rotation);
            i--;
        }
    }
}
