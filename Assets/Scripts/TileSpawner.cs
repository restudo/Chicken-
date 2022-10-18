using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject tileContainer;
    public float timer;
    float time = 0;

    void Update(){
        if(time <= 0){
            Instantiate(tileContainer, transform.position, Quaternion.identity);
            time = timer;
        }
        else{
            time -= Time.deltaTime;
        }
    }
}
