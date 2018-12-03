using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsInGame : MonoBehaviour {

    public GameObject audioButton;
    private float lengthClickButton;

	private void Start () {
        lengthClickButton = audioButton.GetComponent<AudioSource>().clip.length;
        print(lengthClickButton);
        lengthClickButton = 0.456f;
    }
	
	private void Update () {
		
	}

    public void Resume() {
        GameManager.instance.isPause = false;
    }

    public void Retry() {
        SceneManager.LoadScene("Gameplay");
        //Invoke("RetryAction", lengthClickButton);
    }

    void RetryAction() {
        SceneManager.LoadScene("Gameplay");
    }

    public void MainMenu() {
        //Invoke("MainMenuAction", lengthClickButton);
        SceneManager.LoadScene("MainMenu");
    }

    void MainMenuAction() {
        SceneManager.LoadScene("MainMenu");
    }
}
