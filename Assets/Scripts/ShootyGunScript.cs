using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class ShootyGunScript : MonoBehaviour
{


    [SerializeField] public GameObject bullet; // Reference to the Bullet GameObject
    public float bulletSpeed = 10f; // Speed of the bullet

    void Update()
    {
        // Check for mouse button release
        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the Bullet
        GameObject newBullet = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation);

        // Activate the Bullet
        newBullet.SetActive(true);
        Destroy(newBullet,3f);
        // Set Bullet Velocity
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = transform.right * bulletSpeed; // Assumes Gun is oriented correctly
        }
    }




    // [SerializeField] private float bulletSpeed = 10f;
    // [SerializeField] private GameObject bulletPrefab;

    // void Start()
    // {
    //     // Load the bullet prefab from the Resources folder
    //     // bulletPrefab = Resources.Load<GameObject>("Prefabs/Bullet");

    //     // Check if the prefab was loaded successfully
    //     // if (bulletPrefab == null)
    //     // {
    //     //     Debug.LogError("Bullet prefab not found! Ensure it's in the Resources folder and named 'Bullet'.");
    //     // }
    // }

    // void Update()
    // {
    //     // Detect mouse button press
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Shoot();
    //     }
    // }

    // private void Shoot()
    // {
    //     if (bulletPrefab == null) return;

    //     // Instantiate the bullet at the gun's position and rotation
    //     GameObject bullet = Instantiate(bulletPrefab);
    //     bullet.SetActive(true);
    //     // Get the Rigidbody2D of the instantiated bullet
    //     Rigidbody2D bulletRG = bullet.GetComponent<Rigidbody2D>();

    //     if (bulletRG != null)
    //     {
    //         // Set the bullet's velocity in the direction the gun is facing
    //         bulletRG.velocity = transform.right * bulletSpeed;
    //         Debug.Log(transform.right);
    //     }
    //     else
    //     {
    //         Debug.LogError("Rigidbody2D component missing on bullet prefab!");
    //     }
        
    // }
}
