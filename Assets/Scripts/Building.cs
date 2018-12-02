using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {
    public bool contact1, contact2, contact3, firstCut;
    public float knocbackForce = 10000f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ApplyForce()
    {
        if (contact1 && contact2 && contact3 & !firstCut)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * knocbackForce);
        }
    }
}
