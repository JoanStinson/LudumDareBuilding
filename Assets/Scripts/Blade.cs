using UnityEngine;
using System.Collections;

public class Blade : MonoBehaviour
{
    public GameObject bladeTrailPrefab;
    public float minCuttingVelocity = .001f;

    bool isCutting = false;

    Vector2 previousPosition;

    GameObject currentBladeTrail;
    public GameObject particles;

    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }
        if (isCutting)
        {
            UpdateCut();
        }
        else
        {

        }
    }
    void UpdateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;

        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if(velocity > minCuttingVelocity)
        {
            circleCollider.enabled = true;

        }
        else
        {
            circleCollider.enabled = false;
        }

        previousPosition = newPosition;
    }
    void StartCutting()
    {
        isCutting = true;
        currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        circleCollider.enabled = true;
    }
    void StopCutting()
    {
        isCutting = false;
        currentBladeTrail.transform.SetParent(null);
        Destroy(currentBladeTrail, 2f);
        circleCollider.enabled = false;
    }

  /*  void OnTriggerEnter(Collider other)
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
            other.transform.GetComponentInParent<Building>().contact3 && !other.transform.GetComponentInParent<Building>().firstCut)
        {
            //AddForce();
            //print("CORTEEEEEEEE");
            other.transform.GetComponentInParent<Building>().ApplyForce();
            other.transform.GetComponentInParent<Building>().firstCut = true;
            //powerUpScript.GeneratePowerUp1();
            GameManager.score += 100;
        }

    }*/
}
