using System;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public float RotationSpeed = 10.0f;
    public float ModifierValue = 1.3f;

    [SerializeField] private SwingDirection _swingDirection;

    void Start()
    {
        _swingDirection = SwingDirection.X;
    }

    void Update()
    {
        Swing();
    }


    public void SwingX()
    {
        _swingDirection = SwingDirection.X;
    }

    public void SwingY()
    {
        _swingDirection = SwingDirection.Y;
    }

    public void SwingZ()
    {
        _swingDirection = SwingDirection.Z;
    }

    public void SpeedUpRotation()
    {
        RotationSpeed *= ModifierValue;
    }

    public void SlowDownRotation()
    {
        RotationSpeed /= ModifierValue;
    }


    private void Swing()
    {
        var speed = RotationSpeed * Time.deltaTime;

        if (_swingDirection == SwingDirection.X)
            transform.Rotate(speed, 0.0f, 0.0f);

        else if (_swingDirection == SwingDirection.Y)
            transform.Rotate(0.0f, speed, 0.0f);

        else if (_swingDirection == SwingDirection.Z)
            transform.Rotate(0.0f, 0.0f, speed);
    }
        

    private enum SwingDirection
    {
        X, Y, Z
    }
}
