using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USpawnManager : MonoBehaviour {
    public GameObject []builds;
    public GameObject [] spawns;
    private int randVelocity;
    private int randomTypeBuild;
    public int minVelocity0;
    public int maxVelocity0;
    public int minVelocity1;
    public int maxVelocity1;
    public GameObject gmManagerNew;
    private GameManagerNew gmManagerNewScript;


    // Use this for initialization
    void Start () {
        gmManagerNewScript = gmManagerNew.GetComponent<GameManagerNew>();
        minVelocity0 = 1;
        maxVelocity1 = 3;
        NewSpawn();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateBuild(int idSpawner)
    {
        if (gmManagerNewScript.timer > 60) {
            maxVelocity0 = 4;
        }
        randomTypeBuild = Random.Range(0, 4);
        randVelocity = Random.Range(minVelocity0, maxVelocity0);
        GameObject build = Instantiate(builds[randomTypeBuild], spawns[idSpawner].transform);
        build.GetComponent<Rigidbody2D>().velocity = new Vector2(0, randVelocity);
        build.GetComponent<BuildConf>().idSpawner = idSpawner;
    }

    public void NewSpawn() {
        if (gmManagerNewScript.timer > 5) {
            maxVelocity0 = 4;
        }
        for (int i = 0; i < spawns.Length; i++) {
         
            randomTypeBuild = Random.Range(0, 4);
            randVelocity = Random.Range(minVelocity0, maxVelocity0);

            GameObject build = Instantiate(builds[randomTypeBuild], spawns[i].transform);
            build.GetComponent<Rigidbody2D>().velocity = new Vector2(0, randVelocity);

            build.GetComponent<BuildConf>().idSpawner = i;
        }
    }
}
