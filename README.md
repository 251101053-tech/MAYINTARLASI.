# 💣 Mayın Tarlası (Minesweeper)

C# Windows Forms ile geliştirilmiş klasik Mayın Tarlası masaüstü oyunu.

---

## 🎮 Özellikler

* **10x10 Boyut:** Toplam 100 kareden oluşan ızgara yapısı.
* **Dinamik Mayın Dağılımı:** Her yeni oyunda rastgele yerleştirilen 10 adet benzersiz mayın.
* **Sağ Tık (Bayrak):** Şüpheli karelere `🚩` koyma ve kaldırma özelliği.
* **Sol Tık (Açma):** Güvenli kareleri açma ve komşu 8 karedeki toplam mayın sayısını görüntüleme.
* **Yeniden Başlatma:** Üst kısımdaki `😊` butonu ile tek tıkla oyunu sıfırlama.
* **Game Over Ekranı:** Mayına basıldığında tüm mayınları (`💣`) kırmızı arka planla gösterme ve butonun `😡` ifadesine dönüşmesi.

---

## 🕹️ Nasıl Oynanır?

| Kontrol | İşlem |
| --- | --- |
| **Sol Tık** | Kareyi açar; komşu mayın sayısını gösterir veya mayına basılırsa oyunu sonlandırır. |
| **Sağ Tık** | Kareye `🚩` işareti koyar veya kaldırır (bayraklı kareler kazara sol tıkla patlamaz). |
| **😊 Butonu** | Oyunu baştan başlatır. |

---

## 🛠️ Kurulum ve Çalıştırma

1. Projeyi indirin veya klonlayın.
2. Visual Studio ile projeyi açın.
3. `F5` tuşuna basarak oyunu derleyip başlatın.
