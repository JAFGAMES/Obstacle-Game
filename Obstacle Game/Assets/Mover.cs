using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float xValue = 1000f;
    public float yValue = 0.5f;
    public float zValue = 1000f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //public float xValue = 0f;
        //public float yValue = 0f;
        transform.Translate(xValue, 0, zValue);
    }
}