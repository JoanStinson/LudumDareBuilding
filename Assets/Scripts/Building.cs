using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {
    public bool contact1, contact2, contact3, firstCut;
    public float knocbackForce = 10000f;

    void Start () {
		
	}
	
	void Update () {
		
	}

    public void ApplyForce()
    {
        if (contact1 && contact2 && contact3 & !firstCut)
        {
            transform.Rotate(90f, 0f, 0f);
            //gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * knocbackForce);
            //gameObject.GetComponent<Rigidbody>().useGravity = true;
            StartCoroutine(DestroyObject());
            Debug.Log("ApplyForce");

            //TODO contar fills quan destroy
        }
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision.transform.CompareTag("Top")) {
            NewSpawn.instance.speedY = 0;
            print("caca");
        }
    }       

    private IEnumerator DestroyObject() {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
