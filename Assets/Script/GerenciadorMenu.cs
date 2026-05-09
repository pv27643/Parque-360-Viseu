using UnityEngine;
using UnityEngine.SceneManagement; // Esta linha é obrigatória para mudar de cena!

public class GerenciadorMenu : MonoBehaviour
{
    // Esta função vai ser chamada pelo botão
    public void AbrirMapa()
    {
        // O nome dentro das aspas tem de ser IGUAL ao nome da cena que criaste
        SceneManager.LoadScene("Menu de escolhas");
    }
}