using UnityEngine;
using System.Collections;

public class NoteAction : MonoBehaviour {
    public bool startH;
    public bool startK;

    void playNote(KeyCode key)
    {
        KeyHandler.Instance.addKeyToTrack(new Note(key));
    }
}
