using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splat2D : MonoBehaviour
{
    private Color color;
    public float destroySpeed = 0.2f;

    void Start()
    {
        color = GetComponent<SpriteRenderer>().color;
        
    }

    void Update()
    {
        GetComponent<SpriteRenderer>().color = new Color(color.r,color.g,color.b,color.a -= destroySpeed * Time.deltaTime);

        if (color.a <= 0){
            Destroy(gameObject);
        }
    }
}
