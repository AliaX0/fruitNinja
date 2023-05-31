using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTo : MonoBehaviour
{
    Vector3 tF;
    Vector3 fD;
    public GameObject player;
    void Start()
    {
        tF = this.transform.up;
        Debug.DrawRay(this.transform.position, tF*2, Color.green);
        Debug.DrawRay(this.transform.position, fD, Color.red);
    }

    void Update()
    {
        fD = player.transform.position - this.transform.position;
        float angle = Vector2.Angle(tF, fD);
        player = GameObject.FindGameObjectWithTag("Player");

        Debug.DrawRay(this.transform.position, tF*2, Color.green);
        Debug.DrawRay(this.transform.position, fD, Color.red);

        this.transform.Translate(tF*Time.deltaTime);

        Vector3 crossP = Vector3.Cross(tF, fD);
        int clockwise = 1;
        if (crossP.z <0){
            clockwise =- 1;
            this.transform.rotation = Quaternion.Euler(0,0, angle*clockwise);
        }
        else{
            clockwise =+ 1;
            this.transform.rotation = Quaternion.Euler(0,0, angle*clockwise);
//}
    }
}}
