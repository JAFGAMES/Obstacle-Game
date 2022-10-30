using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed5 = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
			PrintInstructions(); //We are calling the method, here
    }

    // Update is called once per frame
    void Update()
    {
		MovePlayer();
    }


		void PrintInstructions () 

		{
			Debug.Log("Welcome to the game");
			Debug.Log("Move your player with the WASD or arrow keys");
			Debug.Log("Don't hit the walls");

		}
        

        void MovePlayer () 
        {
            float xValue = Input.GetAxis("Horizontal")* Time.deltaTime* moveSpeed5;
            float zValue = Input.GetAxis("Vertical")* Time.deltaTime* moveSpeed5;
            transform.Translate(xValue,0,zValue);
            //Debug.Log("The Value of xValue is " + xValue);
            //Debug.Log("The Value of zValue is " + zValue);
            //Debug.Log("The Value of Time.deltaTime is " + Time.deltaTime);
            //Debug.Log("The Value of moveSpeed5 is " + moveSpeed5);
        }


}