using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour {	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(2, 0, 0) * Time.deltaTime);
	}
}
