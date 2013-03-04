using UnityEngine;
using System.Collections;

public class NoteValidator : MonoBehaviour {
    public Material onMaterial;
    public Material offMaterial;
	public Material errorMaterial;
	
    public KeyCode noteCode;
    protected GameObject currentNote;
    protected bool isFirstPress = true;

    protected void OnTriggerEnter(Collider other)
    {
        changeMaterial(onMaterial);

        currentNote = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
		if (other.gameObject == currentNote) 
		{
			turnOnError();
			currentNote = null;
		}
    }

    private void Update()
    {
        if (currentNote != null)
        {
            if (Input.GetKeyDown(noteCode))
            {
                Destroy(currentNote);
				KeyHandler.Instance.playSound(noteCode);
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

    protected void turnOff()
    {
        changeMaterial(offMaterial);
    }
	
	protected void turnOnError()
    {
        changeMaterial(errorMaterial);
    }
	
	protected void changeMaterial(Material mat)
	{
        foreach (MeshRenderer mesh in this.GetComponentsInChildren<MeshRenderer>())
            mesh.material = mat;
	}

}
