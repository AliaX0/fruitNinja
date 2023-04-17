using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    private Vector3 acceleration;
    private Vector3 gravity2;
    private Vector3 velocity;
    private Vector3 push;
    private float mass = 10;

    private void applyForce(Vector3 force){
        Vector3 a = force/mass;
        acceleration += a;
    }

    private void updatePos(){
        velocity = velocity + acceleration;
        transform.position += velocity*Time.deltaTime;
        acceleration = new Vector3 (0.0f, 0.0f);
    }
    void Start()
    {
        gravity2 = new Vector3(0, -1, 0);
        push = new Vector3(80,200,0);
        applyForce(push);
    }

    void LateUpdate()
    {
        applyForce(gravity2);
        updatePos();
    }
}
