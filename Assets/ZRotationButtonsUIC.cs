using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZRotationButtonsUIC : MonoBehaviour
{
    public CubeController controller;

    public void RotateZUpLeft()
    {
        controller.RequestRotation("Z", true, true);
    }

    public void RotateZDownLeft()
    {
        controller.RequestRotation("Z", true, false);
    }

    public void RotateZUpRight()
    {
        controller.RequestRotation("Z", false, true);
    }

    public void RotateZDownRight()
    {
        controller.RequestRotation("Z", false, false);
    }
}
