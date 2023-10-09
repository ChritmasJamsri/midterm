using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("COUNT+10");
            gameObject.SetActive(false);


            PlayerController player = GameObject.FindAnyObjectByType<PlayerController>();
            player.AddScore();

        }
    }
}
