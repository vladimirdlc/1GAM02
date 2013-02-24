using UnityEngine;
using System.Collections;

public class NoteValidator : MonoBehaviour {
    public Material onMaterial;
    public Material offMaterial;
    private GameObject currentNote;

    void OnTriggerEnter(Collider other)
    {
        foreach(MeshRenderer mesh in this.GetComponentsInChildren<MeshRenderer>())
         mesh.material = onMaterial;

        currentNote = other.gameObject;
    }

    void OnTriggerExit(Collider other)
    {
        foreach (MeshRenderer mesh in this.GetComponentsInChildren<MeshRenderer>())
            mesh.material = offMaterial;

        currentNote = null;
    }

    void OnTriggerStay(Collider other)
    {
        if (currentNote != null)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                KeyHandler.Instance.playSound(KeyCode.A);
                Destroy(currentNote);
            }
        }
        else
        {
        }
    }

}
