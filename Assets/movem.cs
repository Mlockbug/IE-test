using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movem : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 movemen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))* 0.25f);
    }
}
