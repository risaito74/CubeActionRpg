using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject cubeHero;
    public GameObject textGameOver;
    public GameObject buttonRestart;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //
    public void GameOver() {
        textGameOver.SetActive(true);
        buttonRestart.SetActive(true);
        cubeHero.GetComponent<HeroManager>().SetControllHero(false);
        Time.timeScale = 0;
    }

    //リスタート押下処理
    public void PushRestartButton() {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("main");
    }

}
