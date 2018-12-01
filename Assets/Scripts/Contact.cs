using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour {

    public GameObject particles;
    public GameObject trail;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Building"))
        {

        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Building"))
        {
            ParticleSystem.MainModule settings = particles.GetComponent<ParticleSystem>().main;
            settings.startColor = new Color(255,0,0,255);

            particles.transform.GetChild(0).GetComponent<TrailRenderer>().startColor = new Color(255, 0, 0, 255);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Building"))
        {
            ParticleSystem.MainModule settings = particles.GetComponent<ParticleSystem>().main;
            settings.startColor = new Color(255, 255, 255, 255);
            particles.transform.GetChild(0).GetComponent<TrailRenderer>().startColor = new Color(255, 255, 255, 255);
        }
    }
}
