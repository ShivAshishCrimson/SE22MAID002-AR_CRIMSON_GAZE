using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    [ExecuteInEditMode]
    MeshRenderer renderer;
    bool hitFlag = false;
    string name;
    //private Gaze gazedAt;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        name = renderer.name;
        //transform.position = Vector3.zero;

    }
    void Update()
    {
       // Debug.Log(gazedAt.name);
        if (hitFlag)
        {
            switch (name)
            {
                case "Cube":
                    Color customColor = new Color(0.807843137254902f, 0.5764705882352941f, 0.8470588235294118f, 1.0f);
                    renderer.material.SetColor("_Color", customColor);
                    transform.localPosition = Vector3.one;
                    //renderer.sharedMaterial.color = new Color(206, 147, 216);
                    // code block
                    break;
                case "Library":
                    Color library = new Color(0.807843137254902f, 0.5764705882352941f, 0.8470588235294118f, 1.0f);
                    renderer.material.SetColor("_Color", library);
                     transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "ITBlock1":
                    Color itblock = new Color(0.5647058823529412f, 0.792156862745098f, 0.9764705882352941f);
                    renderer.material.SetColor("_Color", itblock);
                    transform.localPosition = new Vector3(89.29f, -1.9446f, 81.417f);
                    transform.localScale = new Vector3(1.1591f, 1.1591f, 1.1591f);
                    break;
                case "ITBlock2":
                    Color itblock2= new Color(0.5647058823529412f, 0.792156862745098f, 0.9764705882352941f);
                    renderer.material.SetColor("_Color", itblock2);
                    transform.localPosition = new Vector3(42.996f, -1.0803f, 38.785f);
                    transform.localScale = new Vector3(1.0884f, 1.0884f, 1.0884f);
                    break;
                case "BoysHostelPhase1":
                    Color boyshostelPhase1 = new Color(0.6235294117647059f, 0.6588235294117647f, 0.8549019607843137f);
                    renderer.material.SetColor("_Color", boyshostelPhase1);
                    transform.localPosition = new Vector3(182.58f, -3.3291f, 93.612f);
                    transform.localScale = new Vector3(1.2652f, 1.2652f, 1.2652f);
                    break;
                case "BoysHostelPhase2":
                    Color boyshostelPhase2 = new Color(0.7019607843137254f, 0.615686274509804f, 0.8588235294117647f);
                    renderer.material.SetColor("_Color", boyshostelPhase2);
                    transform.localPosition = new Vector3(100.02f, -2.6256f, 61.76f);
                    transform.localScale = new Vector3(1.1414f, 1.1414f, 1.1414f);
                    break;
                case "SOE":
                    Color soe = new(0.9372549019607843f, 0.6039215686274509f, 0.6039215686274509f);
                    renderer.material.SetColor("_Color", soe);
                    transform.localPosition = new Vector3(105.79f,-1.1667f, 39.397f);
                    transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "SOM":
                    Color som = new Color(0.9019607843137255f, 0.9333333333333333f, 0.611764705882353f);
                    renderer.material.SetColor("_Color", som);
                    transform.localPosition = new Vector3(57.118f, -1.1667f, 73.618f);
                    transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "SOL":
                    Color sol = new Color(0.7725490196078432f, 0.8823529411764706f, 0.6470588235294118f);
                    renderer.material.SetColor("_Color", sol);
                    transform.localPosition = new Vector3(38.497f, -1.0076f, 63.624f);
                    transform.localScale = new Vector3(1.1679f, 1.1679f, 1.1679f);
                    break;
                case "IMSOE1":
                    Color imsoe = new Color(0.5019607843137255f, 0.8705882352941177f, 0.9176470588235294f);
                    renderer.material.SetColor("_Color", imsoe);
                    transform.localPosition = new Vector3(65.218f, -1.6971f, 92.134f);
                    transform.localScale = new Vector3(1.2828f, 1.2828f, 1.2828f);
                    break;
                case "IMSOE2":
                    Color imsoe2= new Color(0.5019607843137255f, 0.8705882352941177f, 0.9176470588235294f);
                    renderer.material.SetColor("_Color", imsoe2);
                    transform.localPosition = new Vector3(64.782f, -1.3258f, 72.284f);
                    transform.localScale = new Vector3(1.221f, 1.221f, 1.221f);
                    break;
                case "TechM":
                    Color techm = new Color(0.6901960784313725f, 0.7450980392156863f, 0.7725490196078432f);
                    renderer.material.SetColor("_Color", techm);
                    transform.localPosition = new Vector3(28.255f, -0.4773f, 30.838f);
                    transform.localScale = new Vector3(1.0795f, 1.0795f, 1.0795f);
                    break;
                case "TechM0":
                    Color techm0= new Color(0.6901960784313725f, 0.7450980392156863f, 0.7725490196078432f);
                    renderer.material.SetColor("_Color", techm0);
                 // transform.localPosition = new Vector3(28.255f, -0.4773f, 30.838f);
                 // transform.localScale = new Vector3(1.0795f, 1.0795f, 1.0795f);
                    break;
                case "Football":
                    Color football = new Color(0.7725490196078432f, 0.8823529411764706f, 0.6470588235294118f);
                    renderer.material.SetColor("_Color", football);
                    transform.localPosition = new Vector3(32.14f, -0.26517f, 25.813f);
                    transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "GS":
                    Color gs = new Color(1, 0.8784313725490196f, 0.5098039215686274f);
                    renderer.material.SetColor("_Color", gs);
                    transform.localPosition = new Vector3(208.58f, -2.8108f, 161.82f);
                    transform.localScale = new Vector3(1.4685f, 1.4685f, 1.4685f);
                    break;
                case "FR":
                    Color fr = new Color(1, 0.6705882352941176f, 0.5686274509803921f);
                    renderer.material.SetColor("_Color", fr);
                    transform.localPosition = new Vector3(99.307f, -0.17678f, 54.859f);
                    transform.localScale = new Vector3(1.1768f, 1.1768f, 1.1768f);
                    break;
                case "ClubHouse":
                    Color clubhouse = new Color(0.9568627450980393f, 0.5607843137254902f, 0.6941176470588235f);
                    renderer.material.SetColor("_Color", clubhouse);
                    transform.localPosition = new Vector3(98.448f, -1.4319f, 147.75f);
                    transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "Tennis":
                    Color tennis = new Color(0.7372549019607844f, 0.6666666666666666f, 0.6431372549019608f);
                    renderer.material.SetColor("_Color", tennis);
                    transform.localPosition = new Vector3(88.292f, 0, 51.381f);
                    transform.localScale = new Vector3(1.221f, 1.221f, 1.221f);
                    break;
                case "kailash":
                    Color kailash = new Color(0.5647058823529412f, 0.792156862745098f, 0.9764705882352941f);
                    renderer.material.SetColor("_Color", kailash);
               //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
               //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "satpura":
                    Color satpura = new Color(0.6235294117647059f, 0.6588235294117647f, 0.8549019607843137f);
                    renderer.material.SetColor("_Color", satpura);
                    //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "nilgiri":
                    Color nilgiri = new Color(0.7019607843137254f, 0.615686274509804f, 0.8588235294117647f);
                    renderer.material.SetColor("_Color", nilgiri);
                    //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "vindhya":
                    Color vindhya = new Color(0.5019607843137255f, 0.796078431372549f, 0.7686274509803922f);
                    renderer.material.SetColor("_Color", vindhya);
                    //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "shivalik":
                    Color shivalik = new Color(0.9019607843137255f, 0.9333333333333333f, 0.611764705882353f);
                    renderer.material.SetColor("_Color", shivalik);
                    //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "himalaya":
                    Color himalaya = new Color(0.7725490196078432f, 0.8823529411764706f, 0.6470588235294118f);
                    renderer.material.SetColor("_Color", himalaya);
                    //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "ajantha":
                    Color ajantha = new Color(0.5019607843137255f, 0.8705882352941177f, 0.9176470588235294f);
                    renderer.material.SetColor("_Color", ajantha);
                    //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "aravali":
                    Color aravali = new Color(1, 0.8784313725490196f, 0.5098039215686274f);
                    renderer.material.SetColor("_Color", aravali);
                    //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                case "mess":
                    Color mess = new Color(0.807843137254902f, 0.5764705882352941f, 0.8470588235294118f, 1.0f);
                    renderer.material.SetColor("_Color", mess);
                    //   transform.localPosition = new Vector3(122.5f, -1.1667f, 147.75f);
                    //   transform.localScale = new Vector3(1.1945f, 1.1945f, 1.1945f);
                    break;
                default:
                   // renderer.sharedMaterial.color = Color.white;
                    // code block
                    break;
            }
          // transform.position = new Vector3(0,0.02f,0);
        }
        else
        {
            switch (name)
            {
                case "road":
                    Color customColor = new Color(0f, 0f, 0f, 1.0f);
                    renderer.material.SetColor("_Color", customColor);
                    //transform.localPosition = Vector3(0, 0.02f, 0);
                    //renderer.sharedMaterial.color = new Color(243, 229, 245);
                    // code block
                    break;
                case "Library":
                       Color library = new Color(0.8823529411764706f, 0.7450980392156863f, 0.9058823529411765f, 1.0f);
                       renderer.material.SetColor("_Color", library);
                   transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    // code block
                    break;
                case "ITBlock1":
                    Color itblock = new Color(0.7333333333333333f, 0.7333333333333333f, 0.984313725490196f);
                    renderer.material.SetColor("_Color", itblock);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "ITBlock2":
                    Color itblock2 = new Color(0.7333333333333333f, 0.7333333333333333f, 0.984313725490196f);
                    renderer.material.SetColor("_Color", itblock2);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "BoysHostelPhase1":
                    Color boyshostelPhase1 = new Color(0.7725490196078432f, 0.792156862745098f, 0.9137254901960784f);
                    renderer.material.SetColor("_Color", boyshostelPhase1);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "BoysHostelPhase2":
                    Color boyshostelPhase2 = new Color(0.8196078431372549f, 0.7686274509803922f, 0.9137254901960784f);
                    renderer.material.SetColor("_Color", boyshostelPhase2);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "SOE":
                    Color soe = new Color(1, 0.803921568627451f, 0.8235294117647058f);
                    renderer.material.SetColor("_Color", soe);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "SOM":
                    Color som = new Color(0.9411764705882353f, 0.9568627450980393f, 0.7647058823529411f);
                    renderer.material.SetColor("_Color", som);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "SOL":
                    Color sol = new Color(0.8627450980392157f, 0.9294117647058824f, 0.7843137254901961f);
                    renderer.material.SetColor("_Color", sol);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "IMSOE1":
                    Color imsoe = new Color(0.6980392156862745f, 0.9215686274509803f, 0.9490196078431372f);
                    renderer.material.SetColor("_Color", imsoe);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "IMSOE2":
                    Color imsoe2 = new Color(0.6980392156862745f, 0.9215686274509803f, 0.9490196078431372f);
                    renderer.material.SetColor("_Color", imsoe2);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "TechM":
                    Color techm = new Color(0.8117647058823529f, 0.8470588235294118f, 0.8627450980392157f);
                    renderer.material.SetColor("_Color", techm);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "TechM0":
                    Color techm0 = new Color(0.8117647058823529f, 0.8470588235294118f, 0.8627450980392157f);
                    renderer.material.SetColor("_Color", techm0);
                    break;
                case "Football":
                    Color football = new Color(0.8627450980392157f, 0.9294117647058824f, 0.7843137254901961f);
                    renderer.material.SetColor("_Color", football);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "GS":
                    Color gs = new Color(1, 0.9254901960784314f, 0.7019607843137254f);
                    renderer.material.SetColor("_Color", gs);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "FR":
                    Color fr = new Color(1, 0.8f, 0.7372549019607844f);
                    renderer.material.SetColor("_Color", fr);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "ClubHouse":
                    Color clubhouse = new Color(0.9725490196078431f, 0.7333333333333333f, 0.8156862745098039f);
                    renderer.material.SetColor("_Color", clubhouse);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "Tennis":
                    Color tennis = new Color(0.8431372549019608f, 0.8f, 0.7843137254901961f);
                    renderer.material.SetColor("_Color", tennis);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "kailash":
                    Color kailash = new Color(0.7333333333333333f, 0.7333333333333333f, 0.984313725490196f);
                    renderer.material.SetColor("_Color", kailash);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "satpura":
                    Color satpura = new Color(0.7725490196078432f, 0.792156862745098f, 0.9137254901960784f);
                    renderer.material.SetColor("_Color", satpura);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "nilgiri":
                    Color nilgiri = new Color(0.8196078431372549f, 0.7686274509803922f, 0.9137254901960784f);
                    renderer.material.SetColor("_Color", nilgiri);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "vindhya":
                    Color vindhya = new Color(0.6980392156862745f, 0.8745098039215686f, 0.8588235294117647f);
                    renderer.material.SetColor("_Color", vindhya);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "shivalik":
                    Color shivalik = new Color(0.9411764705882353f, 0.9568627450980393f, 0.7647058823529411f);
                    renderer.material.SetColor("_Color", shivalik);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "himalaya":
                    Color himalaya = new Color(0.8627450980392157f, 0.9294117647058824f, 0.7843137254901961f);
                    renderer.material.SetColor("_Color", himalaya);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "ajantha":
                    Color ajantha = new Color(0.6980392156862745f, 0.9215686274509803f, 0.9490196078431372f);
                    renderer.material.SetColor("_Color", ajantha);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "aravali":
                    Color aravali = new Color(1, 0.9254901960784314f, 0.7019607843137254f);
                    renderer.material.SetColor("_Color", aravali);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                case "mess":
                    Color mess = new Color(0.807843137254902f, 0.5764705882352941f, 0.8470588235294118f, 1.0f);
                    renderer.material.SetColor("_Color", mess);
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localScale = new Vector3(1, 1, 1);
                    break;
                default:
                    //renderer.sharedMaterial.color = Color.white;
                    // code block
                    break;
            }
            // transform.position = Vector3.zero;
        }
        hitFlag = false;
    }
    void HitByRay()
    {
        hitFlag = true;
        //renderer.sharedMaterial.color = Color.green;
        
        Debug.Log(name);
        // transform.position = new Vector3(0, 4, 0);
        //Debug.Log("I was hit by a Ray");

    }
}
