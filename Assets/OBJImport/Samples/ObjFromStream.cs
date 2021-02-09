using Dummiesman;
using System.IO;
using System.Text;
using UnityEngine;

public class ObjFromStream : MonoBehaviour {
    string objPath = string.Empty;
    void OnGUI () {

        objPath = GUI.TextField(new Rect(0, 0, 256, 32), objPath);

        GUI.Label(new Rect(0, 0, 256, 32), "Obj Path:");
        if (GUI.Button(new Rect(256, 32, 64, 32), "Load File"))
        {


            //make www
            var www = new WWW(objPath);
            while (!www.isDone)
                System.Threading.Thread.Sleep(1);

            //create stream and load
            var textStream = new MemoryStream(Encoding.UTF8.GetBytes(www.text));
            var loadedObj = new OBJLoader().Load(textStream);

        }


	}
}
