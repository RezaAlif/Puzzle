using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructParticle : MonoBehaviour {
    float Timing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
        if(Timing >= 2)
        {

        }
	}
}
