using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsLoader : MonoBehaviour
{
   // public Material MonetStep1;
   // public GameObject Brush;
    public int itemsCollectedStep1 = 0;
    public int itemsCollectedStep2 = 0;
    public GameObject Step2TriggerGroup;
    public GameObject CanvasPaintingStep1;
    public GameObject CanvasPaintingStep2;
    public GameObject Marker;
    public Material Step2;
    public Material Step3;



    void Start()
    {
        CanvasPaintingStep1.SetActive(false);
        CanvasPaintingStep2.SetActive(false);
        Step2TriggerGroup.SetActive(false);
    }


     void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "TriggerStep1")
        {
           itemsCollectedStep1 += 1;
           Destroy(other.gameObject);

           if (itemsCollectedStep1 >= 5)
            {
                UnlockStep2();
            }
        }

        else if (other.gameObject.tag == "TriggerStep2")
        {
           itemsCollectedStep2 += 1;
           Destroy(other.gameObject);

           if (itemsCollectedStep2 >= 5)
           {
            UnlockStep3();

           }
        }
    }

    void UnlockStep2()
    {
        CanvasPaintingStep1.SetActive(true);
        Step2TriggerGroup.SetActive(true);
        Debug.Log("Step2 unlocked! All items collected.");
        Marker.GetComponent<MeshRenderer> ().material = Step3;
    }

    void UnlockStep3()
    {
        CanvasPaintingStep2.SetActive(true);
        CanvasPaintingStep1.SetActive(false);
        Debug.Log("Step3 unlocked! All items collected.");
    }
}
