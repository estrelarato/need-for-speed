using UnityEngine;

public class Carro : MonoBehaviour
{
    public float velocidadeMaxima = 10f;
    public ConstantForce2D forca;

    public bool capotado = false;

    void Awake()
    {
        if (forca == null)
            forca = GetComponent<ConstantForce2D>();
    }

    void FixedUpdate()
    {
        if (capotado)
        {
            forca.force = Vector2.zero;
            return;
        }

        // ➡️ acelera pra direita
        if (Input.GetKey(KeyCode.RightArrow))
        {
            forca.force = Vector2.right * velocidadeMaxima;
        }
        // ⬅️ acelera pra esquerda (freia se vinha da direita)
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            forca.force = Vector2.left * velocidadeMaxima;
        }
        // nenhuma seta pressionada
        else
        {
            forca.force = Vector2.zero;
        }
    }
}
