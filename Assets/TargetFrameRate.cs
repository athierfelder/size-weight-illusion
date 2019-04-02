using System.Collections;
using UnityEngine;

public class TargetFrameRate : MonoBehaviour {

    public int targetRate = 90;

	// Use this for initialization
	void Start () {
        QualitySettings.vSyncCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (targetRate != Application.targetFrameRate)
        {
            Application.targetFrameRate = targetRate;
        }
	}
}
