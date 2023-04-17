using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_items : MonoBehaviour
{
    public float spawnTime=1; //Spawn Time
    public GameObject apple; //Apple prefab
    public GameObject bomb; //Bomb prefab
    public float upForce = 750; //Up force
    public float leftRightForce = 200; //Left and right force
    public float maxX = -7; //Max x spawn position
    public float minX = 7; //Min x spawn position
    void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn(){
        yield return new WaitForSeconds(spawnTime);
        GameObject prefab = apple;
        GameObject Bprefab = bomb;
        
        if (Random.Range(0,100)<30){
            GameObject goB = Instantiate(Bprefab,new Vector3(Random.Range(minX,maxX + 1), transform.position.y, 0f), Quaternion.Euler(0,0, Random.Range (-90F, 90F))) as GameObject; // - code for Spawn prefab bomb
            if (goB.transform.position.x > 0){
            goB.GetComponent<Rigidbody2D>().AddForce(new Vector2(-leftRightForce,upForce));
            }
            else{
            goB.GetComponent<Rigidbody2D>().AddForce(new Vector2(leftRightForce,upForce));
            }
            // StartCoroutine("Spawn"); 
        }
        
        GameObject go = Instantiate(prefab,new Vector3(Random.Range(minX,maxX + 1),transform.position.y, 0f),Quaternion.Euler(0,0, Random.Range (-90F, 90F))) as GameObject;

        //if x position is over 0 go left
        //if (go.transform.position.x > 0){
        //    go.GetComponent<Rigidbody2D>().AddForce(new Vector2(-leftRightForce,upForce));
        //}
       // else{
           //go.GetComponent<Rigidbody2D>().AddForce(new Vector2(leftRightForce,upForce));
        //}
        StartCoroutine("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
