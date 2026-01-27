using UnityEngine;

public class PararCarro : MonoBehaviour
{
    public Carro carro;
    public float anguloMaximo = 90f;

    void Update()
    {
        float angulo = transform.eulerAngles.z;

        // Normaliza o ângulo para -180 a 180
        if (angulo > 180)
            angulo -= 360;

        carro.capotado = Mathf.Abs(angulo) > anguloMaximo;
    }
}
