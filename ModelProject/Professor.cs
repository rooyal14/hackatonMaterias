namespace ModelProject
{
    public class Professor
    {
        private string id;
        private Preferencia[] preferencias;


        //método construtor da classe
        public Professor(string id)
        {
            this.id = id;
            //define o número máximo de escolhas de preferência disponível para cada fator de escolha.
            int numeroDePrefencias = 3;
            this.preferencias = new Preferencia[numeroDePrefencias];
            for (int i = 0; i < numeroDePrefencias; i++)
            {
                preferencias[i] = new Preferencia();
            }

        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Preferencia[] Preferencias
        {
            get { return preferencias; }
            set { preferencias = value; }
        }


    }
}
