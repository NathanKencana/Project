using UnityEngine;
using System.Collections;

public class Panch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider obj_disentuh){
		if (obj_disentuh.transform.position.y>this.transform.position.y) {
			if (obj_disentuh.name=="Cube") {
				StartCoroutine(Example(obj_disentuh));
			}
			if (obj_disentuh.name=="item_box") {
				Instantiate(GameObject.Find ("powerup"), new Vector3(obj_disentuh.transform.position.x,obj_disentuh.transform.position.y+1,obj_disentuh.transform.position.z), obj_disentuh.transform.rotation);
			}
			if (obj_disentuh.name== "item_box") {
				Instantiate(GameObject.Find ("Coin"), new Vector3(obj_disentuh.transform.position.x,obj_disentuh.transform.position.y+1,obj_disentuh.transform.position.z), obj_disentuh.transform.rotation);
			}

				}

	}
	IEnumerator Example(Collider obj_disentuh) {
		yield return new WaitForSeconds(0.5f);
		Destroy (obj_disentuh.gameObject);
}
}


