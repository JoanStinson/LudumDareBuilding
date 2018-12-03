using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USpawnManager : MonoBehaviour {
    public GameObject []builds;
    public GameObject [] spawns;
    private int randRangeAppear;
    private int randomTypeBuild;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < spawns.Length; i++)
        {
            randomTypeBuild = Random.Range(0, 5);
            
            GameObject build = Instantiate(builds[randomTypeBuild], spawns[i].transform);
          
            build.GetComponent<BuildConf>().idSpawner = i;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateBuild(int idSpawner)
    {
        randomTypeBuild = Random.Range(0, 5);
        GameObject build = Instantiate(builds[randomTypeBuild], spawns[idSpawner].transform);
        build.GetComponent<BuildConf>().idSpawner = idSpawner;
    }
}
