using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USpawnManager : MonoBehaviour {
    public GameObject []builds;
    public GameObject [] spawns;
    private int randVelocity;
    private int randomTypeBuild;
    public int minVelocity;
    public int maxVelocity;
    public GameObject gmManagerNew;
    private GameManagerNew gmManagerNewScript;
    private int rangeMax;

    // Use this for initialization
    void Start () {
        gmManagerNewScript = gmManagerNew.GetComponent<GameManagerNew>();
        minVelocity = 1;
        maxVelocity = 3;
        rangeMax = 2;
        NewSpawn();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateBuild(int idSpawner)
    {
        if (gmManagerNewScript.timer >= 15 && gmManagerNewScript.timer < 30)
        {
            rangeMax = 4;
        }
        else if (gmManagerNewScript.timer >= 30 && gmManagerNewScript.timer < 45)
        {
            maxVelocity = 4;
            rangeMax = 5;
        }
        else if (gmManagerNewScript.timer >= 45)
        {
            minVelocity = 2;
        }
        randomTypeBuild = Random.Range(0, rangeMax);
        randVelocity = Random.Range(minVelocity, maxVelocity);
        GameObject build = Instantiate(builds[randomTypeBuild], spawns[idSpawner].transform);
        build.GetComponent<Rigidbody2D>().velocity = new Vector2(0, randVelocity);
        build.GetComponent<BuildConf>().idSpawner = idSpawner;
    }

    public void NewSpawn() {
        if (gmManagerNewScript.timer >= 15 && gmManagerNewScript.timer < 30)
        {
            rangeMax = 4;
        }
        else if (gmManagerNewScript.timer >= 30 && gmManagerNewScript.timer < 45)
        {
            maxVelocity = 4;
            rangeMax = 5;
        }
        else if (gmManagerNewScript.timer >= 45)
        {
            minVelocity = 2;
        }
        for (int i = 0; i < spawns.Length; i++) {
         
            randomTypeBuild = Random.Range(0, rangeMax);
            randVelocity = Random.Range(minVelocity, maxVelocity);

            GameObject build = Instantiate(builds[randomTypeBuild], spawns[i].transform);
            build.GetComponent<Rigidbody2D>().velocity = new Vector2(0, randVelocity);

            build.GetComponent<BuildConf>().idSpawner = i;
        }
    }
}
