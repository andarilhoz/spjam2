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
            stringList.Add("hooverCap01", "Isso aqui é para valer.");
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

            stringList.Add("CARA10", "O canhão trator tem uma funcionalidade que pode ser bem útil. ");
            stringList.Add("CARA11", "Aperte alternadamente as teclas Z e X repetidamente o mais rápido que puder.");
            stringList.Add("CARA12", "Isso irá carregar o estilingue do canhão trator.");
            stringList.Add("CARA13", "Assim que você soltar o BOTÃO ESQUERDO do MOUSE");
            stringList.Add("CARA14", "o canhão irá atirar o meteorito há uma velocidade incrível.");
            stringList.Add("CARA15", "UAU! INCRÍVEL!");
            stringList.Add("CARA16", "Você pode atrair qualquer coisa que estiver solta pelo espaço com seu canhão trator.");
            stringList.Add("CARA17", "Pareçe que o impacto daquele meteorito criou uma rachadura no asteróide.");
            stringList.Add("CARA18", "Estou solicitando um explosivo para a nave mãe.");
            stringList.Add("CARA19", "Use-o para terminar de abrir o buraco no asteróide.");
        }

        //To end, I will provide a bigger example, for portuguese translation
        if (lang == SystemLanguage.English)
        {

            stringList.Add("hooverCap00",  " ");
            stringList.Add("hooverCap01",  " ");
            stringList.Add("hooverCap02",  " ");
            stringList.Add("hooverCap03",  " ");
            stringList.Add("CARA01",       " ");
            stringList.Add("CARA02",       " ");
            stringList.Add("CARA03",       " ");
            stringList.Add("CARA04",       " ");
            stringList.Add("CARA05",       " ");
            stringList.Add("CARA06",       " ");
            stringList.Add("CARA07",       " ");
            stringList.Add("CARA08",       " ");
            stringList.Add("CARA09", " ");

            stringList.Add("CARA09", " ");
            stringList.Add("CARA10", " ");
            stringList.Add("CARA11", " ");
            stringList.Add("CARA12", " ");
            stringList.Add("CARA13", " ");
            stringList.Add("CARA14", " ");
            stringList.Add("CARA15", " ");
            stringList.Add("CARA16", " ");
            stringList.Add("CARA17", " ");
            stringList.Add("CARA18", " ");
            stringList.Add("CARA19", " ");



        }

    }
}

public class dialogs {


}



