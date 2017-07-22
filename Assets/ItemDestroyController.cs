using UnityEngine;
using System.Collections;

public class ItemDestroyController : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}


	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find("Main Camera").transform.position.z - this.transform.position.z > 0) {
			Destroy (gameObject);
		}
	}


}

