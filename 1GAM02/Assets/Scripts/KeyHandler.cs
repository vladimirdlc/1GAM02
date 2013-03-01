using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyHandler : MonoBehaviour {
 
    private static KeyHandler instance = null;
    private List<Note> keys;
    private Dictionary<KeyCode, AudioSource> sounds;

    public AudioSource soundS;
    public AudioSource soundD;
    public AudioSource soundF;
    public AudioSource soundJ;
    public AudioSource soundK;
    public AudioSource soundL;

    public static KeyHandler Instance { 
        get {
            if (instance == null)
            {
                instance = GameObject.Find("KeyHandler").GetComponent<KeyHandler>();
            }
            return instance; 
        } 
    }

    public void playSound(KeyCode key)
    {
        sounds[key].Play();
    }

    void Awake()
    {
        keys = new List<Note>();
        sounds = new Dictionary<KeyCode, AudioSource>();
        sounds.Add(KeyCode.S, soundS);
        sounds.Add(KeyCode.D, soundD);
        sounds.Add(KeyCode.F, soundF);
        sounds.Add(KeyCode.J, soundJ);
        sounds.Add(KeyCode.K, soundK);
        sounds.Add(KeyCode.L, soundL);
    }

    public void addKeyToTrack(Note note)
    {
        keys.Add(note);
    }
}