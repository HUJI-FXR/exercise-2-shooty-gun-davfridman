using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class ShootyGunScript : MonoBehaviour
{


    [SerializeField] public GameObject bullet;
    public float bulletSpeed = 10f; 
    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation);

        newBullet.SetActive(true);
        Destroy(newBullet,3f);
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = transform.right * bulletSpeed; 
        }
    }
}
