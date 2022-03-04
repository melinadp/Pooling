using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform gun;
    public GameObject prefab;
    public int bulletType;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            GameObject bullet = PoolManager.instance.GetPooledObject(bulletType);
            bullet.transform.position = gun.position;
            bullet.SetActive(true);
        }
    }
}
