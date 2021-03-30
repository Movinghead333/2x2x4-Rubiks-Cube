using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    const int cubesSize = 16;
    public GameObject[] cubes = new GameObject[cubesSize];

    // Start is called before the first frame update
    void Start()
    {
    }

    public void RotateXPlus()
    {
        for (int i = 0; i < cubesSize; i++)
        {
            cubes[i].transform.RotateAround(transform.position, new Vector3(1, 0, 0), 90);
        }
    }

    public void Rotate(string axis, bool left, bool up)
    {
        Vector3 axisVector = Vector3.zero;
        int angle = 0;
        switch (axis)
        {
            case "X":
                axisVector = new Vector3(1, 0, 0);
                angle = up ? -90 : 90;
                break;
            case "Y":
                axisVector = new Vector3(0, 1, 0);
                angle = left ? 90 : -90;
                break;
            case "Z":
                axisVector = new Vector3(0, 0, 1);
                angle = up ? 90 : -90;
                break;
            default:
                throw new System.Exception("Invalid Axis");
        }

        for (int i = 0; i < cubesSize; i++)
        {
            switch(axis)
            {
                case "X":
                    if (left)  {
                        if (cubes[i].transform.position.x < 0) continue;
                    } else {
                        if (cubes[i].transform.position.x > 0) continue;
                    }
                    break;
                case "Y":
                    if (up) {
                        if (cubes[i].transform.position.y < 0) continue;
                    } else {
                        if (cubes[i].transform.position.y > 0) continue;
                    }
                    break;
                case "Z":
                    if (left) {
                        if (cubes[i].transform.position.z > 0) continue;
                    } else {
                        if (cubes[i].transform.position.z < 0) continue;
                    }
                    break;
            }
            
            cubes[i].transform.RotateAround(transform.position, axisVector, angle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
