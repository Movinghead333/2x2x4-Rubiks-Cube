using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    const int cubesSize = 16;
    public GameObject[] cubes = new GameObject[cubesSize];

    Vector3 axisVector;
    int angle;
    bool up;
    bool left;
    string axis;

    // store if the is a rotation currently being executed
    bool isRotating;
    int currentStep = 0;

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

    public void RequestRotation(string axis, bool left, bool up)
    {
        if (isRotating)
        {
            return;
        }
        else
        {
            isRotating = true;
        }
        this.axisVector = Vector3.zero;
        this.angle = 0;
        this.axis = axis;
        this.up = up;
        this.left = left;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (currentStep < 90 && isRotating)
        {
            currentStep++;
        } 
        else
        {
            currentStep = 0;
            isRotating = false;
            return;
        }

        for (int i = 0; i < cubesSize; i++)
        {
            switch (axis)
            {
                case "X":
                    if (left)
                    {
                        if (cubes[i].transform.position.x < 0) continue;
                    }
                    else
                    {
                        if (cubes[i].transform.position.x > 0) continue;
                    }
                    break;
                case "Y":
                    if (up)
                    {
                        if (cubes[i].transform.position.y < 0) continue;
                    }
                    else
                    {
                        if (cubes[i].transform.position.y > 0) continue;
                    }
                    break;
                case "Z":
                    if (left)
                    {
                        if (cubes[i].transform.position.z > 0) continue;
                    }
                    else
                    {
                        if (cubes[i].transform.position.z < 0) continue;
                    }
                    break;
            }

            cubes[i].transform.RotateAround(transform.position, axisVector, angle / 90);
        }
    }
}
