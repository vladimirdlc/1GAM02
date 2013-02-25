using UnityEngine;
using System.Collections;

public class SeesawNoteValidator : MonoBehaviour {
    public Material onMaterial;
    public Material offMaterial;
    public KeyCode noteCode;
    public GameObject currentNote;

    void OnTriggerEnter(Collider other)
    {
        foreach(MeshRenderer mesh in this.GetComponentsInChildren<MeshRenderer>())
         mesh.material = onMaterial;
    }

    void OnTriggerExit(Collider other)
    {
        foreach (MeshRenderer mesh in this.GetComponentsInChildren<MeshRenderer>())
            mesh.material = offMaterial;

        currentNote.GetComponent<MeshRenderer>().enabled = true;
    }

    void OnTriggerStay(Collider other)
    {
        if (currentNote.GetComponent<MeshRenderer>().enabled)
        {
            if (Input.GetKeyDown(noteCode))
            {
                KeyHandler.Instance.playSound(noteCode);
                currentNote.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }

}
