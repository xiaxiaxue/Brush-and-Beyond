using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushChangeMaterials : MonoBehaviour
{
    public Material PurpleBrush;
    public Material BlackBrush;
    public Material MonetStep1;
    public AudioSource BlackAudio;
    public AudioSource PurpleAudio;
    public GameObject Brush;
    public GameObject Canvas;

   // public Material YellowBrush;
   // public Material OrangeBrush;
   // public Material RedBrush;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Black")
        {
            var Blackrenderer = Brush.GetComponent<MeshRenderer>();
            Material[] Blackmaterials = Blackrenderer.sharedMaterials;
            Blackmaterials[1] = BlackBrush;
            Blackrenderer.sharedMaterials = Blackmaterials;
            BlackAudio.Play();
            Debug.Log("ChangeMaterialBlack");
        }

        if (other.gameObject.name == "Purple")
        {
            var Purplerenderer = Brush.GetComponent<MeshRenderer>();
            Material[] Purplematerials = Purplerenderer.sharedMaterials;
            Purplematerials[1] = PurpleBrush;
            Purplerenderer.sharedMaterials = Purplematerials;
            PurpleAudio.Play();
            Debug.Log("ChangeMaterialPurple");
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}


