namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa_Fisica pf = new Pessoa_Fisica();
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (f) ou Pessoa Juridica (j)");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f")
            {
                //Pessoa Fisica

                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar valor de compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("---------Pessoa Fisica----------");
                Console.WriteLine("Nome:................ " + pf.nome);
                Console.WriteLine("Endereço:............ " + pf.endereco);
                Console.WriteLine("CPF:................. " + pf.cpf);
                Console.WriteLine("RG:.................. " + pf.rg);
                Console.WriteLine("Valor da Compra:..... " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto:............. " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Valor Total.......... " + pf.total.ToString("C"));
                
            }

                if(var_tipo == "j")
                {

            //Pessoa Juridica

                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar valor de compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("---------Pessoa Fisica----------");
                Console.WriteLine("Nome:................ " + pj.nome);
                Console.WriteLine("Endereço:............ " + pj.endereco);
                Console.WriteLine("CPF:................. " + pj.cnpj);
                Console.WriteLine("RG:.................. " + pj.ie);
                Console.WriteLine("Valor da Compra:..... " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto:............. " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Valor Total.......... " + pj.total.ToString("C"));
                }

                }
    }
}