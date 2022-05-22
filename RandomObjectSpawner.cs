
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    int i;
    Vector3 Startpos;
    public GameObject[] myObjects;

    void Start(){
        Startpos = new Vector3(0,6,2);
        i=0;
    }

    void Update()
    {
            if(Time.time > i){
                i+=1;
                int randomIndex = Random.Range(0, myObjects.Length);
                Instantiate(myObjects[randomIndex], Startpos, Quaternion.identity);
            }
    }
}
