using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    private Vector3 originPosition;
    private Quaternion originRotation;
    private float shake_decay;
    public float shake_intensity;

    void OnGUI() {
        /*if (GUI.Button(new Rect(20, 40, 80, 20), "Shake")) {
            Shake();
        }*/
    }

    private void Start() {
        originPosition = transform.position;
        originRotation = transform.rotation;
    }

    private void OnEnable() {
        //originPosition = transform.position;
        //originRotation = transform.rotation;
        shake_intensity = 0.05f;
        shake_decay = 0.0005f;
        Shake();
    }

    void Update() {
        if (shake_intensity > 0) {
            transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
            transform.rotation = new Quaternion(
            originRotation.x + Random.Range(-shake_intensity, shake_intensity) * 0.2f,
            originRotation.y + Random.Range(-shake_intensity, shake_intensity) * 0.2f,
            originRotation.z + Random.Range(-shake_intensity, shake_intensity) * 0.2f,
            originRotation.w + Random.Range(-shake_intensity, shake_intensity) * 0.2f);
            shake_intensity -= shake_decay;
        }
    }

    void Shake() {
        originPosition = transform.position;
        originRotation = transform.rotation;
        //shake_intensity = .3f;
        //shake_decay = 0.002f;
    }
}
