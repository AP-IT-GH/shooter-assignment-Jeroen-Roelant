using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class AirplaneController : MonoBehaviour
{
    private Rigidbody rb;
    private bool planeNotCrashed = true;
    public float rollRate = 26.0f;
    public float pitchRate = 20.0f;
    public float yawRate = 20.0f;
    private int acceleration = 300;
    public int maxSpeed;
    public int minSpeed;

    void Thrust(int i = 500)
    {
        rb.velocity = Vector3.zero;
        rb.AddRelativeForce(Vector3.forward * i);
        rb.AddRelativeForce(Vector3.up * 9.18f);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (planeNotCrashed == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (acceleration <= maxSpeed)
                {
                    acceleration += 50;
                }
                Thrust(acceleration);
            }
            else
            {
                if (acceleration >= minSpeed)
                {
                    acceleration -= 50;
                }
                Thrust(acceleration);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(pitchRate * -1.0f * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(pitchRate * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, yawRate * -1.0f * Time.deltaTime, .07f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, yawRate * Time.deltaTime, -.07f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(0, 0, rollRate * -1.0f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(0, 0, rollRate * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            //load the new level
            SceneManager.LoadScene("Scene1");
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        planeNotCrashed = false;
        
    }
}
