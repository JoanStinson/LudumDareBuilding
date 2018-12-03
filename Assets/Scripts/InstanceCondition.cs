using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceCondition : MonoBehaviour {
    public GameObject spawnPoints;
    private USpawnManager spawnManager;
	// Use this for initialization
	void Start () {
        spawnManager = spawnPoints.GetComponent<USpawnManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("instance"))
        {
            spawnManager.GenerateBuild(other.GetComponent<BuildConf>().idSpawner);
        }
        //GameManager.instance.GameOver();
    }
}
