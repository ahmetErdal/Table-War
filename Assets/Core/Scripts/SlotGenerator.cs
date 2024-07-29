using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGenerator : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] int height;
    [SerializeField] float slotSpacing = 1f; // Slotlar aras�ndaki bo�luk

    [SerializeField] GameObject slotObject;

    void Start()
    {
        Vector3 spawnPosition = transform.position; // Ba�lang�� spawn pozisyonu

        for (int i = 0; i < height; i++) // Y dikeyde d�n
        {
            for (int j = 0; j < width; j++) // X yatayda d�n
            {
                Instantiate(slotObject, spawnPosition, Quaternion.identity);
                spawnPosition.x += slotSpacing; // X konumunu artt�r
            }

            // Bir sat�r tamamland���nda, bir sonraki sat�r i�in konumu g�ncelle
            spawnPosition.x = transform.position.x; // X'i ba�lang�� noktas�na geri getir
            spawnPosition.z -= slotSpacing; // Y konumunu azaltarak geriye git
        }
    }
}
