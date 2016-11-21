using UnityEngine;
using System.Collections;

public class AccessCard : MonoBehaviour {

	public GameObject Img;

	void Start () {
	
	}
	
	// Update is called once per frame
	


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.collider.tag == "Player") {
			Img.SetActive (true);
			Destroy (gameObject);
		}
	}
}
