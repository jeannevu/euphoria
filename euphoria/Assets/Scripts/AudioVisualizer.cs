using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioVisualizer : MonoBehaviour {
		
	public Transform[] audioSpectrumObjects;

	/*
	 * The intensity of the frequencies found between 0 and 44100 will be
	 * grouped into 1024 elements. So each element will contain a range of about 43.06 Hz.
	 * The average human voice spans from about 60 hz to 9k Hz
	 * we need a way to assign a range to each object that gets animated. that would be the best way to control and modify animatoins.
	*/

	void Start(){


	}

	void Update() {

		for(int i = 0; i < audioSpectrumObjects.Length; i++)
		{

			audioSpectrumObjects[i].localScale = new Vector3(1,Random.Range(0, 3),1);

        }
	}

}
