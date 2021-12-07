using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // public Transform target;
    // public Vector3 target_Offset;
    // private void Start()
    // {
    //     target_Offset = transform.position - target.position;
    // }
    // void Update()
    // {
    //     if (target)
    //     {
    //         transform.position = Vector3.Lerp(transform.position, target.position+target_Offset, 1f);
    //     }
    // }
    
    public Transform target;
    public Vector3 target_Offset;
    public GameObject player;
    public float cameraDistance = 10.0f;
    
    // Use this for initialization
    void Start () {
    }
    
    void FixedUpdate ()
    {
        transform.position = Vector3.Lerp(transform.position, target.position+target_Offset, 1f);
        transform.position = player.transform.position - player.transform.forward * cameraDistance;
        transform.LookAt (player.transform.position);
    }
}
