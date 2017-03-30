using UnityEngine;
using System.Collections;

public class Char : MonoBehaviour {
	float speed = 7.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
//		float v = Input.GetAxis ("Vertical");
		
		this.transform.Translate (new Vector3 (h*3.5f, 0, 0) * Time.deltaTime);
//		Debug.Log (this.GetComponent<Rigidbody> ().velocity);
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//			this.GetComponent<Rigidbody>().AddForce(new Vector3(0,500,0));
			if (this.GetComponent<Rigidbody>().velocity == new Vector3(0,0,0)){
			this.GetComponent<Rigidbody>().velocity = Vector3.up*8.5f;
				
			}
		}
	}

	}

