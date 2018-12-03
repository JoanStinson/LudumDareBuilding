using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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

            Destroy(gameObject);
        }

        if (other.tag == "Top")
        {
            Debug.Log("You died");
            GameManagerNew.instance.GameOver();
        }
    }
}
