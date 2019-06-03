using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camObj : MonoBehaviour
{
    public float rot;
    public bool rotOk;
    public Vector2 Limits;
    private void Update()
    {

        rot = Mathf.Clamp(transform.rotation.x, -1, 1);
        if (rot >= Limits.x || rot <= Limits.y)
        {
            rotOk = false;
        }
        else
        {
            rotOk = true;
        }

        if (!rotOk)
        {
            if (rot >= Limits.x)
            {
                CamRot(Limits.x - 1, 10);
            }
            if (rot <= Limits.y)
            {
                CamRot(Limits.y + 1, 10);
            }
        }
    }

    public void CamRot(float r, int spd)
    {
        transform.Rotate(r * spd, 0, 0);
    }
}
