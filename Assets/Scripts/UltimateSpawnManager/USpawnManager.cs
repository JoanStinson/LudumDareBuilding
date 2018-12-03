using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USpawnManager : MonoBehaviour {
    public GameObject []builds;
    public GameObject [] spawns;
    private int randVelocity;
    private int randomTypeBuild;

	// Use this for initialization
	void Start () {
        NewSpawn();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateBuild(int idSpawner)
    {
        randomTypeBuild = Random.Range(0, 4);
        randVelocity = Random.Range(1, 3);
        GameObject build = Instantiate(builds[randomTypeBuild], spawns[idSpawner].transform);
        build.GetComponent<Rigidbody2D>().velocity = new Vector2(0, randVelocity);
        build.GetComponent<BuildConf>().idSpawner = idSpawner;
    }

    public void NewSpawn() {
        for (int i = 0; i < spawns.Length; i++) {
            randomTypeBuild = Random.Range(0, 4);
            randVelocity = Random.Range(1, 3);

            GameObject build = Instantiate(builds[randomTypeBuild], spawns[i].transform);
            build.GetComponent<Rigidbody2D>().velocity = new Vector2(0, randVelocity);

            build.GetComponent<BuildConf>().idSpawner = i;
        }
    }
}
