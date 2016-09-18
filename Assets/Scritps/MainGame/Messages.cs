using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Messages : MonoBehaviour {

    public static Dictionary<string, string> stringList = new Dictionary<string, string>();
    public static void SetLanguage(SystemLanguage lang)
    {

        stringList = new Dictionary<string, string>();

        //Check the chosen language ("lang"). In this case we're using 
        //English as the default language
        if (lang == SystemLanguage.Portuguese || lang == SystemLanguage.Unknown || lang == null)
        {

            stringList.Add("hooverCap00", "Muito bem, jovem patrulheiro. Esta é sua primeira missão.");
            stringList.Add("hooverCap01", "Isso aqui é pra valer.");
            stringList.Add("hooverCap02", "Lembre-se de seu treinamento e você triunfará sobre todos os desafios.");
            stringList.Add("hooverCap03", "Agora vamos começar.");

            stringList.Add("CARA01",      "Olá, eu sou Copiloto Artificial Retificador Analítico,");
            stringList.Add("CARA02",      "mas pode me chamar de C.A.R.A.. Estou aqui para te ajudar e auxiliar em sua jornada.");
            stringList.Add("CARA03",      "Vamos começar retomando o básico da navegação.");
            stringList.Add("CARA04",      "Use o MOUSE para indicar a direção em que a X-Plorer irá apontar.");
            stringList.Add("CARA05",      "Use o BOTÃO DIREITO do MOUSE para acionar os propulsores.");
            stringList.Add("CARA06",      "Muito bem. A força de vontade é forte em você.");
            stringList.Add("CARA07",      "Vê aquele meteorito alí em cima?");
            stringList.Add("CARA08", "Aproxime-se dele e ultilize o BOTÃO ESQUERDO do MOUSE");
            stringList.Add("CARA09", "para usar seu canhão trator.");

            stringList.Add("CARA10", "O canhão trator funciona de duas maneiras ");
            stringList.Add("CARA11", "ao apertar o BOTÃO ESQUERDO do MOUSE você usa o RAIO DE ATRAÇÃO.");
            stringList.Add("CARA12", "Você pode também usar o RAIO DE DISPERSÃO,");
            stringList.Add("CARA13", "para isso, segure a tecla SHIFT ao clicar no BOTÃO ESQUERDO do MOUSE");
            stringList.Add("CARA14", "UAU! INCRÍVEL!");
            stringList.Add("CARA15", "Você pode atrair qualquer coisa que estiver solta pelo espaço com seu canhão trator.");
            stringList.Add("CARA16", "Parece que o impacto daquele meteorito causou uma rachadura no asteróide.");
            stringList.Add("CARA17", "Existe outro meteorito por perto.");
            stringList.Add("CARA18", "Use-o para terminar de abrir o buraco no asteróide.");
        }

        //To end, I will provide a bigger example, for portuguese translation
        if (lang == SystemLanguage.English)
        {

            stringList.Add("hooverCap00", "Right, young ranger. This is your first mission.");
            stringList.Add("hooverCap01", "Now is for real.");
            stringList.Add("hooverCap02", "Remember your training and you will succeed over all the challenges.");
            stringList.Add("hooverCap03", "Let’s begin.");

            stringList.Add("CARA01", "Hello, I am the Direction Unit Designed for Enhancement,");
            stringList.Add("CARA02", "but you can call me D.U.D.E.. ");
            stringList.Add("CARA03", "I’m here for support and help you in your journey.");
            stringList.Add("CARA04", "Let’s start by remembering the navigation basics.");
            stringList.Add("CARA05", "Use the MOUSE to indicate the direction that the X-Plorer will point to.");
            stringList.Add("CARA06", "Use the MOUSE RIGHT BUTTON to activate the propellants. ");
            stringList.Add("CARA07", "Well done. You’ve got the willpower.");
            stringList.Add("CARA08", "See that meteorite over there?");
            stringList.Add("CARA09", "Get closer to it and use the MOUSE LEFT BUTTON to use the tractor cannon.");

            stringList.Add("CARA10", "The tractor cannon have two functions:");
            stringList.Add("CARA11", "by clicking the MOUSE LEFT BUTTON you use the ATTRACTION RAY. ");
            stringList.Add("CARA12", "You can also use the DISPERSION RAY. ");
            stringList.Add("CARA13", "To do it, hold the SHIFT button while clicking the MOUSE LEFT BUTTON. ");
            stringList.Add("CARA14", "WOW, FANTASTIC!");
            stringList.Add("CARA15", "You can attract and repel anything that hangs in the space using the tractor cannon.");
            stringList.Add("CARA16", "It looks like the impact of that meteorite made a crack in the asteroid");
            stringList.Add("CARA17", "I’m requesting an explosive from mother-ship.");
            stringList.Add("CARA18", "Use it to make your way through the asteroid.");



        }

    }
}

public class dialogs {


}



