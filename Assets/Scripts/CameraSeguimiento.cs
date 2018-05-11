using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguimiento : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        Vector3 posicionPlayer = GameObject.FindGameObjectWithTag("Player").transform.position;

        this.transform.position = new Vector3(posicionPlayer.x, posicionPlayer.y, this.transform.position.z);
	}
}
