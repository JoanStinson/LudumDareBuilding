using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {
    private GameObject gmManager;
    private PowerUpManager pwrUpManager;
    public GameObject cut;
    public AudioClip cutBuild;
	// Use this for initialization
	void Start () {
        gmManager = GameObject.Find("GameManager");
        pwrUpManager = gmManager.GetComponent<PowerUpManager>();
        cut = GameObject.Find("CutFloor");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Blade")
        {
            Debug.Log("Floor Hit");

            GameManagerNew.score += 10;
            GameManagerNew.floorsSliced++;
            pwrUpManager.GeneratePowerUp1();
            cut.GetComponent<AudioSource>().Play();
            
            Destroy(gameObject);
        }

        if (other.tag == "Top")
        {
            Debug.Log("You died");
            GameManagerNew.instance.GameOver();
        }
    }
}
