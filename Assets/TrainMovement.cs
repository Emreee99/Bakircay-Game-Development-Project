using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public float speed = 5f;
    public float radius = 10f;

    private Vector3 _center;
    private float _angle;

    void Start()
    {
        _center = transform.position;
    }

    void Update()
    {
        _angle += speed * Time.deltaTime;
        var offset = new Vector3(- Mathf.Sin(_angle), 0,  - Mathf.Cos(_angle)) * radius;
        transform.position = _center + offset;
        transform.Rotate(0, Mathf.Cos(_angle) * speed * Time.deltaTime * 40, 0);
    }
}


