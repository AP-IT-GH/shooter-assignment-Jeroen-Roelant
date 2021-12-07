using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject Explosion;
    private bool collided = false;
    float timer = 0;
    public float lifeTime = 10f;
    // Use this for initialization
    void Start () {
    }
	
    // Update is called once per frame
    void Update () {
        if (collided)
        {
            Destroy(gameObject);
        }
        if (timer < lifeTime)
            timer += Time.deltaTime;
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        collided = true;
    }
}