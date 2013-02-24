using UnityEngine;
using System.Collections;

public class FallingBar : MonoBehaviour {
    public GameObject note;

	// Use this for initialization
    IEnumerator Start()
    {
        float[] segs = { 0.3f, 0.9f, 0.9f };
        int i = -1;

	     while (true) {
            i = ++i % segs.Length;
            yield return new WaitForSeconds(segs[i]);
            createNote();
        }
	}
	
	// Update is called once per frame
	void createNote () {
        Instantiate(note);
	}
}
