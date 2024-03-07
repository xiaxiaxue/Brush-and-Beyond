using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class LineController3D : MonoBehaviour
{
    public GameObject lineContainer;
    public float inputThreshold = 0.1f;
    public float amountOfInk;
    public int balls;
    private bool isDrawing = false;
    public List<Line> Lines;
    public GameObject linePrefab;
    public float lineTimeLimit = 100f;
    public float inkAmount = 0;
    private Line currentLine;

    private ActionBasedController rightHandController;

     void Awake()
    {
        Lines = new List<Line>();
        rightHandController = FindObjectOfType<ActionBasedController>(); 
        Debug.Log("RIGHT HAND CONTROLLER: " + rightHandController.name);
    }

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    void Update()
    {
       if (rightHandController != null)
    {
        HandleInput(rightHandController);
      //  Debug.Log("HanfelImput");
    }
    }

    private void HandleInput(ActionBasedController controller)
    {
        if (rightHandController)
        {
            Debug.Log("VALUE: " + rightHandController.activateAction.action.ReadValue<float>());

            if (rightHandController.activateAction.action.ReadValue<float>() > 0.1f && !isDrawing)
            {
            if (!isDrawing)
            {
                StartDrawing(controller.transform.position);
                isDrawing = true;
                Debug.Log("start Drawing");
            }
            else
            {
                UpdateDrawing(controller.transform.position);
                Debug.Log("Keep Drawing");
            }
        }
        else if (isDrawing)
        {
            EndDrawing();
            isDrawing = false;
            Debug.Log("End Drawing");
        }
    }
    }

    private void StartDrawing(Vector3 position)
    {
        GameObject newLineObj = Instantiate(linePrefab, position, Quaternion.identity);
        currentLine = newLineObj.GetComponent<Line>();
        Lines.Add(currentLine);
        currentLine.AddPoint(position);
    }

    private void UpdateDrawing(Vector3 position)
    {
        if (currentLine != null)
        {
            currentLine.AddPoint(position);
        }
    }

    private void EndDrawing()
    {
        currentLine = null;
    }

    public void GameOver(string message)
    {
        // Handle game over logic, potentially pausing game and showing a message
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
