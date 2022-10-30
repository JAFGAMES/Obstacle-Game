using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float WaitTime = 5f;
    float ShownTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > WaitTime)
        {
            if (ShownTime == 0f)
            {
                Debug.Log (WaitTime + " Seconds has elapsed");
                ShownTime = 1f;
                GetComponent<Renderer>().enabled = true;
                GetComponent<Rigidbody>().useGravity = true;
            }


        }
    }
}
