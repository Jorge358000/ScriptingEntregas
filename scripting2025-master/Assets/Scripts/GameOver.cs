using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.CorgiEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverScreen; // Fondo de Game Over
    private Health playerHealth;
    private bool isGameOver; // Para controlar si el jugador ha muerto

    private void Start()
    {
        gameOverScreen.SetActive(false); // No mostrar al iniciar
        Invoke("FindPlayer", 0.5f); // Buscar al jugador tras el spawn
    }

    private void Update()
    {
        if (isGameOver && Input.GetMouseButtonDown(0)) // Click izquierdo para reiniciar
        {
            RestartLevel();
        }
    }

    private void FindPlayer()
    {
        var player = LevelManager.Instance.Players[0].gameObject;

        if (player != null)
        {
            playerHealth = player.GetComponent<Health>();
        }

        if (playerHealth == null)
        {
            Debug.LogError("No se encontró el componente 'Health' en el jugador.");
            return;
        }

        playerHealth.OnDeath += OnPlayerDeath;
    }

    private void OnPlayerDeath()
    {
        Invoke("ShowGameOverScreen", 1f); // Esperar 1 segundo antes de mostrar el Game Over
    }

    private void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f; // Pausar el juego
        isGameOver = true; // Permitir reiniciar al hacer click
        Debug.Log("El jugador ha muerto. Game Over.");
    }

    private void RestartLevel()
    {
        Time.timeScale = 1f; // Reanudar el tiempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recargar la escena actual
    }
}
