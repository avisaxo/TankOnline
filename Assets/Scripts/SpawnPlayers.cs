using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
   public List<Transform> Spawners;
   public GameObject playerPrefabs;
   public float minX = -8f;
   public float maxX = 6f;
   public float minZ = -4f;
   public float maxZ = 5f;

   private int IndexSpawn;

   private void Start()
   {
      Vector3 spawnTransform = new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minZ,maxZ));
      PhotonNetwork.Instantiate(playerPrefabs.name, spawnTransform, Quaternion.identity);
   }
}
