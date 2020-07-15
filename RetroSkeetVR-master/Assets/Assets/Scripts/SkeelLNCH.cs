using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeelLNCH : MonoBehaviour {

    // Variable Declaration
    public GameObject Projectile = null;
    public GameObject ProjectileA = null;
    public Transform Launcher = null;
    public Vector3 vel; 
    public double ReloadTime = 1.0;
    bool Ready = true;
    double ReloadTimed;

    // Use this for initialization
    void Start()
    {
        ReloadTimed = 0.0;
    }

    // Update is called once per frame
    void Update()
    {

        CheckReload();

        if (Ready == true)
        {
            Ready = false;
            FireProjectile();
        }
        else
        {
            ReloadTimed += 0.1;
            //Debug.Log(ReloadTimed);
        }
    }

    void FireProjectile()
    {
        GameObject proj = GameObject.Instantiate(Projectile);
        proj.transform.position = Projectile.transform.position;
        proj.GetComponent<Rigidbody>().velocity = vel;
        proj.GetComponent<Rigidbody>().useGravity = true;    
        

    }

    void CheckReload()
    {
        if (ReloadTimed > ReloadTime)
        {
            ReloadTimed = 0;
            Ready = true;
        }
    }
}

