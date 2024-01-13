using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemachanic : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    public GameObject bulletPrefab; 
    public Transform firePoint; 
    public float bulletSpeed = 10.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
        }
            playermovement();
    }
    private void playermovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");


        Vector3 moveDirection = new Vector3(horizontalInput, 0, 0);


        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        float verticalInput = Input.GetAxis("Vertical");


        Vector3 moveDirection1 = new Vector3(0, verticalInput, 0);


        transform.Translate(moveDirection1 * moveSpeed * Time.deltaTime);
    }
    void fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;

        
        Destroy(bullet, 1.5f);
    }
}

