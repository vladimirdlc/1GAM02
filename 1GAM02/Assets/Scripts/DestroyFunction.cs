using UnityEngine;
using System.Collections;

public class DestroyFunction : MonoBehaviour {
	
	// Update is called once per frame
	void Destroy () {
        Destroy(this.gameObject);
	}
}
