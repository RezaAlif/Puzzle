using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDetector : MonoBehaviour {
	GameManager manager;
    int Count;
    public GameObject Player;
    public GameObject[] Brick;
    public Plant bata;
    public GameObject Stone;
    public GameObject Particle;

    // Use this for initialization
    void Start () {
		manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Count >= 4)
        {
            Destroy(Player);
            Destroying();
        }
        else
        {
            Spawn();
        }
    }

    void Spawn()
    {
        if (Brick[0] != null && transform.position.z >= Brick[0].transform.position.z)
        {
            Vector3 Posisi = new Vector3(Player.transform.position.x, Player.transform.position.y, (Brick[0].transform.position.z));
            Instantiate(Stone, Posisi, transform.rotation);
            Destroy(Player);
        }
    }

    void Destroying()
    {
        for(int i = 0; i < 4; i++)
        {
            Destroy(Brick[i]);
            Instantiate(Particle, transform.position, transform.rotation);
			manager.Speed += 0.01f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Brick")
        {
            GameObject Batu = other.gameObject;
            Brick[Count] = Batu;
            Count++;
        }
    }
}
