using UnityEngine;

public class Cube : Shape
{
    public override void DisplayText()
    {
        clickText.text = "Who I was maded by?";
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        // Additional Square-specific logic can go here
    }
} 