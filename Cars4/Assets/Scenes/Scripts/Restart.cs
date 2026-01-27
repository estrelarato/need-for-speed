using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Carro carro;
    public float tempoParaReiniciar = 10f;

    private float contador = 0f;

    void Update()
    {
        if (carro.capotado)
        {
            contador += Time.deltaTime;

            if (contador >= tempoParaReiniciar)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else
        {
            contador = 0f;
        }
    }
}

