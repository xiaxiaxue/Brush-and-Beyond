using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Material m;
    private Vector2 distorCenter;
     [Range(0,1)][SerializeField]
    private float distorValue;
   


    // Start is called before the first frame update
    void Start()
    {
        distorCenter = new Vector2(0.5f,0.5f);

        if (m == null)
            m = new Material(Shader.Find("xueer/MyShader"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onRenderImage(RenderTexture a, RenderTexture b)
    {
        if (m != null)
        {
            m.SetFloat("DistorValue", distorValue);
            m.SetVector("DistorCenter", distorCenter);


            Graphics. Blit(a,b,m);
        }
        else
        {
            Graphics. Blit(a,b);
        }

    }
}
