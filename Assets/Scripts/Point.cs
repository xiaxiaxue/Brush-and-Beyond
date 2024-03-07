using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hit(float vel) {
		if(!GetComponent<AudioSource>().isPlaying) {
//			float p = transform.position.y + 4;
//			float v = Mathf.Clamp(vel, 0, .75f);
//			GetComponent<AudioSource>().pitch = Mathf.Clamp(p, -1, 3);
//			GetComponent<AudioSource>().volume = v;
//			GetComponent<AudioSource>().Play();
		}
}
}
