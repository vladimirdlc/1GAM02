using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {
    public static int hitCount;
    public static int differentHitCount;

    public GameObject fallingBar;
    public GameObject tetragram;
    public ParticleSystem particles;

	// Use this for initialization
	void Start () {
        fallingBar.SetActive(false);
        tetragram.SetActive(false);
        particles.startSize = 0;
	}
	
	// Update is called once per frame
	void Update () {
        /*if (hitCount > 22)
        {
            particles.startSize = (hitCount - 21) / 100f;
        }
        else if (hitCount > 18 && differentHitCount >= 5)
        {
            particles.startSize = 0.1f;
        }
        else */if (hitCount > 12 && differentHitCount >= 3)
        {
            tetragram.SetActive(true);
        }
        else if (hitCount > 3 && differentHitCount >= 2)
        {
            fallingBar.SetActive(true);
        }

        particles.startSize = hitCount / 100f;

	}
}
