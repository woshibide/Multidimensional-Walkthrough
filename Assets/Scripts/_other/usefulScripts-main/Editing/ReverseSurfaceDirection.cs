using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(MeshFilter))]
public class ReverseSurfaceDirection: MonoBehaviour {

#if UNITY_EDITOR
	[MenuItem("UsefulScripts/ReverseSurfaceDirection _g")]
	static void DoIt(){
		GameObject obj = Selection.activeGameObject;
		MeshFilter filter_tmp = obj.GetComponent(typeof (MeshFilter)) as MeshFilter;
		Mesh mesh_tmp = new Mesh();
		mesh_tmp.vertices = filter_tmp.sharedMesh.vertices;
		mesh_tmp.triangles = filter_tmp.sharedMesh.triangles;
		mesh_tmp.normals = filter_tmp.sharedMesh.normals;
		mesh_tmp.bindposes = filter_tmp.sharedMesh.bindposes;
		mesh_tmp.boneWeights = filter_tmp.sharedMesh.boneWeights;
		mesh_tmp.colors = filter_tmp.sharedMesh.colors;
		mesh_tmp.uv = filter_tmp.sharedMesh.uv;
		mesh_tmp.uv2 = filter_tmp.sharedMesh.uv2;
		mesh_tmp.uv3 = filter_tmp.sharedMesh.uv3;
		mesh_tmp.uv4 = filter_tmp.sharedMesh.uv4;
		mesh_tmp.uv5 = filter_tmp.sharedMesh.uv5;
		mesh_tmp.uv6 = filter_tmp.sharedMesh.uv6;
		mesh_tmp.uv7 = filter_tmp.sharedMesh.uv7;
		mesh_tmp.uv8 = filter_tmp.sharedMesh.uv8;
		DestroyImmediate(obj.GetComponent < MeshFilter > ());
		obj.AddComponent < MeshFilter > ();
		MeshFilter filter = obj.GetComponent(typeof (MeshFilter)) as MeshFilter;
		filter.mesh = mesh_tmp;

		if(filter != null){
			Mesh mesh = filter.sharedMesh;

			Vector3[] normals = mesh.normals;
			for(int i = 0; i < normals.Length; i++){
				normals[i] = -normals[i];
			}
			mesh.normals = normals;

			for(int m = 0; m < mesh.subMeshCount; m++){
				int[] triangles = mesh.GetTriangles(m);
				for(int i = 0; i < triangles.Length; i += 3){
					int temp = triangles[i + 0];
					triangles[i + 0] = triangles[i + 1];
					triangles[i + 1] = temp;
				}
				mesh.SetTriangles(triangles, m);
			}
		}
	}
	[MenuItem("UsefulScripts/ReverseSurfaceDirection _g", true)]
	static bool CanWeDoIt(){
		return Selection.activeGameObject != null;
	}
#endif
}
