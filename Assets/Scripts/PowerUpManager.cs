using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{

    public GameObject powerUp1Button, powerUp2Button, powerUp3Button;
    public GameObject explosion;
    public int bombas;
    float provabilityBomb;
    private GameObject []buildings;
    public GameObject pointSpawns;
    private USpawnManager spawnM;
    public AudioSource bombActivate, bombSound;
    public GameObject particles;
    public GameObject cam;


    // Use this for initialization
    void Start()
    {
        spawnM = pointSpawns.GetComponent<USpawnManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bombas > 0)
        {
            powerUp1Button.SetActive(true);
        }
        else
        {
            powerUp1Button.SetActive(false);
        }

        if (cam.GetComponent<CameraShake>().shake_intensity <= 0) {
            cam.GetComponent<CameraShake>().enabled = false;
        }
    }
    public void GeneratePowerUp1()
    {
        provabilityBomb = Random.Range(0, 10);
        if (provabilityBomb == 9 && bombas == 0)
        {
            bombas += 1;
            bombActivate.Play();
        }
    }
    public void UsePowerup1()
    {
        bombas -= 1;
        buildings = GameObject.FindGameObjectsWithTag("instance");
        bombSound.Play();
        for (var i = 0; i < buildings.Length; i++) {
            
                Destroy(buildings[i]);
            
        }
        spawnM.NewSpawn();
        GameManagerNew.score += 500;
        Instantiate(particles, new Vector3(0,4,0), Quaternion.identity);
        cam.GetComponent<CameraShake>().enabled = true;
    }

    public void UsePowerup2()
    {

    }

    public void UsePowerup3()
    {

    }
}
