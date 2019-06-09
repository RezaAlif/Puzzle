using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public float Speed;
    public GameObject Finish;
	public float maxTimeSpawn;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        Speed = 0.3f;
		maxTimeSpawn = 1.3f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Brick")
        {
            Speed = 0;
            Time.timeScale = 0;
            Finish.SetActive(true);
        }
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
