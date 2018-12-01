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
        /*if (Input.GetMouseButtonUp(0))
        {
            posFinal = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            currentSwipe = new Vector2(posFinal.x - posInit.x, posFinal.y - posInit.y);

            currentSwipe.Normalize();

            //swipe upwards
            if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                directionSwipe = "up";
            }
            //swipe down
            if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
            {
                directionSwipe = "down";
            }
            //swipe left
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                directionSwipe = "left";
            }
            //swipe right
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                directionSwipe = "right";
            }
        }*/
    }
}
