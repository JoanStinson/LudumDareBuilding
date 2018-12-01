using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Each building is formed by pieces
public class Piece { 
    // Variables
    public float velocity;
    public float pieceTime; 
    public bool buildingFinished;
    public float pieceHeight;
    public int spawnPos;

    public Piece(float velocity, float pieceTime, bool buildingFinished, float pieceHeight, int spawnPos) {
        this.velocity = velocity;
        this.pieceTime = pieceTime;
        this.buildingFinished = buildingFinished;
        this.pieceHeight = pieceHeight;
        this.spawnPos = spawnPos;
    }
}

public class SpawnManager : MonoBehaviour {

    // Variables
    [Header("General")]
    public GameObject buildingPrefab;
    public GameObject[] buildingSpawnPoints;
    private List<Piece> building = new List<Piece>();

    [Header("Spawn Settings")]
    public int numberOfBuildings;
    public float minMoveVelocity, maxMoveVelocity; //0-5
    public float minBuildVelocity, maxBuildVelocity; //0.5-3

    private int numFinishedBuildings = 0;

    private void Start () {

        // Declare pieces
        for (int i = 0; i < numberOfBuildings; i++) {
            float randVel = Random.Range(minMoveVelocity, maxMoveVelocity);
            float pieceTime = Random.Range(minBuildVelocity, maxBuildVelocity);
            Piece newpiece = new Piece(randVel, pieceTime, false, 0f, i);
            building.Add(newpiece);
        }

        // Instantiate pieces
        for (int i = 0; i < building.Count; i++) {
            StartCoroutine(AddPiece(building[i]));
        }
    }
	
	private void Update () {

        //print("Numero Edificios Acabados: "+numFinishedBuildings);

        // Set building to finished when reaches max height
        if (numFinishedBuildings < numberOfBuildings) {
            for (int i = 0; i < building.Count; i++) {
                //print("Building " + i + ": " + building[i].buildingFinished);
                if (building[i].pieceHeight == 6f && !building[i].buildingFinished) {
                    building[i].buildingFinished = true;
                    numFinishedBuildings++;
                }
            }
        }
        // Si tots els edificis tenen el máxim de pieces Game Over
        else GameManager.instance.GameOver();  

    }

    private IEnumerator AddPiece(Piece piece) {
        while (piece.pieceHeight < 6f) {
            // Adds a piece to the building every second
            yield return new WaitForSeconds(piece.pieceTime);
            Instantiate(buildingPrefab, new Vector3(buildingSpawnPoints[piece.spawnPos].transform.position.x, 
                buildingSpawnPoints[piece.spawnPos].transform.position.y + piece.pieceHeight, 
                buildingSpawnPoints[piece.spawnPos].transform.position.z), Quaternion.identity);
            piece.pieceHeight++;
            GameManager.instance.DecreaseSunLight();
        }
    }
}
