using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_View : MonoBehaviour {

    public Camera StationOne;
    public Camera StationTwo;
    public Camera StationThree;
    public Camera StationFour;
    public Camera StationFive;
    public Camera StationSix;
    public Camera StationSeven;
    public Camera StationEight;
    public Camera current;
    public GameObject gun;
    private Vector3 oldlol; 

    public void ShowStationOne() {
        current = StationOne;
        StationOne.transform.gameObject.SetActive(true);
        StationEight.transform.gameObject.SetActive(false);
    }
    public void ShowStationTwo()
    {
        current = StationTwo;
        StationTwo.transform.gameObject.SetActive(true);
        StationOne.transform.gameObject.SetActive(false);
    }
    public void ShowStationThree()
    {
        current = StationThree;
        StationThree.transform.gameObject.SetActive(true);
        StationTwo.transform.gameObject.SetActive(false);
    }
    public void ShowStationFour()
    {
        current = StationFour;
        StationFour.transform.gameObject.SetActive(true);
        StationThree.transform.gameObject.SetActive(false);
    }
    public void ShowStationFive()
    {
        current = StationFive;
        StationFive.transform.gameObject.SetActive(true);
        StationFour.transform.gameObject.SetActive(false);
    }
    public void ShowStationSix()
    {
        current = StationSix;
        StationSix.transform.gameObject.SetActive(true);
        StationFive.transform.gameObject.SetActive(false);
    }
    public void ShowStationSeven()
    {
        current = StationSeven;
        StationSeven.transform.gameObject.SetActive(true);
        StationSix.transform.gameObject.SetActive(false);
    }
    public void ShowStationEight()
    {
        current = StationEight;
        StationEight.transform.gameObject.SetActive(true);
        StationSeven.transform.gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start () {

        current = StationFour;
        StationOne.transform.gameObject.SetActive(false);
        StationTwo.transform.gameObject.SetActive(false);
        StationThree.transform.gameObject.SetActive(false);
        StationFour.transform.gameObject.SetActive(true);
        StationFive.transform.gameObject.SetActive(false);
        StationSix.transform.gameObject.SetActive(false); 
        StationSeven.transform.gameObject.SetActive(false);
        StationEight.transform.gameObject.SetActive(false);
        oldlol = gun.transform.localScale;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire2"))
        {
            camMove();
        }
    }

   public void camMove()
    {
        switch (current.name)
        {
            case "StationOne":
                ShowStationTwo();
                break;
            case "StationTwo":
                ShowStationThree();
                break;
            case "StationThree":
                ShowStationFour();
                break;
            case "StationFour":

                ShowStationFive();
                break;
            case "StationFive":
                ShowStationSix();
                break;
            case "StationSix":
                ShowStationSeven();
                break;
            case "StationSeven":
                ShowStationEight();
                break;
            case "StationEight":
                ShowStationOne();
                break;
            default:
                Debug.Log("Camera Error. No Camera Active.");
                break;
        }
        gun.transform.parent = current.transform;
        gun.transform.localPosition = Vector3.zero;
        gun.transform.localRotation = Quaternion.identity;
        gun.transform.localScale = oldlol;
    }
}
