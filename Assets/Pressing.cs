using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressing : MonoBehaviour {
    public GameObject Planting;
    public Transform Posisi;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Instantiate(Planting, Posisi.position, Posisi.rotation);
    }
}
