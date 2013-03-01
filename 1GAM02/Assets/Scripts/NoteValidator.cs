using UnityEngine;
using System.Collections;

public class NoteValidator : MonoBehaviour {
    public Material onMaterial;
    public Material offMaterial;
    public KeyCode noteCode;
    protected GameObject currentNote;

    protected void OnTriggerEnter(Collider other)
    {
        foreach(MeshRenderer mesh in this.GetComponentsInChildren<MeshRenderer>())
         mesh.material = onMaterial;

        currentNote = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
		
        
        //currentNote.GetComponent<MeshRenderer>().enabled = true;
		if (other.gameObject == currentNote) 
		{
			turnOff();
			currentNote = null;
		}
    }

    private void Update()
    {
        if (currentNote != null)
        {
            if (Input.GetKeyDown(noteCode))
            {
                KeyHandler.Instance.playSound(noteCode);
                Destroy(currentNote);
                turnOff();
            }
        }
        else
        {
        }
    }

    protected void turnOff()
    {
        foreach (MeshRenderer mesh in this.GetComponentsInChildren<MeshRenderer>())
            mesh.material = offMaterial;
    }

}
