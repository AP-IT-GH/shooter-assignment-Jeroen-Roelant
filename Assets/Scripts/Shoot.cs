using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject projectile;
   
    // Use this for initialization
    void Start () {
       
    }

    // Update is called once per frame
    float timer = 10f;
    bool start = false;
    public int speed = 3000;
    public float shootRate = 10f;
    void Update () {
        float shoot = Input.GetAxis("Fire1");

        if (shoot == 1 && timer >= shootRate)
        {
            GameObject newProjectile = Instantiate(projectile, transform.position+transform.forward,transform.rotation);
            newProjectile.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
            start = true;
            timer = 0f;
        }

        if (start)
        {
            if (timer< shootRate)
                timer += Time.deltaTime;
            else
            {
                timer = shootRate;
                start = false;
            }
        }
    }
}