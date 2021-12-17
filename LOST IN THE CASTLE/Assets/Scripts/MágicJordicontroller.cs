using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MágicJordicontroller : MonoBehaviour
{
    public float jumpSpeed = 3;

    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + 5.0f * horizontal * Time.deltaTime;

        rigidbody2d.MovePosition(position);

        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpSpeed);
        }
    }
}
