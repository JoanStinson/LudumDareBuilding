using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour {

    public GameObject cube;
	// Use this for initialization
	void Start () {
		
	}

    void  Update()
    {
        if (Input.GetMouseButton(0))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = 5;       // we want 2m away from the camera position
            var objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            if(cube == null)
                Instantiate(cube, objectPos, Quaternion.identity);
            else
            {
                cube.transform.position = objectPos;
            }
        }
    }
}
