using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Messages : MonoBehaviour {
    public static SystemLanguage lingua;
    public static Dictionary<string, string> stringList = new Dictionary<string, string>();
    public static void SetLanguage(SystemLanguage lang)
    {
        lingua = lang;
        stringList = new Dictionary<string, string>();

        //Check the chosen language ("lang"). In this case we're using 
        //English as the default language
        if (lang == SystemLanguage.Portuguese || lang == SystemLanguage.Unknown || lang == null)
        {
            //Tutorial
            stringList.Add("hooverCap00", "Muito bem, jovem patrulheiro. Esta é sua primeira missão.");
            stringList.Add("hooverCap01", "A sua frente tem uma estação alienigena abandonada.");
            stringList.Add("hooverCap02", "Tome muito cuidado com os desafios e armadilhas.");
            stringList.Add("hooverCap03", "Boa sorte, patrulheiro.");

            stringList.Add("CARA01", "Olá, eu sou Copiloto Artificial Retificador Analítico, mas pode me chamar de C.A.R.A.");
            //stringList.Add("CARA02", "mas pode me chamar de C.A.R.A. ");
            stringList.Add("CARA03", "Estou aqui para te ajudar e auxiliar em sua jornada.");
            //stringList.Add("CARA04", "Vamos começar retomando o básico da navegação.");
            stringList.Add("CARA05", "Use o MOUSE para indicar a direção em que a X-Plorer irá apontar.");
            stringList.Add("CARA06", "Use o BOTÃO DIREITO do MOUSE para acionar os propulsores.");
            stringList.Add("CARA07", "Muito bem. A força de vontade é forte em você.");
            //stringList.Add("CARA08", "Vê aquele meteorito alí em cima?");
            //stringList.Add("CARA09", "Aproxime-se dele e ultilize o BOTÃO ESQUERDO do MOUSE");
            //stringList.Add("CARA10", "para usar seu canhão trator.");

            stringList.Add("CARA11", "Você possui um canhão trator que funciona de duas maneiras ");
            stringList.Add("CARA12", "ao apertar o BOTÃO ESQUERDO do MOUSE você usa o RAIO DE ATRAÇÃO.");
            stringList.Add("CARA13", "Você pode também usar o RAIO DE DISPERSÃO,");
            stringList.Add("CARA14", "para isso, segure a tecla SHIFT ao clicar no BOTÃO ESQUERDO do MOUSE");
            //stringList.Add("CARA15", "UAU! INCRÍVEL!");
            stringList.Add("CARA16", "Você pode atrair qualquer coisa que estiver solta pelo espaço com seu canhão trator.");
            //stringList.Add("CARA17", "Parece que o impacto daquele meteorito causou uma rachadura no asteróide.");
            //stringList.Add("CARA18", "Existe outro meteorito por perto.");
            stringList.Add("CARA19", "Use aquela bomba para destruir aquela parede e entrar na base.");

            //Fase01
            stringList.Add("CARA20", "Use os meteoritos para quebrar as paredes rachadas e acessar a próxima área.");
            stringList.Add("CARA21", "Que a força da coordenação motora esteja com você.");

            //Fase02
            stringList.Add("CARA22", "Hmm...Que estranho. Estas paredes são retas. Como se tivessem sido escavadas.");
            stringList.Add("CARA23", "Acho que aquilo é um botão. Tente pressioná-lo usando um meteorito.");
      

            //Fase03
            stringList.Add("hooverCap04", "Patrulheiro, parece que você encontrou algo interessante aqui.");
            stringList.Add("hooverCap05", "Esses símbolos são obra de alguma civilização alienígena.");
            stringList.Add("hooverCap06", "Nossos nerds estão trabalhando na tradução,");
            stringList.Add("hooverCap07", "mas parece que existe algum tipo de artefato neste asteróide.");
            stringList.Add("hooverCap08", "Encontre-o e traga-o para a nave-mãe para que possamos estudá-lo melhor.");

            stringList.Add("CARA24", " Parece que esta parede não vai se quebrar com facilidade. Precisamos de algo mais “explosivo”.");
            
            //Fase05
            stringList.Add("CARA25", "Estou com um mal pressentimento. Tenha cuidado.");
            stringList.Add("CARA26", "Esse caminho está bloqueado. Precisamos achar outra passagem.");
            stringList.Add("hooverCap09", "Muito bem, patrulheiro. Este artefato será muito útil em nossas pesquisas. Você provou o seu valor.");


        }

        //To end, I will provide a bigger example, for portuguese translation
        if (lang == SystemLanguage.English)
        {
            //Tutorial
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
            stringList.Add("CARA17", "There is another meteorite nearby.");
            stringList.Add("CARA18", "Use it to make your way through the asteroid.");

            //Fase01
            stringList.Add("CARA20", "Use the meteorites to break the cracked walls and gain access to the next area.");
            stringList.Add("CARA21", "May the motor coordination force be with you.");

            //Fase02
            stringList.Add("CARA22", "Hmm…strange. These walls are straight. As if they have been excavated");
            stringList.Add("CARA23", "I guess that is a button. Try to press it using the meteorite.");

            //Fase03
            stringList.Add("hooverCap04", "Ranger, seems like you found something interesting here.");
            stringList.Add("hooverCap05", "These symbols were made by some alien civilization. ");
            stringList.Add("hooverCap06", "Our nerds are working in a translation");
            stringList.Add("hooverCap07", "but it seems to be some kind of artifact in this asteroid.");
            stringList.Add("hooverCap08", "Find it and bring it to the mother-ship so we can study it better.");

            stringList.Add("CARA24", "I think this wall won’t break easily. We need something more explosive.");

            //Fase05
            stringList.Add("CARA25", "I have a bad feeling about this. Be careful.");
            stringList.Add("CARA26", "This way is blocked. We have to find another path.");
            stringList.Add("hooverCap09", "Well done, ranger. This artifact will be very useful in our research. You have proved your value.");



        }

    }
}

public class dialogs {


}



