using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb2D : MonoBehaviour
{
    private bool canBeDead;
    private Vector3 screen;

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
    }
}
