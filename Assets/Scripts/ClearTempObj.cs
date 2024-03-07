using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTempObj : MonoBehaviour
{
    public Camera temporaryObjectsCamera;
    public float delay = 2f;

    void Start()
    {
        if (temporaryObjectsCamera != null)
        {
            // Start the coroutine to disable the temporary objects camera
            StartCoroutine(DisableTemporaryObjectsCameraAfterDelay());
        }
    }

    IEnumerator DisableTemporaryObjectsCameraAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Disable the camera that renders the temporary objects
        temporaryObjectsCamera.cullingMask = 0;
    }
}
