using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour {

    public float speed;
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(speed,speed*2,speed*3)*Time.deltaTime);
	}
}
