using UnityEngine;

public class PorteSortie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (!autre.CompareTag("Player"))
        {
            return;
        }
        Destroy(autre.gameObject);
        Debug.Log("MISSION RÉUSSIE !");
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * Replacez les lignes, puis ajoutez les accolades manquantes.
     *
     * 
     * 
     * 
     * 
     */
}
