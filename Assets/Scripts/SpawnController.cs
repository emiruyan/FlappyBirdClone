using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab; //Prefab'ımıza ulaşmak için GameObject oluşturduk.
    
    //Pipe'ları hangi pozisyonarda üreteceğimizi sağlayan değişkenler;
    public float minY;
    public float maxY;
    public float x;
    public float interval; //Pipe'ları hangi aralıklarla üreteceğimiz sağlayan değişken.
    
    void Start()
    {
        InvokeRepeating("Spawn", interval,interval);
    }

    private void Spawn() //Pipe'larımızın spawnlanmasını kontrol edeceğimiz method
    {
        GameObject Instance = Instantiate(pipePrefab);  
        Instance.transform.position = new Vector2(x, Random.Range(minY, maxY));
        //                                                  minY ve maxY arasında rastgele Pipe üretecek.
    }

 
}
