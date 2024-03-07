using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line3D : MonoBehaviour
{
    private LineRenderer line;
    public List<Vector3> pointsList;
    public GameObject pointPrefab; // Prefab with a BoxCollider component

    //The First and Second Color for the line gradient
    public Color color1 = new Color(0.97f, 0.23f, 0.98f, 1.00f);
    public Color color2 = new Color(0.21f, 0.86f, 0.86f, 1.00f);
    public float fadeInTime = 3f;
    public float fadeOutTime = 3f;
    public Material material;

    void Awake ()
    {
        line = gameObject.AddComponent<LineRenderer> ();
        line.material = material;

        line.positionCount = 0;
        line.startWidth = 0.1f;
        line.endWidth = 0.15f;
        line.startColor = Color.white;
        line.endColor = Color.white;
        line.useWorldSpace = true;    
        pointsList = new List<Vector3> ();
        line.positionCount = 0;
    }

    public void AddPoint(Vector3 pointPosition) {
        pointsList.Add(pointPosition);
        line.positionCount = pointsList.Count;
        line.SetPosition(pointsList.Count - 1, pointPosition);
        if(pointsList.Count > 1) {
            GameObject pointObject = Instantiate(pointPrefab, pointPosition, Quaternion.identity);
            pointObject.transform.parent = transform;

            Vector3 direction = pointsList[pointsList.Count - 1] - pointsList[pointsList.Count - 2];
            float distance = direction.magnitude;
            pointObject.transform.position = pointsList[pointsList.Count - 2] + (direction / 2);
            pointObject.transform.LookAt(pointsList[pointsList.Count - 2]);
            pointObject.transform.localScale = new Vector3(0.05f, 0.05f, distance); // Adjust scale to match the line segment length
            pointObject.GetComponent<BoxCollider>().size = new Vector3(1, 1, distance / pointObject.transform.localScale.z); // Adjust collider size
        }
    }
}
