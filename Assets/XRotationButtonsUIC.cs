using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRotationButtonsUIC : MonoBehaviour
{
    public CubeController controller;

    public void RotateXUpLeft()
    {
        controller.RequestRotation("X", true, true);
    }

    public void RotateXDownLeft()
    {
        controller.RequestRotation("X", true, false);
    }

    public void RotateXUpRight()
    {
        controller.RequestRotation("X", false, true);
    }

    public void RotateXDownRight()
    {
        controller.RequestRotation("X", false, false);
    }
}
