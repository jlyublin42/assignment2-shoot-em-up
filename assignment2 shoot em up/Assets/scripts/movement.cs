using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    
    Vector2 moving;

    // Update is called once per frame
    void Update()
    {
        moving.x = Input.GetAxisRaw("Horizontal");
        moving.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moving * speed * Time.fixedDeltaTime);
    }
}
