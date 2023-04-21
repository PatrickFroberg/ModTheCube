using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorLoop : MonoBehaviour
{
    public float Speed = 0.4f;

    [SerializeField] private bool _isTransparent;
    
    private Material _material;
    private float _time = 0.0f;

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;

        _isTransparent = false;
        _material.color = Red();
    }

    void Update()
    {
        _time += Time.deltaTime * Speed;
        Color currentColor = Color.Lerp(Red(), Blue(), Mathf.PingPong(_time, 1.0f));

        GetComponent<Renderer>().material.color = currentColor;
    }

    public void ToggleMaterialTransparent()
    {
        _isTransparent = !_isTransparent;

        if (_isTransparent)
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, 0.3f);
        else
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, 1f);
    }

    private Color Red()
    {
        return new Color(1, 0, 0, _material.color.a);
    }

    private Color Blue()
    {
        return new Color(0, 0, 1, _material.color.a);
    }
}
