using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointng : MonoBehaviour {
    Transform Position;
    public GameObject Point;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(Position != null)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Position.position.z);
        }
        else
        {
            Instantiate(Point, new Vector3(0, transform.position.y, transform.position.z), transform.rotation);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Point")
        {
            GameObject Bata = other.gameObject;
            Position = Bata.transform;
        }
    }
}
