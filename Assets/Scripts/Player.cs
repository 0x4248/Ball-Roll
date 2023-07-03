using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D body;
    public BoxCollider2D collision;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        collision = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalinput * 10,body.velocity.y);    
        if (Input.GetKeyDown(KeyCode.S)){
            body.velocity = new Vector2(body.velocity.x,-5);
        }  
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Spike"){
            body.position = new Vector2(0,0);
        }
        if (collision.gameObject.tag == "Jump"){
            body.AddForce(Vector2.up * 1000);
        }
    }
}
