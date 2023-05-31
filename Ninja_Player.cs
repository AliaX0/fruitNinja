using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ninja_Player : MonoBehaviour
{
    private Vector3 pos;
    public int score = 0;
    public TMPro.TMP_Text scoreText;
    public GameObject bigScore;
    
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Debug.Log (score);
    }

    
    void Update()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer){
            if (Input.touchCount == 1){
                pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 1));
                GetComponent<Collider2D>().enabled=true;
                return;
            }
            GetComponent<Collider2D>().enabled=false;
        }   
        else {
            pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            transform.position = new Vector3(pos.x,pos.y,3);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Fruit"){
            score++;
            Debug.Log (score);
            //other.gameObject.SetActive(false);
            scoreText.text = "Score: "+ score;
            other.gameObject.GetComponent<Fruit2D>().Hit();
        }
        else if (other.tag == "Enemy"){
            score--;
            score--;
            Debug.Log (score);
            scoreText.text = "Score: "+ score;
            other.gameObject.SetActive(false);
        }
    }
}
