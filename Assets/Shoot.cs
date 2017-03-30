using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("shoot", 3, 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void shoot(){
		this.transform.position =new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
		Instantiate (GameObject.Find("Projectile"), this.transform.position, this.transform.rotation);

	}
	void OnTriggerEnter(Collider obj_disentuh){
		
		if (obj_disentuh.name=="Hero") {
			Application.LoadLevel("GameOver");
		}
		
		
	}
}
