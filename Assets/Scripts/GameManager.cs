using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public GameObject globalLight;
    public GameObject gameoverPanel, pausePanel;
    public Text currentTime;
    public bool isPause = false;
    private float timer = 0;
    public bool isGameOver = false;

	private void Start () {
        if (!instance) instance = this;
    }
	
	private void Update () {
        // Timer
        Timer();

        // Pause
        if (Input.GetKeyDown(KeyCode.Escape)) Pause();
        if (!isGameOver) Time.timeScale = isPause ? 0 : 1;
        pausePanel.SetActive(isPause);
    }

    private void Timer() {
        timer += Time.deltaTime;
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        currentTime.text = string.Format("{0}:{1}", minutes, seconds);
        //print(string.Format("{0}:{1}", minutes, seconds));
    }

    // Light - quants més edificis menys iluminació
    public void DecreaseSunLight() {
        globalLight.GetComponent<Light>().intensity -= 0.035f;//GameObject.FindGameObjectsWithTag("Building").Length/12f;
    }

    public void Pause() {
        isPause = !isPause;
    }

    public void GameOver() {
        //isGameOver = true;
        //Time.timeScale = 0;
        //gameoverPanel.SetActive(true);
    }

    public void UsePowerup1() {

    }

    public void UsePowerup2() {

    }

    public void UsePowerup3() {

    }
}
