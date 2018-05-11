using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public GameObject gameManager;
    public Rigidbody enemyRigidbody;
    float moveTime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveTime += Time.deltaTime;
        if (moveTime >= 3.0f) {
            moveTime = 0;

            Vector3 moveVector3 = new Vector3(Random.Range(-200f, 200f), 0, Random.Range(-300f, 200f));
            enemyRigidbody.AddForce(moveVector3);

            Debug.Log("Enemy: x=" + moveVector3.x + " z=" + moveVector3.z);
        }
    }

    //コリジョン接触
    void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player") {
            gameManager.GetComponent<GameManager>().GameOver();
        }
    }

}
