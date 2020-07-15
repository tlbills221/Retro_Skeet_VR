using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrapnelAI : MonoBehaviour {

    public GameObject Shrapnel;
    public GameObject ClayPidg;

    // Use this for initialization
    void Start () {
         //Generate random vector to determine start position relative to ClayPidg
        float xDir = Random.Range(-1, 1);
        float yDir = Random.Range(-1, 1);
        float zDir = Random.Range(-1, 1);
        transform.position += new Vector3(xDir, yDir, zDir);
        float xFall = Random.Range(-30, 30);
        float yFall = Random.Range(-30, 30);
        float zFall = Random.Range(-30, 30);
        Vector3 velocity = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
        GetComponent<Rigidbody>().velocity = velocity;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(-100, 100, 100) * Time.deltaTime);
    }


}
