using UnityEngine;
using System.Collections;

public class RotateBoard : MonoBehaviour {

    public float rotateSpeed = 25;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //rotate game board
        transform.Rotate(0, Time.deltaTime * rotateSpeed, 0);
	}
}
