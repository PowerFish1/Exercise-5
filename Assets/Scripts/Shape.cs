using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private string shapeName;
    [SerializeField] private Color shapeColor;
    [SerializeField] private Vector3 rotationSpeed = Vector3.zero;
    [SerializeField] protected TextMeshProUGUI clickText;

    public string Name
    {
        get { return shapeName; }
        set { if (!string.IsNullOrEmpty(value) && value.Length < 15) shapeName = value; }
    }

    public Color ShapeColor
    {
        get { return shapeColor; }
        set { shapeColor = value; }
    }

    public Vector3 RotationSpeed
    {
        get { return rotationSpeed; }
        set { rotationSpeed = value; }
    }

    // Abstract method for displaying text
    public abstract void DisplayText();

    // Virtual method for click handling
    public virtual void OnMouseDown()
    {
        DisplayText();
    }

    protected virtual void Update()
    {
        if (rotationSpeed != Vector3.zero)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}