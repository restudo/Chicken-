using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public float timeUntilDestory;
    float timer;
    public float moveSpeed;

    void Start(){
        timer = timeUntilDestory;
    }

    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100f, Time.deltaTime * moveSpeed);
        if(timeUntilDestory <= 0){
            Destroy(gameObject);
            timeUntilDestory = timer;
        }
        else{
            timeUntilDestory -= Time.deltaTime;
        }
    }
}
