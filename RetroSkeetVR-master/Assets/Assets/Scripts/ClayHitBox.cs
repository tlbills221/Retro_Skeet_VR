using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClayHitBox : MonoBehaviour {
    public GameObject ClayPidg;
    public GameObject Shrapnel;
    private AudioSource OnHit;
    public AudioClip SFXConfirm;
    int pieceNum = 0;
    // Use this for initialization
    void Start () {
        OnHit = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if(transform.position.y < 0){
            Destroy(gameObject);
        }
	}
    void OnTriggerExit(Collider s)
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);


        //Score variable goes up by x
        if (other.name == "GunHitBox")
        {
            Debug.Log("Enter GHB1");
            other.transform.parent.parent.parent.GetComponent<Shoot>().addPoints(4);
            //Play hit sound effect and animation
            other.transform.parent.parent.parent.parent.GetComponent<AudioSource>().PlayOneShot(SFXConfirm);
            //Spawn shrapnel pieces
            pieceNum = Random.Range(2, 7);
            for (int i = 0; i < pieceNum; i++) {
                GameObject a = GameObject.Instantiate(Shrapnel);
                a.transform.position = transform.position;
            }
            Destroy(gameObject);
        }

    }

    void OnTriggerStay(Collider other)
    {

    }
}
