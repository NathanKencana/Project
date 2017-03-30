using UnityEngine;
using System.Collections;

public class Kicku : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider obj_disentuh){
		if (obj_disentuh.transform.position.y<this.transform.position.y) {
			if (obj_disentuh.name=="Enemy") {
				Destroy (obj_disentuh.gameObject);
				GameObject.Find ("Hero").GetComponent<Rigidbody>().velocity = Vector3.up*3.5f;
			}

		}
	}
}
