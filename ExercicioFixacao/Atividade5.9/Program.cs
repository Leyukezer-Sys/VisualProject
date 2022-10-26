﻿// faça um algoritimo para calcular e apresentar
// o numero de candidatos do sexo feminino,
// o numero de candidatos do sexo masculino,
// a idade media dos homens com experiencia
// a idade media das mulheres com experiencia
// a porcentagem dos homens entre 35 e 45 anos, entre o total dos homens
// a menor idade entre as mulheres que ja tem experiencia no serviço
// o nivel de escolaridade dos candidatos, considerando ensino fundamental, medio, superior e pós-graduação

string nomeCandidato, sexoCandidato, escolaCandidato, cond = "S",resposta = "\n- Nenhum Candidato Cadastrado\n", exper = "";
int idadeCandidato, contfem = 0, contmasc = 0, contHomem35_45, menoridadefem, contFemExp=0, contMascExp = 0,idadeMediaH = 0, idadeMediaF= 0;
int ef,em,es,epg;
double porcHomens35_45 = 0;

while(cond.Equals("SIM") || cond.Equals("S") || cond.Equals("Y") || cond.Equals("YES"))
{
    Console.WriteLine("\n--------Cadastrar um Candidato--------");
    Console.WriteLine("Qual o Nome do Candidato?");
    nomeCandidato = Console.ReadLine();
    Console.WriteLine("Qual a Idade do Candidato?");
    idadeCandidato = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual Sexo do Candidato? (Masculino/Feminino/M/F)");
    sexoCandidato = Console.ReadLine().ToUpper();
    Console.WriteLine("Qual o nível de escolaridade do Candidato? \n(Ensino Fundamental/Medio/Superior/Pós-Graduação)\n(EF/EM/ES/EPG)");
    Console.Write("Resposta: ");
    escolaCandidato = Console.ReadLine().ToUpper();
    Console.WriteLine("o Candidado possui alguma experiência? (S/N/Sim/Nao)");
    exper = Console.ReadLine().ToUpper();

    if (escolaCandidato.Equals("ENSINO FUNDAMENTAL") || escolaCandidato.Equals("EF"))
	{
        ef++;
	}
    if (escolaCandidato.Equals("ENSINO MEDIO") || escolaCandidato.Equals("EM"))
	{
        em++;
	}
    if (escolaCandidato.Equals("ENSINO SUPERIOR") || escolaCandidato.Equals("ES"))
	{
        es++;
	}
    if (escolaCandidato.Equals("ENSINO POS-GRADUACAO") || escolaCandidato.Equals("EPG"))
	{
        epg++;
	}

    if(sexoCandidato.Equals("MASCULINO") || sexoCandidato.Equals("M"))
    {
        contmasc++;
        if (exper.Equals("SIM")||exper.Equals("S"))
    	{
            exper = "SIM";
            contMascExp++;
            idadeMediaH += idadeCandidato;
        }else exper = "NÃO";
        if (34<idadeCandidato && idadeCandidato<46)
	    {
            contHomem35_45++;

    	}
        if (contmasc == 1)
	    {
            resposta = "\n- Ficha do Candidato "+nomeCandidato" -\n"+
                       "* idade: "+idadeCandidato+" anos\n"+
                       "* sexo: Masculino\n"+
                       "* escolaridade: "+escolaCandidato+"\n"+
                       "* Possui Experiencia: "+exper+"\n";
        }
        else
        {
            resposta += "\n- Ficha do Candidato "+nomeCandidato" -\n"+
                       "* idade: "+idadeCandidato+" anos\n"+
                       "* sexo: Masculino\n"+
                       "* escolaridade: "+escolaCandidato+"\n"+
                       "* Possui Experiencia: "+exper+"\n";
        }
	}
    }else if(sexoCandidato.Equals("FEMININO") || sexoCandidato.Equals("F"))
    {
        contfem++;
        if (exper.Equals("SIM")||exper.Equals("S"))
    	{
            exper = "SIM";
            contFemExp++;
            idadeMediaF += idadeCandidato;
            if (contFemExp = 1)
	        {
                menoridadefem = idadeCandidato;
        	}
            if (idadeCandidato < menoridadefem)
	        {
                menoridadefem = idadeCandidato;
        	}
        }else exper = "NÃO";
        if (contfem == 1)
	    {
            resposta = "\n- Ficha da Candidata "+nomeCandidato" -\n"+
                       "* idade: "+idadeCandidato+" anos\n"+
                       "* sexo: Feminino\n"+
                       "* escolaridade: "+escolaCandidato+"\n"+
                       "* Possui Experiencia: "+exper+"\n";
        }
        else
        {
            resposta += "\n- Ficha da Candidata "+nomeCandidato" -\n"+
                       "* idade: "+idadeCandidato+" anos\n"+
                       "* sexo: Feminino\n"+
                       "* escolaridade: "+escolaCandidato+"\n"+
                       "* Possui Experiencia: "+exper+"\n";
        }
    }
    else
    {
        Console.WriteLine("Seu sexo não é reconhecido pelo sistema, seu cadastro foi anulado!");
    }

    idadeMediaH = idadeMediaH/contMascExp;
    idadeMediaF = idadeMediaF/contFemExp;
    porcHomens35_45 = (double) contHomem35_45/contmasc;
    porcHomens35_45 = porcHomens35_45*100;

    Console.Write("\n Deseja continuar o Cadastro de outro candidato?(sim/nao/s/n/yes/no/y/n)");
    cond = Console.ReadLine().ToUpper();

}
Console.WriteLine("\n!! Obrigado por Cadastrar os Candidatos !!\n"+
                  "# Lista dos participantes:"+resposta+
                  "\n# Relatório Dos Candidatos Cadastrados:\n"+
                  "- numero de candidatos do sexo feminino: "+contfem+"\n"+
                  "- numero de candidatos do sexo masculino: "+contmasc+"\n"+
                  "- idade media dos homens com experiencia: "+idadeMediaH+"\n"+
                  "- idade media das mulheres com experiencia: "+idadeMediaF+"\n"+
                  "- porcentagem dos homens entre 35 e 45 anos: "+porcHomens35_45+"\n"+
                  "- menor idade entre as mulheres que ja tem experiencia no serviço: "+menoridadefem+"\n"+
                  "- nivel de escolaridade dos candidatos:\n"+
                  "  = ensino fundamental: "+ef+"\n"+
                  "  = ensino medio: "+em+"\n"+
                  "  = ensino superior: "+es+"\n"+
                  "  = ensino pós-graduação: "+epg);