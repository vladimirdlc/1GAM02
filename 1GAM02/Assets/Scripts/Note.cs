using UnityEngine;
using System.Collections;

public class Note  {
    public KeyCode key { get; set; }
    public float timeAlive { get; set; }
    public bool isActive { get; set; }
    public bool isPressed { get; set; }

    public Note(KeyCode key, float seconds = 1.0f)
    {
        this.key = key;
        this.timeAlive = seconds;
        this.isActive = true;
    }

}
