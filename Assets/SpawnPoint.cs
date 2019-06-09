using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
	GameManager manager;
    int Unit;
    public GameObject[] Brick;
    float Timing;

	// Use this for initialization
	void Start () {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
        if (Timing > manager.maxTimeSpawn)
        {
            Instantiate(Brick[Random.Range(0,8)], transform.position, transform.rotation);
            Timing = 0;
        }
	}
}
