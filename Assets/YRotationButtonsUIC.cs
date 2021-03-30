using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YRotationButtonsUIC : MonoBehaviour
{
    public CubeController controller;

    public void RotateYUpLeft()
    {
        controller.Rotate("Y", true, true);
    }

    public void RotateYDownLeft()
    {
        controller.Rotate("Y", true, false);
    }

    public void RotateYUpRight()
    {
        controller.Rotate("Y", false, true);
    }

    public void RotateYDownRight()
    {
        controller.Rotate("Y", false, false);
    }
}
