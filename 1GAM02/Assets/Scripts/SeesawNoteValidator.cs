using UnityEngine;
using System.Collections;

public class SeesawNoteValidator : NoteValidator {
    void OnTriggerStay(Collider other)
    {
        if (currentNote.GetComponent<MeshRenderer>().enabled)
        {
            if (Input.GetKeyDown(noteCode))
            {
                KeyHandler.Instance.playSound(noteCode);
                currentNote.GetComponent<MeshRenderer>().enabled = false;
                turnOff();
            }
        }
    }
}
