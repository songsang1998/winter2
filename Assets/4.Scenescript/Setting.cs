using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setting : MonoBehaviour
{
    public Text maintext;
    string otext;
    string stext;
    public bool skip = false;
    public GameObject Audios;
    public GameObject button;
    public GameObject star;
    public GameObject selectbutton;
    public GameObject end;
    int[] SelectArray;
   Transform Parent;
    Transform Upimage;
    Transform Main;
    Transform DownImage;
    Transform Back;
    GameObject childs;
    Transform maintexts;
    public bool stars;
    GameObject ScroolArea;
    GameObject Manu;
    GameObject Bottom;
    GameObject BottomSkip;
   
    int textnumber;
    GameObject Stop;

    // Start is called before the first frame update
    
    void Start()
    {

        Manu = GameObject.Find("Manu");
        //Listbutton = Manu.transform.GetChild(0).gameObject;
        Bottom= GameObject.Find("bottom");
        BottomSkip = GameObject.Find("SkipButton");
        ScroolArea = GameObject.Find("ScroolArea");
        Main = GameObject.Find("main").transform;
        Upimage = GameObject.Find("main").transform.GetChild(0).GetComponent<Transform>();
        maintexts = GameObject.Find("main").transform.GetChild(1).GetComponent<Transform>();
        DownImage = GameObject.Find("main").transform.GetChild(3).GetComponent<Transform>();
        Parent = GameObject.Find("main").transform.GetChild(2).GetComponent<Transform>();
        Back = GameObject.Find("background").transform;
        Stop = GameObject.Find("Canvas").transform.GetChild(7).gameObject;
        Audios = GameObject.Find("Audio Source").gameObject;
        SaveLoad();
        SettingStart();


    }
    public void SettingStart()
    {


        
        Parent.gameObject.SetActive(false);
        Upimage.gameObject.SetActive(false);
        DownImage.gameObject.SetActive(false);
       // Listbutton.SetActive(false);
        skip = false;
        maintext.text = "";
        textnumber = GetComponent<Scenemove>().scenenumber;
        PlayerPrefs.SetInt("data"+textnumber, 1);
        PlayerPrefs.SetInt("Scene", textnumber);
        PlayerPrefs.Save();
        Audios.GetComponent<Audios>().StartAudio(textnumber);
        otext = Texts.instance.Set(textnumber);
       
        SelectArray = Texts.instance.Array(textnumber);


       
        foreach (Transform child in Back)
        {

            if (int.Parse(child.gameObject.name) == GetComponent<Scenemove>().scenenumber)
            {

                child.gameObject.SetActive(true);

            }
            else
            {
                child.gameObject.SetActive(false);

            }
        }
        if (textnumber==179||(textnumber>=183 && textnumber<=186)||textnumber==189||textnumber==191||(textnumber>=218&&textnumber<=221)||textnumber==224||textnumber==226||textnumber==340||textnumber==401||textnumber==430||textnumber==470||textnumber==473)
        {
            maintext.GetComponent<Text>().fontStyle = FontStyle.Italic;
        }
        else
        {
            maintext.GetComponent<Text>().fontStyle = FontStyle.Normal;
        }
        StartCoroutine("TypingAction");


    }
    
    // Update is called once per frame
    IEnumerator TypingAction()
    {
        yield return new WaitForSeconds(0.3f);
        Starwhy();
        PlayerPrefs.SetInt("Back", stars ? 1 : -1);
        PlayerPrefs.Save();
        foreach (Transform child in Parent)
        {
            Destroy(child.gameObject);
        }
        
        foreach (Transform child in Upimage)
        {

            if (int.Parse(child.gameObject.name) == GetComponent<Scenemove>().scenenumber)
            {
                Upimage.gameObject.SetActive(true);
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);

            }
        }
        if (SelectArray[0] != -5 && SelectArray[0]!=-3)
        {
            for (int i = 0; i < otext.Length; i++)
            {

                yield return new WaitForSeconds(0.035f);

                stext += otext.Substring(0, i);
                maintext.text = stext;
                stext = "";
                if (skip == true)
                {
                    break;
                }
            }
            maintext.text = otext;
        }
        else
        {
            Stop.SetActive(true);
            maintext.text = otext;
        }
        yield return new WaitForSeconds(0.05f);
        Imageon();

    }
      
    void Imageon()
    {

        StartCoroutine("SelectAction");
       

    }

    
    IEnumerator SelectAction()
    {

        if (SelectArray[0] ==0)
        {
            Parent.gameObject.SetActive(true);
            childs = Instantiate(button, transform.position, transform.rotation) as GameObject;
            childs.transform.SetParent(Parent,false);
            if (stars) {
                childs.transform.GetChild(0).GetComponent<Text>().color = Color.white;
                childs.transform.GetChild(1).GetComponent<Image>().color = Color.white;

            }
          
           
        }
        else if (SelectArray[0] == -1)
        {
            Parent.gameObject.SetActive(true);
            childs = Instantiate(star, transform.position, transform.rotation) as GameObject;
            childs.transform.SetParent(Parent,false);
            if (stars)
            {
                childs.transform.GetChild(0).GetComponent<Text>().color = Color.white;
                
            }
        }
        else if (SelectArray[0] == -2)
        {
           
            foreach (Transform child in DownImage)
            {

                if (int.Parse(child.gameObject.name) == GetComponent<Scenemove>().scenenumber)
                {
                    DownImage.gameObject.SetActive(true);
                    child.gameObject.SetActive(true);
                   
                    yield return new WaitForSeconds(0.000001f);
              

                }
                else
                {
                    child.gameObject.SetActive(false);

                }
                
            }
            
        }
        else if (SelectArray[0] == -3)
        {
            
            StartCoroutine("Arm");
        }
        else if (SelectArray[0] == -4)
        {
            Parent.gameObject.SetActive(true);
           
            childs = Instantiate(end, transform.position, transform.rotation) as GameObject;
            childs.transform.SetParent(Parent,false);
            if (stars)
            {
                childs.transform.GetChild(0).GetComponent<Text>().color = Color.white;
                childs.transform.GetChild(1).GetComponent<Image>().color = Color.white;
            }
            
        }
        else if (SelectArray[0] == -5)
        {
            
            StartCoroutine("Lates");
           
        }
        else if (SelectArray[0] >= 1)
        {

            Parent.gameObject.SetActive(true);
            foreach (int a in SelectArray)
            {
               
                childs = Instantiate(selectbutton, transform.position, transform.rotation) as GameObject;
                childs.transform.SetParent(Parent,false);
                childs.GetComponent<SelecterSetting>().Textsetting(a);
                if (stars)
                {
                    childs.transform.GetChild(0).GetComponent<Text>().color = Color.white;
                    childs.transform.GetChild(1).GetComponent<Image>().color = Color.white;
                }
                yield return new WaitForSeconds(0.00001f);
            }
        }
       // Listbutton.SetActive(true);



    }
    IEnumerator Arm()
    {
        
        Back.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        GetComponent<Scenemove>().scenenumber += 1;
        Stop.SetActive(false);
        SettingStart();

    }
    IEnumerator Lates()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<Scenemove>().scenenumber += 1;
        Stop.SetActive(false);
        SettingStart();

    }

    public void Reversal()
    {
        if (stars)
        {
            stars = false;
           

        }
        else
        {
            stars = true;
          
            
        }
    }
    public void Starwhy()
    {
        if (stars)
        {
            ScroolArea.GetComponent<Image>().color = new Color(29 / 255f, 32 / 255f, 32 / 255f);
            Bottom.GetComponent<Image>().color = new Color(29 / 255f, 32 / 255f, 32 / 255f);
            Manu.GetComponent<Image>().color = new Color(29 / 255f, 32 / 255f, 32 / 255f);
            maintext.GetComponent<Text>().color = Color.white;
            BottomSkip.transform.GetChild(0).GetComponent<Text>().color = Color.white;
            Manu.transform.GetChild(0).gameObject.SetActive(true);
            Manu.transform.GetChild(1).gameObject.SetActive(true);
            Manu.transform.GetChild(2).gameObject.SetActive(false);
            Manu.transform.GetChild(3).gameObject.SetActive(false);

        }
        else
        {
            ScroolArea.GetComponent<Image>().color = new Color(245 / 255f, 245 / 255f, 245 / 255f);
            Bottom.GetComponent<Image>().color = new Color(245 / 255f, 245 / 255f, 245 / 255f);
            Manu.GetComponent<Image>().color = new Color(245 / 255f, 245 / 255f, 245 / 255f);
            maintext.GetComponent<Text>().color = Color.black;
            BottomSkip.transform.GetChild(0).GetComponent<Text>().color = Color.black;
            Manu.transform.GetChild(2).gameObject.SetActive(true);
            Manu.transform.GetChild(3).gameObject.SetActive(true);
            Manu.transform.GetChild(0).gameObject.SetActive(false);
            Manu.transform.GetChild(1).gameObject.SetActive(false);

        }
    }
    void SaveLoad()
    {
        if (PlayerPrefs.HasKey("Scene"))
        {
            GetComponent<Scenemove>().scenenumber = PlayerPrefs.GetInt("Scene");
        }
        else
        {
            GetComponent<Scenemove>().scenenumber = 1;
        }
        if (PlayerPrefs.HasKey("Back"))
        {

            stars = (PlayerPrefs.GetInt("Back") != -1);
        }
        else
        {
            stars = false;
            
        }
    }
}

