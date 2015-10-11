using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    public float timeConstant=2.0f;

    void Start() {

    }

	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.RightArrow))
        {
            //Vector3 position = this.transform.position;
            //position.x++;
            //this.transform.position = position;
            this.transform.Translate(Vector3.right*timeConstant*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Vector3 position = this.transform.position;
            //position.x--;
            //this.transform.position = position;
            this.transform.Translate(Vector3.left * timeConstant * Time.deltaTime);
        }
    }
}
