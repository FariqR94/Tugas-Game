using UnityEngine;
using UnityEngine.SceneManagement; // Mengimpor namespace SceneManagement untuk mengelola adegan

// Mendefinisikan kelas "GameManager" yang merupakan turunan dari MonoBehaviour
public class GameManager : MonoBehaviour
{
    // Membuat variabel static instance agar GameManager bisa diakses dari script lain
    public static GameManager instance;

    // Fungsi Awake() dipanggil sekali saat game dimulai, sebelum Start()
    private void Awake()
    {
        // Mengatur instance menjadi this, sehingga GameManager ini bisa diakses secara global
        instance = this;
    }

    // Fungsi untuk me-restart permainan
    public void Restart()
    {
        // Memuat ulang scene dengan nama "Game" untuk mengulang permainan
        SceneManager.LoadScene("Game");
    }
}
