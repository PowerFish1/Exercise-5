using UnityEngine;

public class Sphere : Shape
{
    public override void DisplayText()
    {
        clickText.text = "We are MADED!";
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        // Additional Circle-specific logic can go here
    }
} 