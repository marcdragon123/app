using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector3.up, ForceMode2D.Impulse);
        }
	}
}
