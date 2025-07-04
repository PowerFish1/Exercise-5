using UnityEngine;

public class Tetrahedron : Shape
{
    public override void DisplayText()
    {
        clickText.text = "I was made by Powerfish!";
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        // Additional Triangle-specific logic can go here
    }
} 