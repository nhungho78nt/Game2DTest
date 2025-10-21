using UnityEngine;

public class LineRendererExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));

        lineRenderer.startColor = Color.red;
        lineRenderer.endColor = Color.green;
        lineRenderer.startWidth = 0.5f;
        lineRenderer.endWidth = 0.2f;
        lineRenderer.positionCount = 3;

        lineRenderer.SetPosition(0, new Vector3(0, 0, 0));
        lineRenderer.SetPosition(1, new Vector3(1, 1, 0));
        lineRenderer.SetPosition(2, new Vector3(2, 0, 0));
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
