using UnityEngine;
using System.Collections;

public class NoteAction : MonoBehaviour {
    public bool startH;
    public bool startK;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

    void playNote(KeyCode key)
    {
        KeyHandler.Instance.addKeyToTrack(new Note(key));
    }
}
