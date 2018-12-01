using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public GameObject gameoverPanel;
    public Text currentTime;
    private bool isPause = false;
    private float timer = 0;

	private void Start () {
        if (!instance) instance = this;
    }
	
	private void Update () {

        // Timer
        Timer();

        if (Input.GetKeyDown(KeyCode.Escape))
            isPause = !isPause;

        Time.timeScale = isPause ? 0 : 1;
        if (isPause)
            Pause();
    }

    private void Timer() {
        timer += Time.deltaTime;

        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");

        currentTime.text = string.Format("{0}:{1}", minutes, seconds);
        print(string.Format("{0}:{1}", minutes, seconds));
    }

    public void Pause() {
        print("Pause");
    }

    public void GameOver() {
        Time.timeScale = 0;
        print("Game Over");
        gameoverPanel.SetActive(true);
    }
}
