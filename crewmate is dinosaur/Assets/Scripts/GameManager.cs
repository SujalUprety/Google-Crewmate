using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static bool started = false;
    public static bool ended = false;

    private void Start() {
        Time.timeScale = 0;
    }

    private void Update() {
        if(Input.touchCount > 0 && !started) {
            Time.timeScale = 1;
            Invoke("gameStart", 1);
        }

        if(Input.touchCount > 0 && ended) {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            ended = false;
        }

    }

    private void gameStart() {
        started = true;
    }

    public static void gameEnded() {
        Time.timeScale = 0;
        ended = true;
        started = false;
    }

}
