using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	private float speed = 20f;

    private void Update() {
        transform.Rotate(Vector3.one * speed * Time.deltaTime);
		
		
    
		
	}
	
	
}
