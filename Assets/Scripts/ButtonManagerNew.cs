using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagerNew : MonoBehaviour {

    public GameObject panelTutorial, panelOptions, panelCredits;
    public GameObject playButton, tutorialButton, optionsButton, creditsButton;
    float lengthClickButton;

    private void Start() {
        lengthClickButton = playButton.GetComponent<AudioSource>().clip.length;
    }

    private void Update() {

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
        //Invoke("Play", lengthClickButton);
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
    public void ButtonBack()
    {
        if (panelTutorial.activeInHierarchy)
            BackTutorial();
        else if (panelOptions.activeInHierarchy)
            BackOption();
        else if (panelCredits.activeInHierarchy)
            BackCredits();
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
