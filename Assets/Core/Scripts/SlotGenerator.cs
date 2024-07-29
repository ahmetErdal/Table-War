using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGenerator : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] int height;
    [SerializeField] float slotSpacing = 1f; // Slotlar arasýndaki boþluk

    [SerializeField] GameObject slotObject;

    void Start()
    {
        Vector3 spawnPosition = transform.position; // Baþlangýç spawn pozisyonu

        for (int i = 0; i < height; i++) // Y dikeyde dön
        {
            for (int j = 0; j < width; j++) // X yatayda dön
            {
                Instantiate(slotObject, spawnPosition, Quaternion.identity);
                spawnPosition.x += slotSpacing; // X konumunu arttýr
            }

            // Bir satýr tamamlandýðýnda, bir sonraki satýr için konumu güncelle
            spawnPosition.x = transform.position.x; // X'i baþlangýç noktasýna geri getir
            spawnPosition.z -= slotSpacing; // Y konumunu azaltarak geriye git
        }
    }
}
