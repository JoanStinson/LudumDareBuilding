using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public GameObject panelTutorial, panelOptions, panelCredits;
    public GameObject playButton, tutorialButton, optionsButton, creditsButton;
    float lengthClickButton;

    // Use this for initialization
    void Start() {
        lengthClickButton = playButton.GetComponent<AudioSource>().clip.length;
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
        Invoke("Play", lengthClickButton);
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
    public void ButtonBack()
    {
        if (panelTutorial.activeInHierarchy)
            Invoke("BackTutorial", lengthClickButton);
        else if (panelOptions.activeInHierarchy)
            Invoke("BackOption", lengthClickButton);
        else if (panelCredits.activeInHierarchy)
            Invoke("BackCredits", lengthClickButton);
    }

    void Play()
    {
        SceneManager.LoadScene("Gameplay");
    }

    void BackTutorial()
    {
        panelTutorial.SetActive(false);
    }

    void BackOption()
    {
        panelOptions.SetActive(false);
    }
    void BackCredits()
    {
        panelCredits.SetActive(false);
    }
}
