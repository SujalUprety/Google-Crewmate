using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float jumpForce = 2000f;

    public bool onGround = true;

    public Rigidbody2D rb;

    public Animator anim;

    public Animator ground;

    public static bool groundSpeed;

    private void Start() {
        anim.SetBool("Jump", false);
        groundSpeed = true;
    }

    private void Update() {
        if(Input.touchCount > 0 && onGround && GameManager.started) {
            rb.AddForce(new Vector2(0f, jumpForce));
            anim.SetBool("Jump", true);
            onGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D objects) {
        if(objects.gameObject.tag == ("Ground")){
            anim.SetBool("Jump", false);
            onGround = true;
        }
        if(objects.gameObject.tag == ("Cactus")) {
            anim.SetBool("Death", true);
            groundSpeed = false;
            ground.SetBool("Ended", true);
            Invoke("characterDeath", 1);
        }
    }

    private void characterDeath() {
        GameManager.gameEnded();
    }

}
