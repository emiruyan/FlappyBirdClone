using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float jumpForce; //Float türünde bir değişken oluşturduk. Bird'e zıplama gücü vereceğiz.

    [SerializeField] private Rigidbody2D rb; //Bu classı Rigidbody'e bağladık.
    
    [SerializeField] private Text scoreText;

    [SerializeField] private GameObject gameOverPanel;

    private int score;


    private void Start()
    {
        Time.timeScale = 1; //Öldükten sonra tekrar oynayabilmek için timeScale'i Startta tekrar 1'e atıyoruz
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Mouse tıklandığı anda;
        {
            rb.velocity = Vector2.up * jumpForce; //velocity içerisinden V2up ile jumpForce'u çarparak bir zıplama gücü elde et
        }
    }

    private void OnTriggerEnter2D(Collider2D col)  //Score işlemi için OnTriggerEnter ve "Tag" yönetimini kullandık.
    {
        if (col.tag == "Score") //tetiklenen game object'ın tagı "Score" ise;
        {
            score++; //score'u bir arttır
            scoreText.text = score.ToString(); //scoreText'in içerisindeki texte yazdır ve ToString'e çevir.
        }
    }

    private void OnCollisionEnter2D(Collision2D col) // Death işlemi için OnCollisionEnter ve "Tag" yöntemini kullandık.
    {
        if (col.gameObject.tag == "Death") //çarpışan gameObject'ın tagı "Death" ise
        {
            Time.timeScale = 0; //timeScale ağır çekimdir ve burada 0'a atayıp oyunu durduruyoruz.
            gameOverPanel.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);  
    }
    
}
