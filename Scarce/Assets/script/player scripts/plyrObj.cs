using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plyrObj : MonoBehaviour
{
    public GameObject plyrbod;
    
    public camObj camObj;
    public cam cam;
    public actions player;
    public bool jumpOk;
    //public plyrData data;

    public string ID;
    public int xp;
    public float hlth;
    public float stmn;
    public Vector2 subfac = new Vector2();

    public int moveSpd;
    public int jumpStr;
    public int ammo;
    public int money;
    public int shield;

    public float mx;
    public float my;
    public float rx;
    public float ry;

    private void Start()
    {
        saveSystem.LoadData();
    }

    void Update()
    {

        cam = GetComponentInChildren<cam>();
        camObj = GetComponentInChildren<camObj>();
        player = GetComponentInChildren<actions>();

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        float RotX = Input.GetAxis("Mouse X");
        float RotY = Input.GetAxis("Mouse Y");

        mx = Mathf.Clamp(moveX, -1, 1);
        my = Mathf.Clamp(moveY, -1, 1);
        rx = Mathf.Clamp(RotX, -1, 1);
        ry = Mathf.Clamp(RotY, -1, 1);
        //move player
        player.Move(mx * 10, rx * 3, my * 10, moveSpd);

        //subtract stamina, then health when moving
        if (mx != 0 || my != 0)
        {
            if (stmn > 0)
            {
                stmn -= subfac.x;
            }
            else { hlth -= subfac.y; }
        }

        //move camera
        if(ry > 0.3 || ry < -0.3)
        {
            camObj.CamRot(ry * 3, moveSpd);
        }
        if (rx > 0.3 || rx < -0.3)
        {
            player.Move(0, rx * 3, 0, moveSpd);
        }

        //jump
        if (Input.GetButtonDown("Jump"))
        {
            if (jumpOk)
            {
                player.Jump(jumpStr);
                jumpOk = false;
            }
        }

        //shoot
        if (Input.GetButtonDown("Fire2"))
        {
            if (ammo > 0)
            {
                cam.Shoot();
                ammo--;
            }
        }
    }

    public void DestroyChild()
    {
        Destroy(transform.GetChild(0).gameObject);
    }

    public void CollectCoin(int c)
    {
        money += c;
    }
    public void CollectAmmo(int a)
    {
        ammo += a;
    }
    public void CollectHealth(int h)
    {
        hlth += h;
    }
    public void CollectXp(int p)
    {
        xp += p;
    }
    public void CollectStmn(int p)
    {
        stmn += p;
    }
}
