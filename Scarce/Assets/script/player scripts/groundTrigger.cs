using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundTrigger : MonoBehaviour
{
    public plyrObj player;
    private void OnTriggerEnter(Collider other)
    {
        player = GetComponentInParent<plyrObj>(); 

        player.jumpOk = true;
    }
}
