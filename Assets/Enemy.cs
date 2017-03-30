using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody> ().MovePosition (new Vector3 (this.transform.position.x - 0.05f,this.transform.position.y,this.transform.position.z));
		}

	}

