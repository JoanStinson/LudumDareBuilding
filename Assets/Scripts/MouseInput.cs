//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.EventSystems;


//public class MouseInput : MonoBehaviour {
//    public GameObject blade;
//    public float distanceBlade;
//    public float distanceParticles;
//    public GameObject particles;
//    private Vector3 bladePos;
//    private Vector3 posInitBlade;
//    private Vector3 particlesPos;
//    private Vector3 posInitParticles;
//    private Vector3 posMouse;
//    List<RaycastResult> results;

//    // Use this for initialization
//    void Start () {
//    }

//    void  Update()
//    {
        
//        if (Input.GetMouseButtonDown(0))
//        {
//            GraphicRaycaster gr = this.GetComponent<GraphicRaycaster>();
//            PointerEventData pointerData = new PointerEventData(EventSystem.current);
//            pointerData.position = Input.mousePosition; // use the position from controller as start of raycast instead of mousePosition.

//            results = new List<RaycastResult>();
//            EventSystem.current.RaycastAll(pointerData, results);
//        }
//        if (Input.GetMouseButton(0))
//        {
//            posInitBlade = Input.mousePosition;
//            posInitBlade.z = distanceBlade;
//            bladePos = Camera.main.ScreenToWorldPoint(posInitBlade);

//            posInitParticles = Input.mousePosition;
//            posInitParticles.z = distanceParticles;
//            particlesPos = Camera.main.ScreenToWorldPoint(posInitParticles);

//            if (!blade.gameObject.activeSelf && !GameManager.instance.isPause && !GameManager.instance.isGameOver && results.Count == 0) {
//                blade.SetActive(true);
                
//            }
//            else
//            {
//                blade.transform.position = bladePos;
                
//            }

//            if (!particles.gameObject.activeSelf && !GameManager.instance.isPause && !GameManager.instance.isGameOver && results.Count == 0)
//            {
//                particles.SetActive(true);
//            }

//            else{
//                particles.transform.position = particlesPos;
//            }
//        }
//        if (Input.GetMouseButtonUp(0))
//        {

//            blade.SetActive(false);
//            particles.SetActive(false);
//        }
//    }
    
//}
