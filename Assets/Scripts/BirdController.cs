using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float jumpForce; //Float türünde bir değişken oluşturduk. Bird'e zıplama gücü vereceğiz.

    [SerializeField] private Rigidbody2D rb; //Bu classı Rigidbody'e bağladık.

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Mouse tıklandığı anda;
        {
            rb.velocity = Vector2.up * jumpForce; //velocity içerisinden V2up ile jumpForce'u çarparak bir zıplama gücü elde et
        }
    }
}
