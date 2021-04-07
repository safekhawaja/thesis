using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickinst : MonoBehaviour
{
    public GameObject[] spawnees;
    public Transform spawnPos;
    
    int randomInt;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            SpawnRandom();
        }
    }


    void SpawnRandom()
    {
        randomInt = Random.Range(0, spawnees.Length);
        Instantiate(spawnees[randomInt], spawnPos.position, Quaternion.Euler(new Vector3(90, Random.Range(0, 360), 0)));
    }
}
