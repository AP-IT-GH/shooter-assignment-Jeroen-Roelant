using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    public GameObject mainCanvas;
    public Text scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter()
    {
            Destroy(transform.gameObject);
            scoreCounter.text = (int.Parse(scoreCounter.text) + 1).ToString();
    }
}
