using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusDespawner : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D cactus) {
        Destroy(cactus.gameObject);
    }
    
}
