using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float ModifierValue = 1.3f;

    [SerializeField] private float _boundary = 2f;

    private void Start()
    {
        transform.position = Vector3.zero;
        transform.localScale = Vector3.one * ModifierValue;
    }

    public void MoveX(float f)
    {
        var xPos = transform.position.x + f;

        transform.position = new Vector3(
            Mathf.Clamp(xPos, -_boundary, _boundary),
            transform.position.y,
            transform.position.z
            );
    }

    public void MoveY(float f)
    {
        var yPos = transform.position.y + f;

        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(yPos, -_boundary, _boundary),
            transform.position.z
            );
    }

    public void Grow()
    {
        transform.localScale *= ModifierValue;
    }

    public void Shrink()
    {
        transform.localScale /= ModifierValue;
    }
}