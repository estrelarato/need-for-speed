using UnityEngine;

public class Trampolim : MonoBehaviour
{
    public float forcaDoPulo = 15f;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se quem encostou � o jogador
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Zera a velocidade vertical antes de aplicar a for�a
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

                // Aplica a for�a pra cima
                rb.AddForce(Vector3.up * forcaDoPulo, ForceMode.Impulse);
            }
        }
    }
}
