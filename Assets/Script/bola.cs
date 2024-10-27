using UnityEngine;

public class bola : MonoBehaviour
{
   // Mendeklarasikan variabel body sebagai Rigidbody2D untuk mengakses komponen fisika 2D objek ini
   Rigidbody2D body;

   // Mendeklarasikan variabel bounceForce sebagai float untuk mengatur besar gaya pantulan
   public float bounceForce;

   // Mendeklarasikan variabel boolean OnStart untuk memeriksa apakah permainan baru saja dimulai
   bool OnStart;

   // Fungsi Awake() akan dipanggil sekali saat game dimulai
   private void Awake()
   {
       // Mengambil komponen Rigidbody2D dari objek dan menyimpannya dalam variabel body
       body = GetComponent<Rigidbody2D>();

       // Mengatur OnStart ke true, menandakan bahwa game baru saja dimulai
       OnStart = true;
   }

   // Fungsi Update() dipanggil setiap frame
   void Update()
   {
       // Jika permainan baru saja dimulai (OnStart = true)
       if (OnStart)
       {
           // Memeriksa apakah ada tombol yang ditekan
           if (Input.anyKey)
           {
               // Memanggil fungsi StartBounce() untuk memulai gerakan bola
               StartBounce();

               // Mengatur OnStart ke false agar fungsi ini tidak dipanggil lagi setelah bola mulai bergerak
               OnStart = false;
           }
       }
   }

   // Fungsi untuk memulai gerakan pantulan bola
   void StartBounce()
   {
       // Array untuk menentukan arah acak (-1 atau 1)
       int[] randomVal = { -1, 1 };

       // Membuat vektor arah acak dengan nilai x acak (antara -1 atau 1) dan y tetap di 1
       Vector2 randomDirection = new Vector2(randomVal[Random.Range(0, 2)], 1f);

       // Memberikan gaya ke bola dengan arah acak dan besar gaya sesuai nilai bounceForce
       body.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
   }

   // Fungsi yang akan dipanggil saat bola bertabrakan dengan objek lain
   private void OnCollisionEnter2D(Collision2D collision)
   {
       // Memeriksa apakah objek yang bertabrakan memiliki tag "Batas"
       if (collision.gameObject.tag == "Batas")
       {
           // Memanggil fungsi Restart() dari GameManager untuk mengulang permainan
           GameManager.instance.Restart();
       }
   }
}
