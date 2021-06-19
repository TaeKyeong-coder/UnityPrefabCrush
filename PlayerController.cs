using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //GameObject blackcat;

    void Start()
    {
        //this.blackcat = GameObject.Find("blackcat");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }
        //검정고양이와 흰색 고양이 충돌하면
        /*Vector2 p1 = transform.position; 
        Vector2 p2 = this.blackcat.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;
        float r2 = 1.0f;

        if (d < r1 + r2) 
        {
            Destroy(gameObject);
        }*/
    }
}
