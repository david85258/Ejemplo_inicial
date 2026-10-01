using UnityEngine;
using UnityEngine.InputSystem;

public class NaveJugador : MonoBehaviour
{
    private float _vel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _vel = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
        ControlLimitesPantalla();
    }

    void ControlLimitesPantalla()
    {
        Vector3 posicionActual = transform.position;
        
        posicionActual.x = Mathf.Clamp(posicionActual.x, Globales.LimiteIzquierdoX, Globales.LimiteDerechoX);
        posicionActual.y = Mathf.Clamp(posicionActual.y, Globales.LimiteInferiorY, Globales.LimiteSuperiorY);
        
        transform.position = posicionActual;
    }

    void MovimientoJugador()
    {
        float movimientoHorizontal = Keyboard.current.aKey.isPressed ? -1 : Keyboard.current.dKey.isPressed ? 1 : 0f;
        float movimientoVertical = Keyboard.current.sKey.isPressed ? -1 : Keyboard.current.wKey.isPressed ? 1 : 0f;
        
        Vector3 vectorDesplazamiento = new Vector3(movimientoHorizontal, movimientoVertical);
        vectorDesplazamiento = vectorDesplazamiento.normalized;
        
        Vector3 nuevoDesplazamiento = new Vector3(
            _vel * vectorDesplazamiento.x * Time.deltaTime, 
            _vel * vectorDesplazamiento.y * Time.deltaTime
        );
        
        transform.position += nuevoDesplazamiento;
    }
}
