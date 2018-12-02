using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public GameObject panelTutorial, panelOptions, panelCredits;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panelTutorial.activeInHierarchy)
                panelTutorial.SetActive(false);
            else if (panelOptions.activeInHierarchy)
                panelOptions.SetActive(false);
            else if (panelCredits.activeInHierarchy)
                panelCredits.SetActive(false);
        }
    }

    public void ButtonPlay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void ButtonTutorial()
    {
        panelTutorial.SetActive(true);
    }
    public void ButtonOptions()
    {
        panelOptions.SetActive(true);
    }
    public void ButtonCredits()
    {
        panelCredits.SetActive(true);
    }
}
