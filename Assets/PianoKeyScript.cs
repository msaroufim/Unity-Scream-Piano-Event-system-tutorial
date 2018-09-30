using UnityEngine;
using System.Collections;

public class PianoKeyScript : MonoBehaviour {

    //public GameObject PianoManager;
   

    //this is only to set a type for the actual event. NumBerOfClicksUpdate is never actually called by anyone
    public delegate void NumberOfClicksUpdate();
    public static event NumberOfClicksUpdate OnNumberOfClicksUpdate;
    public float semitone_offset = 0;
	
	// Use this for initialization
	void Start () {
        var outputString = "Piano key instantiated";
        Debug.Log(outputString);
	}
	
	// Update is called once per frame
	//void Update () {

        //can do something like this instead of triggering an event
        //PianoManager.GetComponent<PianoManager>.numberOfClicks++;

    //}
	
	void OnMouseDown() {
        Debug.Log("MouseDown Found");
        if (OnNumberOfClicksUpdate != null)
        {
            OnNumberOfClicksUpdate();
            Debug.Log("OnNumberOfClicksUpdate was fired");
        }
        PlayNote();
    }
	
	void OnCollisionEnter() {
		PlayNote();
	}
	
	void PlayNote() {
        var audiosource = this.GetComponent<AudioSource>();
        audiosource.pitch = Mathf.Pow (2f, semitone_offset/12.0f);
        audiosource.Play ();
	}
}
