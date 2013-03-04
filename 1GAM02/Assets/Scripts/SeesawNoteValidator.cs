using UnityEngine;
using System.Collections;

public class SeesawNoteValidator : NoteValidator {
	
    private void Update()
    {
        if ((currentNote != null) && currentNote.GetComponent<MeshRenderer>().enabled)
        {
            if (Input.GetKeyDown(noteCode))
            {
                KeyHandler.Instance.playSound(noteCode);
                currentNote.GetComponent<MeshRenderer>().enabled = false;
                GameLogic.hitCount++;
                if (isFirstPress)
                {
                    GameLogic.differentHitCount++;
                    isFirstPress = false;
                }
                turnOff();
            }
        }
        else
        {
            if (Input.GetKeyDown(noteCode))
            {
                turnOnError();
            }
        }
    }
	
	private void OnTriggerExit(Collider other)
    {
        turnOff();
        currentNote.GetComponent<MeshRenderer>().enabled = true;
		currentNote = null;
    }
}
