using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsSpawner : MonoBehaviour
{
    public GameObject[] Traps;
    public float timer;
    float time;

    void Start(){
        time = 0;
    }

    void Update(){
        int trapsNum = Random.Range(0, 9);
        if(time <= 0){
            Instantiate(Traps[trapsNum], transform.position, Quaternion.identity);
            time = timer;
        }
        else{
            time -= Time.deltaTime;
        }
    }

}
