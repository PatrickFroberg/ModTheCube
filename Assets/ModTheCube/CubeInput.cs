using UnityEngine;

[RequireComponent(typeof(CubeController), typeof(ColorLoop), typeof(CubeRotator))]
public class CubeInput : MonoBehaviour
{
    private CubeController _cubeController;
    private ColorLoop _colorLoop;
    private CubeRotator _cubeRotator;

    void Start()
    {
        _cubeController = GetComponent<CubeController>();
        _cubeRotator = GetComponent<CubeRotator>();
        _colorLoop = GetComponent<ColorLoop>();   
    }
    
    void Update()
    {
        CheckInput();  
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            _cubeRotator.SwingX();

        else if (Input.GetKeyDown(KeyCode.Alpha2))
            _cubeRotator.SwingY();

        else if (Input.GetKeyDown(KeyCode.Alpha3))
            _cubeRotator.SwingZ();

        else if (Input.GetKeyDown(KeyCode.Alpha4))
            _cubeController.Grow();

        else if (Input.GetKeyDown(KeyCode.Alpha5))
            _cubeController.Shrink();

        else if (Input.GetKeyDown(KeyCode.Alpha6))
            _cubeRotator.SpeedUpRotation();

        else if (Input.GetKeyDown(KeyCode.Alpha7))
            _cubeRotator.SlowDownRotation();

        else if (Input.GetKeyDown(KeyCode.Alpha8))
            _colorLoop.ToggleMaterialTransparent();

        else if (Input.GetKeyDown(KeyCode.D))
            _cubeController.MoveX(1f);

        else if (Input.GetKeyDown(KeyCode.A))
            _cubeController.MoveX(-1f);

        else if (Input.GetKeyDown(KeyCode.W))
            _cubeController.MoveY(1f);

        else if (Input.GetKeyDown(KeyCode.S))
            _cubeController.MoveY(-1f);
    }
}
