using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour {
    public GameObject Brick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 0.1f);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Brick")
        {
            GameObject Bata = other.gameObject;
            Vector3 Posisi = new Vector3(Bata.transform.position.x, Bata.transform.position.y, (Bata.transform.position.z - 0.463994f));
            Instantiate(Brick, Posisi, transform.rotation);
            Destroy(gameObject);
        }
    }
}
