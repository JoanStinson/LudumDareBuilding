using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct BuildingStruc {

    public int currentHeight;

    public BuildingStruc(int currentHeight) {
        this.currentHeight = currentHeight;
    }
}

public class NewSpawn : MonoBehaviour {

    public static NewSpawn instance;
    public GameObject[] buildings;
    public GameObject building1, building2, building3, building4, building5;
    public GameObject spawnpoint1, spawnpoint2, spawnpoint3, spawnpoint4, spawnpoint5;
    public bool b1, b2, b3, b4, b5;
    public float speedY;

	void Start () {
        if (instance == null) instance = this;
        speedY = Random.Range(0.05f, 0.1f);
	}
	
	void Update () {

        // Movement
        UpdatePosition(building1);
        UpdatePosition(building2);
        UpdatePosition(building3);
        UpdatePosition(building4);
        UpdatePosition(building5);

        // Saber en qualsevol moment quina size te cadascun
        //BuildingStruc b1 = new BuildingStruc(8);
        //BuildingStruc b2 = new BuildingStruc(8);
        //BuildingStruc b3 = new BuildingStruc(8);
        //BuildingStruc b4 = new BuildingStruc(8);
        //BuildingStruc b5 = new BuildingStruc(8);

        // Delay perque et torni a sortir nou edifici
        if (building1.transform.position.y > -2.8f && !b1) {
            print("a");
            StartCoroutine(GenerateBuilding(building1, 2f, spawnpoint1, b1)); 
        }
        if (building2.transform.position.y > -2.8f && !b2) {
            StartCoroutine(GenerateBuilding2(building2, 2f, spawnpoint2, b2));
        }
        if (building3.transform.position.y > -2.8f && !b3) {
            StartCoroutine(GenerateBuilding3(building3, 2f, spawnpoint3, b3));
        }
        if (building4.transform.position.y > -2.8f && !b4) {
            StartCoroutine(GenerateBuilding4(building4, 2f, spawnpoint4, b4));
        }
        if (building5.transform.position.y > -2.8f && !b5) {
            StartCoroutine(GenerateBuilding5(building5, 2f, spawnpoint5, b5));
        }




    }

    IEnumerator GenerateBuilding(GameObject o, float time, GameObject spawnpoint, bool b) {
        yield return new WaitForSeconds(time);
        //
        if (!b1) {
            Instantiate(o, spawnpoint.transform.position, Quaternion.identity);
        }
        b1 = true;
    }

    IEnumerator GenerateBuilding2(GameObject o, float time, GameObject spawnpoint, bool b) {
        yield return new WaitForSeconds(time);
        if (!b2) {
            Instantiate(o, spawnpoint.transform.position, Quaternion.identity);
        }
        b2 = true;
    }

    IEnumerator GenerateBuilding3(GameObject o, float time, GameObject spawnpoint, bool b) {
        yield return new WaitForSeconds(time);
        if (!b3) {
            Instantiate(o, spawnpoint.transform.position, Quaternion.identity);
        }
        b3 = true;
    }

    IEnumerator GenerateBuilding4(GameObject o, float time, GameObject spawnpoint, bool b) {
        yield return new WaitForSeconds(time);
        if (!b4) {
            Instantiate(o, spawnpoint.transform.position, Quaternion.identity);
        }
        b4 = true;
    }

    IEnumerator GenerateBuilding5(GameObject o, float time, GameObject spawnpoint, bool b) {
        yield return new WaitForSeconds(time);
        if (!b5) {
            Instantiate(o, spawnpoint.transform.position, Quaternion.identity);
        }
        b5 = true;
    }

    private IEnumerator AddPiece() {
        yield return new WaitForSeconds(2f);
        //Setactives
    }

    private IEnumerator DestroyObject() {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    private void UpdatePosition(GameObject building) {
        building.transform.position += new Vector3(0, speedY, 0);
    }
}
