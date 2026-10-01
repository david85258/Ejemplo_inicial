using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class GeneradorMeteoritos : MonoBehaviour
{
    public GameObject meteoritoPrefab;

    void Start()
    {
        InvokeRepeating("GeneraMeteorito", 1f, 0.5f);
    }
    
    private void GeneraMeteorito()
    {
        GameObject meteoritoGenerado = Instantiate(meteoritoPrefab);
        meteoritoGenerado.transform.position = new Vector3(
            Random.Range(Globales.LimiteIzquierdoX, Globales.LimiteDerechoX),
            Random.Range(Globales.LimiteInferiorY, Globales.LimiteSuperiorY),
            Globales.LimiteZPositivo
        );
    }
}
