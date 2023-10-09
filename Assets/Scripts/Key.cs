using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {


        
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Key+1");
            gameObject.SetActive(false);
            

            PlayerController player = GameObject.FindAnyObjectByType<PlayerController>();
            player.AddScorekey();

        }
    }
}
