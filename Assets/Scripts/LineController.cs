using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineController : MonoBehaviour
{
    public GameObject lineContainer;
	//public Tutor tutor;
	//public EndlessLevel level;
	public float amountOfInk;
	public int balls;
	private int dragCount;
	private bool finished;
	private bool tutored;
    private bool endOfInk = false;
	private Vector3 lastMouseCoordinate = Vector3.zero;
	private bool isMousePressed;
	public List<Line> Lines;
	public GameObject line;
    public float lineTimeLimit = 100f;
    public Text inkLeft;
    public float inkAmount = 0;
    public GameObject inkJar;
    public GameObject goButton;

	private Vector3 mousePos;

	struct myLine {
		public Vector3 StartPoint;
		public Vector3 EndPoint;
	};

	void Awake () {
		isMousePressed = false;
		Lines = new List<Line>();
	}

	// Use this for initialization
	void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        finished = false;
		tutored = false;
		Input.simulateMouseWithTouches = true;
	}
				
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver(string message) {		
		finished = true;
        //level.grid.currentSet.Waiting();
       // level.LevelFailPanel.SetActive (true);
       // level.failureMessage.text = message;
        //		ProcGenMusic.MusicGenerator.Instance.Stop ();
        endOfInk = false;
    }
    public void Pause()
    {
        Time.timeScale = 0f;    
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
    }
}
