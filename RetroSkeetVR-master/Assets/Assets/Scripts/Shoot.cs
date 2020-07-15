using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

    private int Score = 0;
    public MeshCollider hitBox;
    public AudioClip SFXClayHit;
    public AudioClip SFXReload;
    public Text SC;
    public AudioSource GunTest;

    //Ammo
    private int Ammo = 2;
    private int RLMax = 2;
    private float RL = 2;

    public void addPoints(int i)
    {
        Score += i;
        SC.text = "Score " + Score.ToString();
    }

	// Use this for initialization
	void Start () {
        //GunTest = GetComponent<AudioSource>();
        SC.text = "Score " + Score.ToString();
    }
	
	// Update is called once per frame
	void Update () {

        if (hitBox.enabled == true)
        {
            hitBox.enabled = false;
        }
        if (RL == 2.0f)
        {
            GunTest.PlayOneShot(SFXReload);
        }
        if (RL > 0)
        {
            RL -= Time.deltaTime;
        }
        else if(Input.GetButtonDown("Fire1"))
        {
            if (Ammo == 2)
            {
                --Ammo;
            }
            else if (Ammo == 0)
            {
                Ammo = 1;
            }
            else
            {
                Ammo = 0;
                RL = RLMax;
            }
            hitBox.enabled = true;
            GunTest.Play();
        }

	}
}
