using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YRotationButtonsUIC : MonoBehaviour
{
    public CubeController controller;

    public void RotateYUpLeft()
    {
        controller.RequestRotation("Y", true, true);
    }

    public void RotateYDownLeft()
    {
        controller.RequestRotation("Y", true, false);
    }

    public void RotateYUpRight()
    {
        controller.RequestRotation("Y", false, true);
    }

    public void RotateYDownRight()
    {
        controller.RequestRotation("Y", false, false);
    }
}
