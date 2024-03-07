using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsForWhiteBoard : MonoBehaviour
{
    public GameObject WhiteBoard;
    public Material Paintable;
    public Material Step1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Trigger")
        {
           WhiteBoard.GetComponent<MeshRenderer> ().material = Step1;
        }

         if (other.gameObject.tag == "BACK")
        {
           WhiteBoard.GetComponent<MeshRenderer> ().material = Paintable;
        }

    
    }
}
