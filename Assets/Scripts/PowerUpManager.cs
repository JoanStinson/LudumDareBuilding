using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{

    public GameObject powerUp1Button, powerUp2Button, powerUp3Button;

    public int bombas;
    float provabilityBomb;
    // Use this for initialization
    void Start()
    {

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
    }
    public void GeneratePowerUp1()
    {
        provabilityBomb = Random.Range(0, 100);
        Debug.Log(provabilityBomb);
        if (provabilityBomb >= 60 && bombas == 0)
        {
            bombas += 1;
        }

    }
    public void UsePowerup1()
    {
        bombas -= 1;
    }

    public void UsePowerup2()
    {

    }

    public void UsePowerup3()
    {

    }
}
