using UnityEngine;
using System.Collections;

public class AnimasiScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis ("Horizontal");


		if(Input.GetKeyDown (KeyCode.UpArrow))
		{
			this.GetComponent<Animator> ().SetBool ("Jump",true);
		}
		else
		{
			this.GetComponent<Animator> ().SetBool ("Jump",false);
		}
		this.GetComponent<Animator> ().SetFloat ("Speed", v);
	}
}