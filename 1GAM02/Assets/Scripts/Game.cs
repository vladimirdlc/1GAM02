using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
    public GameObject note;

	// Use this for initialization
    IEnumerator Start()
    {
	     while (true) {
            yield return new WaitForSeconds(3);
            createNote();
        }
	}
	
	// Update is called once per frame
	void createNote () {
        Instantiate(note);
	}
}
