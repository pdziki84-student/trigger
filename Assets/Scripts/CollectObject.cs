using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    private Color defaultColor;

    public GameObject Light;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = Light.GetComponent<Light>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.GetComponent<Collider>().CompareTag("cube"))
        {
            ChangeLight();
            Destroy(other.gameObject);
            PointController.AddPoint();
        }
    }

    private void ChangeLight()
    {
        if (Light.GetComponent<Light>().color == defaultColor)
            Light.GetComponent<Light>().color = Color.red;
        else
            Light.GetComponent<Light>().color = defaultColor;
    }
}
