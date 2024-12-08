using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.AssetImporters;

public class meme : MonoBehaviour
{
    public float kakashka;
    private Rigidbody2D rb;
    public GameObject chavel;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * kakashka;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "kaka")
        {
            Destroy(gameObject);
            chavel.SetActive(true);
            Time.timeScale = 0;
           
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "paka")
        {
            Destroy(gameObject);
            chavel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    


}
