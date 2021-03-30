using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZRotationButtonsUIC : MonoBehaviour
{
    public CubeController controller;

    public void RotateZUpLeft()
    {
        controller.Rotate("Z", true, true);
    }

    public void RotateZDownLeft()
    {
        controller.Rotate("Z", true, false);
    }

    public void RotateZUpRight()
    {
        controller.Rotate("Z", false, true);
    }

    public void RotateZDownRight()
    {
        controller.Rotate("Z", false, false);
    }
}
