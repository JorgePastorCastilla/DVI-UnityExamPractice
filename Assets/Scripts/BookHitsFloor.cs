using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookHitsFloor : MonoBehaviour
{
    public GameObject bookPrefabReference;

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.name == "book_0001a" || collision.gameObject.name == "book_0001a Variant(Clone)")
        {
            Destroy(collision.gameObject);

            GameObject newBook = Instantiate(bookPrefabReference);

            float xOffset = Random.Range(-1.0f, 1.0f);

            newBook.transform.Translate( new Vector3( xOffset, 0, 0 ) );
        }


    }


}
