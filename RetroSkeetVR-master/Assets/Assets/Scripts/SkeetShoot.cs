using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeetShoot : MonoBehaviour {

    public GameObject highProjectile = null;
    public GameObject lowProjectile = null;
    public GameObject highLauncher = null;
    public GameObject lowLauncher = null;

    public GameObject Camera = null;

    public Vector3 highVelocity;
    public Vector3 lowVelocity;

    private int round = 0;
    private int step = 0; // 0 = high 1 = low 2 = both

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Shoot"))
        {
            switch (step)
            {
                case 0: FireHighProjectile(); break;
                case 1: FireLowProjectile(); break;
                case 2: FireHighProjectile(); FireLowProjectile(); break;
                default: if (round < 9) { ++round; MoveCamera(); step = -1;} break;
            }
            ++step;
        }

	}

    void FireHighProjectile()
    {
        GameObject proj = GameObject.Instantiate(highProjectile);
        proj.transform.position = highProjectile.transform.position;
        proj.GetComponent<Rigidbody>().velocity = highVelocity;
        proj.GetComponent<Rigidbody>().useGravity = true;
    }

    void FireLowProjectile()
    {
        GameObject proj = GameObject.Instantiate(lowProjectile);
        proj.transform.position = lowProjectile.transform.position;
        proj.GetComponent<Rigidbody>().velocity = lowVelocity;
        proj.GetComponent<Rigidbody>().useGravity = true;
    }

    void MoveCamera()
    {
        Camera.GetComponent<Camera_View_Skee>().camMove();
    }
}
