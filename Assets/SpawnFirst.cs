using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFirst : MonoBehaviour {
    public GameObject[] Brick;

    // Use this for initialization
    void Start () {
        Instantiate(Brick[Random.Range(0, 8)], transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
