using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    public Transform target;
    public int speed;
    public string axis;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (axis == "Z")
        {
            transform.RotateAround(target.transform.position, target.transform.forward, speed * Time.deltaTime);
        }
        else if (axis == "X")
        {
            transform.RotateAround(target.transform.position, target.transform.right, speed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
        }
    }
}
