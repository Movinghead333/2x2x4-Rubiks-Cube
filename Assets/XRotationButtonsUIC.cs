using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRotationButtonsUIC : MonoBehaviour
{
    public CubeController controller;

    public void RotateXUpLeft()
    {
        controller.Rotate("X", true, true);
    }

    public void RotateXDownLeft()
    {
        controller.Rotate("X", true, false);
    }

    public void RotateXUpRight()
    {
        controller.Rotate("X", false, true);
    }

    public void RotateXDownRight()
    {
        controller.Rotate("X", false, false);
    }
}
