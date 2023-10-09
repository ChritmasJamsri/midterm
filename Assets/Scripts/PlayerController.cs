using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [SerializeField] private float rotationSpeed = 100f;


    [SerializeField] private Soundlibrary sound;
    public PlayerData PlayerData;   

    private Rigidbody rb;

    public void AddScore()
    {
        PlayerData.score = PlayerData.score + 1 ;
       

         audioSource.Play();
    }

    public void AddScorekey()
    {
        PlayerData.Key = PlayerData.Key + 1;
    }

    public int Addkey()
    {
        return PlayerData.score;
    }

    public int Keytext()
    {
        return PlayerData.Key;
    }


    private AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = sound.coin;

    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f;
        float Y = 0.0f;
        
        if (Input.GetKey(KeyCode.A)) 
        {
            Y = rotationSpeed * Time.deltaTime;
        }



        else if (Input.GetKey(KeyCode.D)) 
        {
            Y = -rotationSpeed * Time.deltaTime;
        }
        


        else if (Input.GetKey(KeyCode.W))
        {
            x = rotationSpeed * Time.deltaTime;
        }


        else if (Input.GetKey(KeyCode.S))
        {
           x  = -rotationSpeed * Time.deltaTime;
        }

        rb.AddTorque(x, 0, Y);

    }
}
