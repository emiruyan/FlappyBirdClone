using System;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float jumpForce; //Float türünde bir değişken oluşturduk. Bird'e zıplama gücü vereceğiz.

    [SerializeField] private Rigidbody2D rb; //Bu classı Rigidbody'e bağladık.
    
    [SerializeField] private Text scoreText;

    private int score;

    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Mouse tıklandığı anda;
        {
            rb.velocity = Vector2.up * jumpForce; //velocity içerisinden V2up ile jumpForce'u çarparak bir zıplama gücü elde et
        }
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.tag == "Score") //tetiklenen colliderın tagı "Score" ise;
        {
            score++; //score'u bir arttır
            scoreText.text = score.ToString(); //scoreText'in içerisindeki texte yazdır ve ToString'e çevir.
        }
    }
}
