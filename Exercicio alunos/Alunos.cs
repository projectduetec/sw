namespace ExercicioAlunos;
class Alunos
{
    public string nome="";
    public double nota1, nota2;

    //MEDIA

    public double obterMedia(){
        double media = (nota1 + nota2)/2;
        return media;

    }

    //SITUACAO

    public string obterSituacao(double media){
      string situacao="";
      if(media>=6){
        situacao="Aprovado";
         }else{
            situacao="Reprovado";
         } 
         return situacao;
    }

    //MENSAGEM

    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao =  obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resultadoSituacao+" com média: "+mediaCalculada);
         }
    }


