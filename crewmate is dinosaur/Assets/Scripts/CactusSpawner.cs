using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour {

    public GameObject cactus1;
    public GameObject cactus2;
    public GameObject cactus3;
    public GameObject cactus4;
    public GameObject cactus5;

    public float spawnTime = 15f;

    public float spawnDelay = 1000f;

    private void Start() {
        InvokeRepeating("Spawn", spawnTime, spawnDelay);
    }

    private void Spawn() {
        int cactus = Random.Range(1,6);

        if(cactus == 1) {
            Instantiate(cactus1, transform.position, transform.rotation);
        }

        else if(cactus == 2) {
            Instantiate(cactus2, transform.position, transform.rotation);
        }

        else if(cactus == 3) {
            Instantiate(cactus3, transform.position, transform.rotation);
        }

        else if(cactus == 4) {
            Instantiate(cactus4, transform.position, transform.rotation);
        }

        else if(cactus == 5) {
            Instantiate(cactus5, transform.position, transform.rotation);
        }

        //Debug.Log(cactus);

    }

}
