using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] private float speed; //Pipes için float türünde bir speed değişkeni oluşturduk. 

    [SerializeField] private float lifeTime; //Pipe'ın lifeTime'ı için float türünde bir değişken oluşturduk.
    

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(gameObject, lifeTime);//Vereceğimiz lifeTime dolduğunda bu gameObject yok olacak
    }
}
