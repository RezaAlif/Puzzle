using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    GameManager manager;
    float Speed;

	// Use this for initialization
	void Start () {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        Speed = manager.Speed * Time.deltaTime;
        transform.Translate(Vector3.back * Speed);
	}
}
