using UnityEngine;
using System.Collections;

public class MusicLine : MonoBehaviour {
    public GameObject roundNote;
    public float[] segs = { 1 };
	public bool isParent;
	private float currentTime;
	private float currentWait;
	private int i;

    void Start()
    {
        i = -1;
		currentWait = segs[0];
	}
	
	void Update()
	{
		if((currentTime += Time.deltaTime) > currentWait)
		{
			currentTime -= currentWait;
            i = ++i % segs.Length;
			currentWait = segs[i];
            createNote();
		}
	}
	
	// Update is called once per frame
	void createNote () {
        GameObject clone = Instantiate(roundNote) as GameObject;
		if(isParent)
		{
        	clone.transform.parent = this.transform;
			clone.transform.localScale = roundNote.transform.localScale;
		}
	}
}
