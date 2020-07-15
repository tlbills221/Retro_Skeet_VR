using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunHitbox : MonoBehaviour
{
    public GameObject Shrapnel;
    public AudioClip SFXClayHit;
    private AudioSource HitSound;
    int pieceNum = 0;

    /*void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);

        Debug.Log("Shap-GHB ");

        //Score variable goes up by x
        if (other.name == "ClayPidg")
        {
            transform.parent.parent.parent.GetComponent<Shoot>().addPoints(4);
            //Play hit sound effect and animation
            HitSound.PlayOneShot(SFXClayHit, 0.7F);

            //Spawn shrapnel pieces
            pieceNum = Random.Range(1, 6);
            for (int i = 0; i < pieceNum; i++)
            {
                GameObject a = Instantiate(Shrapnel);
                a.transform.position = other.transform.position;
            }
            Destroy(other);

        }
        */

    
}
