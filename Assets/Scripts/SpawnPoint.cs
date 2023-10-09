using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    private GameObject spawnObject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(spawnObject,transform.position , transform.rotation); 
    }
}
