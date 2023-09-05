namespace aplicativo_wb_co.Configuration
{
    public class RetornoApiCustomizado<T>
    {


        public bool Sucesso { get; set; }


        public T Dados { get; set; }

        public string Mensagem { get; set; }

        public int Status { get; set; }

    }
}
