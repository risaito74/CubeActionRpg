using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {
    public GameObject gameManager;
    public GameObject cubeEnemy;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //トリガー接触
    void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player") {
            gameManager.GetComponent<GameManager>().GameOver();
        }
        if (other.gameObject.tag == "Enemy") {
            cubeEnemy.transform.position = new Vector3(0, 3, 0);
        }
    }
}
