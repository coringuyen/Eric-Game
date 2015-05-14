using UnityEngine;
using System.Collections;
    


public class RandomMovement : MonoBehaviour {


	void Update () 
    {
        // move forward by z axis
        transform.Translate(Vector3.forward * Time.deltaTime);
        // rotate randomly by y axis
        transform.Rotate(new Vector3(0.0f, Random.Range(-200, 200), 0.0f) * Time.deltaTime);
	}
}
