using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroManager : MonoBehaviour {
    public Text textLove;
    //
    int loveNum = 0;
    bool isControlHero = true;

	// Use this for initialization
	void Start () {
        UpdateLoveNum();

    }
	
	// Update is called once per frame
	void Update () {
        if (isControlHero && Input.GetKey("up")) {
            transform.Translate(0, 0, 0.1f);
        }
        if (isControlHero && Input.GetKey("down")) {
            transform.Translate(0, 0, -0.1f);
        }
        if (isControlHero && Input.GetKey("left")) {
            transform.Translate(-0.1f, 0, 0);
        }
        if (isControlHero && Input.GetKey("right")) {
            transform.Translate(0.1f, 0, 0);
        }

    }

    //コリジョン接触
    void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player") {
            loveNum++;
            UpdateLoveNum();
        }
    }

    //Love数の更新
    void UpdateLoveNum() {
        textLove.text = loveNum + " Love";
    }

    //ヒーロー操作フラグ
    public void SetControllHero(bool flag) {
        isControlHero = flag;
    }
}
