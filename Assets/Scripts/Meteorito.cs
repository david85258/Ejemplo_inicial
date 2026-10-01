using UnityEngine;

public class Meteorito : MonoBehaviour
{
    private float _vel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _vel = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * (_vel * Time.deltaTime));
        if (transform.position.z < Globales.LimiteZNegativo)
        {
            Destroy(gameObject);
        }
    }
}
