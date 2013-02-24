using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyHandler : MonoBehaviour {
 
    private static KeyHandler instance = null;
    private List<Note> keys;
    private Dictionary<KeyCode, AudioSource> sounds;

    public AudioSource soundA;

    public static KeyHandler Instance { 
        get {
            if (instance == null)
            {
                instance = GameObject.Find("KeyHandler").GetComponent<KeyHandler>();
            }
            return instance; 
        } 
    }

    void Awake()
    {
        keys = new List<Note>();
        sounds = new Dictionary<KeyCode, AudioSource>();
        sounds.Add(KeyCode.A, soundA);
    }

    void Update()
    {
        foreach(Note note in keys)
        {
            switch (note.key)
            {
                case KeyCode.A:
                case KeyCode.K:
                case KeyCode.H:
                    note.isActive = note.timeAlive > 0;
                    if (note.isActive)
                    {
                        if (Input.GetKeyDown(note.key))
                        {
                            //Debug.Log("isOk");
                            note.isPressed = true;
                        }
                    }
                    else
                    {
                        if (!note.isPressed)
                        {
                           // Debug.Log(note.key+"You suck");
                        }
                    }

                    if (Input.GetKeyDown(note.key))
                    {
                        sounds[note.key].audio.Play();
                    }

                    break;
            }

            note.timeAlive -= Time.deltaTime;
        }

        keys.RemoveAll(p => !p.isPressed && !p.isActive);
    }

    public void addKeyToTrack(Note note)
    {
        keys.Add(note);
    }
}