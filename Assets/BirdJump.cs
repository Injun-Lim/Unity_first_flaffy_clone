using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float jumpPower;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //velocity는 속도
            //(0,3) 벡터2는 2차원 좌표
            rb.velocity = Vector2.up * jumpPower;
        }
    }
}
