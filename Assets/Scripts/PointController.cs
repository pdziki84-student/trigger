using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    private static int _points;   

    // Start is called before the first frame update
    void Start()
    {
        _points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("PointsCounter").GetComponent<Text>().text = _points.ToString();
    }

    public static void AddPoint() => AddPoints(1);

    public static void AddPoints(int points) => _points += points;
}
