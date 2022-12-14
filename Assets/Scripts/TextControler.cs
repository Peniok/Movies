using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextControler : MonoBehaviour
{
    public Text nameText;
    public Text infoText;
    public Text ganr;


    public Image img;
    public Sprite[] imgs;

    public Text[] names;
    public Text[] infos;


    string[] _name = new string[13];
    string[] _info = new string[13];
    string[] _ganr = new string[13];
    private void Start()
    {
        _name[0] = "??????-?????: ????? ????? ??????";
        _info[0] = "ϳ??? ???????? ??? ̳?????? ??????????? ϳ???? ??????? ????????????? ?????, ???????? ??? ??????? ???? ????? ?? ????? ??????-??????. ? ??????? ?????? ?????????? ??? ??????????? ?? ????????? ?? ??????? ????????? ????????, ??????? ??????? ????????, ???? ??? ? ?????? ???????? ?????????? ?????????? ??? ???? ??????. ????? ?????????? ?????? ?????? ??? ?? ?? ??????, ? ?????????? ???? ?? ????? ?????????? ????????? ? ??????????????, ????? ??? ?? ????? ?????????? ?????? ??????-?????? ? ?????????????? ??????, ????????? ???????? ??????? ? ???????????? ??????? ???? ???????.";

        _name[1] = "???????? ???????: ???????";
        _info[1] = "??????????? ?????? ???? ? ??????????? ??????????, ???????-?????????? ??????? ϳ? ̳????? ?? ?????????? ?????????, ?? ????䳺 ??????????? ??????? ??????? ????????, ??? ?????? ?????????? ????????????? ??? ?????????? ??? ?????????. ?????? ???? ?????? ???? ? ???????? ???????? ??????? ??? ??????????, ???? ???? ???????????? ?????????????? ?????? ???, ??????? ̳?????? ???? ??????????? ??? ?????? ??????????? Top Gun, ???? ???????? ???????? ?????????? ?????. ????? ? ??????? ????????? ???????? ? ????????? ?????? ???????, ??? ???? ????????? ?????????? ?????.";

        _name[2] = "??????, ??? ????";
        _info[2] = "?? ???? ??????? ?????? ??????????? ?????? ?? ?????????? ?????????, ???? ??? ????? ????? ???????? ???????????? ?? ???? ???????? ? ??????. ³? ????? ? ???????????? ?????-????, ?? ?????? ? ????? ? ???????, ??? ????????? ? ??????? ???????? ??????, ??? ?????????? ? ??????????????? ??????????. ?? ????????? ?'??????????, ???? ?????, ? ?? ?????? ?????????????? ?????? ?? ?????? ?????, ?? ?????????? ??????? ?? ?????? ? ?????? ??????????? ????????.";

        _name[3] = "??????-?????? ? ???: ???????? ?????";
        _info[3] = "?????????? ????? ???? ? ???? ??? ???? ????????????, ??? ?????????? ???? ??????? ? ???? ??????-?????? ? ???. ????? ? ???????? ????? ?????? ϳ??? ? ?????? ??? ???? ???'? ????????? ????????? ????, ??????䳺 ? ??????? ?????? ???????? ? ?????????? ? ???????, ??? ?????? ?? ?? ???? ?????????.";

        _name[4] = "????????? / ????? 5: ?????????";
        _info[4] = "?? ??????? XVIII ???????? ??????? ?? ??'? ???? ? ??????? ??????, ?? ???? ?? ϳ??????? ??????? ????????, ??? ?? ????? ????????? ??????? ????????, ?????? ?????? ?????? ?????????, ??? ????? ??????????? ??????, ?? ?? ??????? ???? ?????. ????????? ? ?????????? ? ??????????????? ???????, ???? ??????? ????????? ?????? ?????, ??? ??????? ???? ???? ? ????????????? ????? ???????????????. ???????? ???????????, ??????? ????? ?????????? ????????? ???-??-??? ? ??????????? ???????????? ???????, ?? ?????????? ?? ?????????? ????? ?? ??????.";

        _name[5] = "????? ?????";
        _info[5] = "ĳ? ???????????? ? 1884 ???? ? ??????????????. ????? ? ???? ????? ????????????? ??? ?????????? ????? ????? ??????????, ?? ?? ???? ?????? ????????. Ƴ??? ???????? ????? ???? ????????? ????? ??????????, ??? ??????? ?? ???, ???? ???? ????? ????. ????????? ? ????????? ??????? ?????????? ??? ?????? ????? ?????? ??????? ? ?????????, ??? ????????? ?????????? ?? ? ????????. ??? ?? ????????? ???? ? ??????, ????? ????? ? ?????? ? ??????? ??????, ??? ?????????? ? ?????????, ??? ???????? ?????? ????????? ??????????? ??????? ...";

        _name[6] = "???????? ?? ???????? ????????";
        _info[6] = "??????????? ????? ?????? ?? ???????? ??????????? ?????? ??????????? ??????????? ????? ??????.\r\nĳ? ???????????? ??????. ³?????? ????????????? ????????? ?????? ?????, ???? ??????????? ? ????????, ????????? ??????? ?????? ????????? ?? ??????????????. ??? ?????? ??????? ????? ? ??????????? ??????????? \"???????? ????????\" ?????, ??? ?????? ????? ??? ? ???????? ????? ? ?????. ????? ????????, ?? ??????? ??????? ??????? ???? ????????? ???????? ????????? ? ?????? ?????: ? ????? ?????? ???? ?????? ??????? ????? ?????? ???????????????, ???????? ? ??????????? ???????. ??????????????? ?? ??????? ???????????, ???? ???????????? ????????? ?? ?????? ??? ????? ???? ?????????, ????? ??? ?????.\r\n????? ????? ??? ???????? ??????? ??????? ????? ???????????? ??????? ?????. ? ?????? ??? ????? ??????????, ?? ????? ???? ?????? ???????? ????????, ? ????? ????? ? ????????? ????????? ??? ???????.";

        _name[7] = "?? ?????!";
        _info[7] = "?? 1967 ???. ???????????? ??????????? ???????? ????????????? ????? ? ?'??????, ??? ?????? ?? ׳?? ???????, ???? ?????? ?? ????? ????????????? ???????? ????????? - ????????? ? ??????? ? ?????????? ??????? ? ????, ? ??? ????????? ?? ???????? ??? ??????????? ???????? ? ???? ??????? ???. ?????? ????, ????????? ? ?????????? ????, ׳?? ???????? ??????????? ????: ??? ??? ????? ????? ?? ????????? ???????? ? ????????? ? ???? ??????? ???????, ??? ????????? ???? ????? ?????? ??????, ??? ?'????? ?? ???? ???. ??????????? ??????????????, ????????? ? ????????, ???????? ????? ???????? ?? ?'??????, ?? ?? ???????????, ?? ???? ?????????? ???????? ???? ?????????? ???.";

        _name[8] = "????? ????? 2";
        _info[8] = "??????? ??????? ????????? ?????? ?????????? ?????????, ??? ?????????? ? ?????????? ?????????? - ????? ???????? ?? ???????? ???????? ???????, ??? ??? ?????? ????? ? ????????? ???????, ?????? ???? ??????. ?? ?????? ??? ?? ???????? ?????, ?? ????? ???????????? ?? ??????? ???? ??????.";

        _name[9] = "???: ????? ? ????";
        _info[9] = "????????? ???????, ?????? ??????, ????? ? ??????????? ??????? ??????? ? ?????, ??? ?????????? ? ?????????????? ??????. ³? ???????? ??????? ???????????? ?????? ??? ?????????????? ?? ??????? ??? ?????? ???????????? ??????? ????? - ?????????? ????????? ???????????? ????? ????, ???? ??????? ???????? ????????, ?? ???????? ??????? ?????. ??? ??????? ???????, ??? ??????????? ?????????? ???????? ????? ??????? ?????????, ???????????? ?????????? ????? ?... ???? ??????? ???????, ?????????? ????? ??????, ???? ??????? ??????? ????????.";

        _name[10] = "?????? ???????: ? ?????????????? ?????????";
        _info[10] = "?????? ?????? ??????? ?????????????? ?? ???????? ????????? ?? ????????? ?????? ??????? ??????, ??????? ????????????? ??? ?????? ????????. ??????? ????????? ?????? ??? ????????? ??????, ??????? ??????? ? ??????? ? ???????? ?????, ????????-?????????, ?? ????????? ??? ??????????? ????, ??? ???? ??????? ????????? ??????? ???????????? ?? ??????????????. ????? ? ???? ? ?????? ????????? ??????? ??? ????? ????????? ???????, ? ??? ????? ?????????? ??????? ???????? ????????? ?????????? ???????, ???? ????? ?? ???.";

        _name[11] = "????? ???????: ??????? ????????";
        _info[11] = "? ??????????? ??????? ??? ??????? ???????? ???????, ????, ?'????, ???? ? ???? ??????? ???? ̳???? ?????????? ????????, ??? ????????? ???? ????? ????? ?????? ?????? ?'????. ???? ????, ???????? ?????? ?????????? ????????? ????? ????, ?? ????? ???? ??????????? ??????????? ???????.";

        _name[12] = "?????? ?? ͳ??";
        _info[12] = "ĳ? ?????? ???????????? ?? ????? ????????? ????????, ?? ????? ?? ͳ??, ?? ????? ???????? ???????????? ?????? ??????? ???????????. ????????? ???????? ????쳺, ?? ???????? - ?? ????? ??????????????, ??? ?????????? ??? ????????????? ?? ?????, ??? ?????? ??????? ??????, ?? ??????? ?? ?????????. ????? ????????? ????????????? ??? ??????, ??????, ???????? ???????? ? ?????? ??????????? ????????.";


        _ganr[0] = "г?: 2021\n" +
            "??????: ???\n" +
            "????: ??????????";
        _ganr[1] = "г?: 2022\n??????: ???\n????: ?????";
        _ganr[2] = "г?: 2022\n??????: ???\n????: ?????";
        _ganr[3] = "г?: 2022\n??????: ???\n????: ??????????";
        _ganr[4] = "г?: 2022\n??????: ???\n????: ???????";
        _ganr[5] = "г?: 2020\n??????: ??????????????\n????: ???????";
        _ganr[6] = "г?: 2017\n??????: ??????????????\n????: ????????";
        _ganr[7] = "г?: 2022\n??????: ???\n????: ???????";
        _ganr[8] = "г?: 2022\n??????: ??????????????\n????: ???????";
        _ganr[9] = "г?: 2022\n??????: ?????????\n????: ??????????";
        _ganr[10] = "г?: 2022\n??????: ???\n????: ??????????";
        _ganr[11] = "г?: 2023\n??????: ???\n????: ??????????";
        _ganr[12] = "г?: 2022\n??????: ??????????????\n????: ????????";

        for (int i = 0; i < _name.Length; i++)
        {
            //Debug.Log(names[i]);
            names[i].text = _name[i];
            infos[i].text = _ganr[i];
        }


    }


    public void On_Cliked(int i)
    {


        img.sprite = imgs[i];
        nameText.text = _name[i];
        infoText.text = _info[i];
        ganr.text = _ganr[i];
    }




}
