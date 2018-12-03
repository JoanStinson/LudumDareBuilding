using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

    public GameObject cut;
	// Use this for initialization
	void Start () {
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
