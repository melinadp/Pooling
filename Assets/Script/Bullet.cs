using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;

    //la barra baja es para diferenciar mas rapido que es privada la variable
    Rigidbody _rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidBody.velocity = Vector3.forward * bulletSpeed;
    }

    void OnCollisionEnter(Collision collision) 
    {
        this.gameObject.SetActive(false);
    }
}
