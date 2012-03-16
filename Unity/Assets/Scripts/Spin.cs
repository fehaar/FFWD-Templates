using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	public float speed = 45;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0)); 	
	}
	
}
