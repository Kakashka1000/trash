using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public int monetti;
    public Text monetitext;

    private void Update()
    {
        monetitext.text = monetti.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
            if (collision.tag == "eta")
            {
                monetti++;
            }
    }
        
    private void Start()
    {
        monetti = 0;
    }
    


    
}
