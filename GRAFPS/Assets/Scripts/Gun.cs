using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Rigidbody projectile;
    public Rigidbody Bullet;
    public Transform firePlace;
    private bool fire;
    public float power;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            projectile = Instantiate(Bullet, firePlace.position, transform.rotation);
            fire = true;
        }
    }
    private void FixedUpdate()
    {
        if (fire)
        {
            projectile.velocity = transform.TransformDirection(Vector3.forward * power);
            fire = false;
            Destroy(projectile.gameObject, 3);
        }
    }
}