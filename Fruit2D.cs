using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit2D : MonoBehaviour
{
    private bool canBeDead;
    private Vector3 screen;
    public GameObject splat;
    public AudioClip splatSound;
    public float volume = 1;

    void Start()
    {
        
    }

    void Update()
    {
        screen = Camera.main.WorldToScreenPoint(transform.position);
        if (canBeDead && screen.y < -20){
        Destroy(gameObject);
        }
        else if(!canBeDead && screen.y > -10){
            canBeDead = true;
        }
    }
    
    public void Hit(){
        Destroy(gameObject);
        //AudioSource.PlayClipAtPoint(splatSound, transform.position, volume);
        GameObject newsplat = Instantiate(splat,new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.Euler(0,0, Random.Range (-90F, 90F))) as GameObject;
    }
}
