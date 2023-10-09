using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyText : MonoBehaviour
{
    [SerializeField] public PlayerData playerData;
    // Start is called before the first frame update
    
    [SerializeField] private TMP_Text Keytext;



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Keytext.text = playerData.Key.ToString();
    }
}