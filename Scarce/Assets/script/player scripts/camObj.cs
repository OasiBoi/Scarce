using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camObj : MonoBehaviour
{
    public float rot;
    public float xAxisClamp;
    public Vector2 limits;


    private void Start()
    {
        xAxisClamp = 0;
    }

    public void CamRot(float r, int spd)
    {
        rot = r;
        xAxisClamp += r;

        if (xAxisClamp > limits.x)
        {
            xAxisClamp = limits.x;
            r = 0;
        }
        if (xAxisClamp < limits.y)
        {
            xAxisClamp = limits.y ;
            r = 0;
        }

        transform.Rotate(r * spd, 0, 0);
    }
}
