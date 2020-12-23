using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusMovement : MonoBehaviour {

    public static float cactusSpeed = 15f;

    private void Update() {
        float speed = -cactusSpeed * Time.deltaTime; 
        Vector3 move = new Vector3(speed, 0f, 0f);
        gameObject.transform.Translate(move); 

        if(PlayerMovement.groundSpeed) {
            cactusSpeed = 10f;
        }
        else if(!PlayerMovement.groundSpeed) {
            cactusSpeed = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D player) {
        if(player.gameObject.tag == ("Despawner")) {
            Destroy(gameObject);
        }
    }

}
