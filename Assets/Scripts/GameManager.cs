using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

	private void Start () {
        if (!instance) instance = this;
    }
	
	private void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();
    }

    public void Pause() {
        //Time.timeScale = isPlayerMenu ? 0 : 1;
        Time.timeScale = 0;
        print("Pause");
    }

    public void GameOver() {
        Time.timeScale = 0;
        print("Game Over");
    }
}
