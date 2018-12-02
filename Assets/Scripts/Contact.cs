using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour {

    public GameObject particles;
    public GameObject trail;
    private Vector3 _prevPos;
    private Vector3 _pos;
    private float velocityX;
    private float previousVelocityX;
    private Vector3 velocity;
    private bool changeSpeed;
    public GameObject gameManager;
    private PowerUpManager powerUpScript;

    private void Awake()
    {
        velocity = Vector3.zero;
        velocityX = 0;
        _pos = transform.position;
        _prevPos = _pos;
    }

    // Use this for initialization
    void Start () {
        powerUpScript = gameManager.GetComponent<PowerUpManager>();
        previousVelocityX = 9;

    }
	
	// Update is called once per frame
	void Update () {
        if (!GameManager.instance.isPause && !GameManager.instance.isGameOver)
        {
            _prevPos = _pos;
            previousVelocityX = velocityX;
            _pos = transform.position;

            velocity = (_pos - _prevPos) / Time.deltaTime;

            velocityX = velocity.x;

            //print("prevVel: " + previousVelocityX + "vel: " + velocityX);
            
            if ((previousVelocityX < 0 && velocityX > 0)) /*&& previousVelocityX != 0 && velocityX != 0*/
            {
                changeSpeed = true;
                //print(changeSpeed);
            }

            else if ((previousVelocityX > 0 && velocityX < 0))
            {
                changeSpeed = true;
                //print(changeSpeed);
            }
        }
        
        
    }

    void OnTriggerEnter(Collider other)
    {
 
        // contact1
        if (other.CompareTag("Contact1"))
        {
            other.transform.GetComponentInParent<Building>().contact1 = true;
            ParticleSystem.MainModule settings = particles.GetComponent<ParticleSystem>().main;
            settings.startColor = new Color(255, 0, 0, 255);

            particles.transform.GetChild(0).GetComponent<TrailRenderer>().startColor = new Color(255, 0, 0, 255);
            Debug.Log("1st Collider");
        }

        // contact2
        if (other.CompareTag("Contact2"))
        {
            other.transform.GetComponentInParent<Building>().contact2 = true;
            ParticleSystem.MainModule settings = particles.GetComponent<ParticleSystem>().main;
            settings.startColor = new Color(255, 0, 0, 255);

            particles.transform.GetChild(0).GetComponent<TrailRenderer>().startColor = new Color(255, 0, 0, 255);
            Debug.Log("2nd Collider");
        }

        // contact3
        if (other.CompareTag("Contact3"))
        {
            other.transform.GetComponentInParent<Building>().contact3 = true;
            ParticleSystem.MainModule settings = particles.GetComponent<ParticleSystem>().main;
            settings.startColor = new Color(255, 0, 0, 255);

            particles.transform.GetChild(0).GetComponent<TrailRenderer>().startColor = new Color(255, 0, 0, 255);
            Debug.Log("3rd ollider");
        }

        //if (changeSpeed)
        //{
        //    other.transform.GetComponentInParent<Building>().contact1 = false;
        //    other.transform.GetComponentInParent<Building>().contact2 = false;
        //    other.transform.GetComponentInParent<Building>().contact3 = false;
        //}
        if (other.transform.GetComponentInParent<Building>().contact1 && other.transform.GetComponentInParent<Building>().contact2 && 
            other.transform.GetComponentInParent<Building>().contact3 && !other.transform.GetComponentInParent<Building>().firstCut) {
            //AddForce();
            //print("CORTEEEEEEEE");
            other.transform.GetComponentInParent<Building>().ApplyForce();
            other.transform.GetComponentInParent<Building>().firstCut = true;
            powerUpScript.GeneratePowerUp1();
            GameManager.score += 100;
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
