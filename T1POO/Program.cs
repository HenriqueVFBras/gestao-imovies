using System;
using System.Collections.Generic;

class Program
{
    static List<Imovel> imoveis = new List<Imovel>();
    static List<Distrito> distritos = new List<Distrito>();
    static List<Concelho> concelhos = new List<Concelho>();
    static List<Freguesia> freguesias = new List<Freguesia>();
    static List<Senhorio> senhorios = new List<Senhorio>();
    static List<Inquilino> inquilinos = new List<Inquilino>();
    static List<Contrato> contratos = new List<Contrato>();
    static List<Recibo> recibos = new List<Recibo>();
    static List<Documento> documentos = new List<Documento>();
    static List<Despesa> despesas = new List<Despesa>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1   Imoveis");
            Console.WriteLine("2.  Distritos");
            Console.WriteLine("3.  Concelhos");
            Console.WriteLine("4.  Freguesias");
            Console.WriteLine("5.  Senhorios");
            Console.WriteLine("6.  Inquilinos");
            Console.WriteLine("7.  Contratos");
            Console.WriteLine("8.  Recibos");
            Console.WriteLine("9.  Documentos");
            Console.WriteLine("10. Despesa");
            Console.WriteLine("0.  Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ManageImoveis<Imovel>(imoveis, "Imoveis");
                    break;
                    static void ManageImoveis<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddImovel(imoveis);
                                    break;
                                case "2":
                                    ViewImoveis(imoveis);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddImovel(List<Imovel> imoveis)
                    {
                        Console.WriteLine("Enter Imovel Details:");

                        Console.Write("Imovel ID: ");
                        int imovelId = int.Parse(Console.ReadLine());

                        Console.Write("Tipo: ");
                        string tipo = Console.ReadLine();

                        Console.Write("Endereço: ");
                        string endereco = Console.ReadLine();

                        Imovel imovel = new Imovel
                        {
                            ImovelId = imovelId,
                            Tipo = tipo,
                            Endereco = endereco
                        };

                        imoveis.Add(imovel);

                        Console.WriteLine("Imovel added successfully!");
                    }

                    static void ViewImoveis(List<Imovel> imoveis)
                    {
                        Console.WriteLine("Imoveis:");

                        foreach (var imovel in imoveis)
                        {
                            Console.WriteLine($"Imovel ID: {imovel.ImovelId}, Tipo: {imovel.Tipo}, Endereço: {imovel.Endereco}");
                        }
                    }
                case "2":
                    ManageDistritos<Distrito>(distritos, "Distritos");
                    break;
                    static void ManageDistritos<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddDistrito(distritos);
                                    break;
                                case "2":
                                    ViewDistrito(distritos);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddDistrito(List<Distrito> distritos)
                    {
                        Console.WriteLine("Enter Imovel Details:");

                        Console.Write("Distrito ID: ");
                        int distritoId = int.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();


                        Distrito distrito = new Distrito
                        {
                            DistritoId = distritoId,
                            Nome = nome,
                        };

                        distritos.Add(distrito);

                        Console.WriteLine("Distrito added successfully!");
                    }

                    static void ViewDistrito(List<Distrito> distritos)
                    {
                        Console.WriteLine("Distritos:");

                        foreach (var distrito in distritos)
                        {
                            Console.WriteLine($"Distrito ID: {distrito.DistritoId}, Nome: {distrito.Nome}");
                        }
                    }
                    break;
            case "3":
                ManageConcelhos<Concelho>(concelhos, "Concelhos");
                break;

                static void ManageConcelhos<T>(List<T> items, string className)
                {
                    while (true)
                    {
                        Console.WriteLine($"1. Add {className}");
                        Console.WriteLine($"2. View {className}");
                        Console.WriteLine($"3. Back to Main Menu");
                        Console.Write($"Enter your choice for {className}: ");

                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                AddConcelho(concelhos);
                                break;
                            case "2":
                                ViewConcelho(concelhos);
                                break;
                            case "3":
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                }

                static void AddConcelho(List<Concelho> concelhos)
                {
                    Console.WriteLine("Enter Concelho Details:");

                    Console.Write("Concelho ID: ");
                    int concelhoId = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Distrito ID: ");
                    int distritoId = int.Parse(Console.ReadLine());

                    Concelho concelho = new Concelho
                    {
                        ConcelhoId = concelhoId,
                        Nome = nome,
                        DistritoId = distritoId,
                    };

                    concelhos.Add(concelho);

                    Console.WriteLine("Concelho added successfully!");
                }

                static void ViewConcelho(List<Concelho> concelhos)
                {
                    Console.WriteLine("Concelhos:");

                    foreach (var concelho in concelhos)
                    {
                        Console.WriteLine($"Concelho ID: {concelho.ConcelhoId}, Nome: {concelho.Nome}, Distrito ID: {concelho.DistritoId}");
                    }
                }

                break;
                case "4":
                    ManageFreguesias<Freguesia>(freguesias, "Freguesias");
                    break;


                    static void ManageFreguesias<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddFreguesia(freguesias);
                                    break;
                                case "2":
                                    ViewFreguesia(freguesias);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddFreguesia(List<Freguesia> freguesias)
                    {
                        Console.WriteLine("Enter Freguesia Details:");

                        Console.Write("Freguesia ID: ");
                        int freguesiaId = int.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Concelho ID: ");
                        int concelhoId = int.Parse(Console.ReadLine());

                        Freguesia freguesia = new Freguesia
                        {
                            FreguesiaId = freguesiaId,
                            Nome = nome,
                            ConcelhoId = concelhoId,
                        };

                        freguesias.Add(freguesia);

                        Console.WriteLine("Freguesia added successfully!");
                    }

                    static void ViewFreguesia(List<Freguesia> freguesias)
                    {
                        Console.WriteLine("Freguesias:");

                        foreach (var freguesia in freguesias)
                        {
                            Console.WriteLine($"Freguesia ID: {freguesia.FreguesiaId}, Nome: {freguesia.Nome}, Concelho ID: {freguesia.ConcelhoId}");
                        }
                    }

                    break;
                case "5":
                    ManageSenhorios<Senhorio>(senhorios, "Senhorios");
                    break;


                    static void ManageSenhorios<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddSenhorio(senhorios);
                                    break;
                                case "2":
                                    ViewSenhorio(senhorios);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddSenhorio(List<Senhorio> senhorios)
                    {
                        Console.WriteLine("Enter Senhorio Details:");

                        Console.Write("Senhorio ID: ");
                        int senhorioId = int.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Senhorio senhorio = new Senhorio
                        {
                            SenhorioId = senhorioId,
                            Nome = nome,
                            Email = email,
                        };

                        senhorios.Add(senhorio);

                        Console.WriteLine("Senhorio added successfully!");
                    }

                    static void ViewSenhorio(List<Senhorio> senhorios)
                    {
                        Console.WriteLine("Senhorios:");

                        foreach (var senhorio in senhorios)
                        {
                            Console.WriteLine($"Senhorio ID: {senhorio.SenhorioId}, Nome: {senhorio.Nome}, Email: {senhorio.Email}");
                        }
                    }

                    break;
                case "6":
                    ManageInquilinos<Inquilino>(inquilinos, "Inquilinos");
                    break;

                    static void ManageInquilinos<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddInquilino(inquilinos);
                                    break;
                                case "2":
                                    ViewInquilino(inquilinos);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddInquilino(List<Inquilino> inquilinos)
                    {
                        Console.WriteLine("Enter Inquilino Details:");

                        Console.Write("Inquilino ID: ");
                        int inquilinoId = int.Parse(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Inquilino inquilino = new Inquilino
                        {
                            InquilinoId = inquilinoId,
                            Nome = nome,
                            Email = email,
                        };

                        inquilinos.Add(inquilino);

                        Console.WriteLine("Inquilino added successfully!");
                    }

                    static void ViewInquilino(List<Inquilino> inquilinos)
                    {
                        Console.WriteLine("Inquilinos:");

                        foreach (var inquilino in inquilinos)
                        {
                            Console.WriteLine($"Inquilino ID: {inquilino.InquilinoId}, Nome: {inquilino.Nome}, Email: {inquilino.Email}");
                        }
                    }

                    break;
                case "7":
                    ManageContratos<Contrato>(contratos, "Contratos");
                    break;

                    // ...

                    static void ManageContratos<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddContrato(contratos);
                                    break;
                                case "2":
                                    ViewContrato(contratos);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddContrato(List<Contrato> contratos)
                    {
                        Console.WriteLine("Enter Contrato Details:");

                        Console.Write("Contrato ID: ");
                        int contratoId = int.Parse(Console.ReadLine());

                        Console.Write("Inquilino ID: ");
                        int inquilinoId = int.Parse(Console.ReadLine());

                        Console.Write("Imovel ID: ");
                        int imovelId = int.Parse(Console.ReadLine());

                        Console.Write("Data Inicio (MM/DD/YYYY): ");
                        DateTime dataInicio = DateTime.Parse(Console.ReadLine());

                        Console.Write("Data Fim (MM/DD/YYYY): ");
                        DateTime dataFim = DateTime.Parse(Console.ReadLine());

                        Contrato contrato = new Contrato
                        {
                            ContratoId = contratoId,
                            InquilinoId = inquilinoId,
                            ImovelId = imovelId,
                            DataInicio = dataInicio,
                            DataFim = dataFim,
                        };

                        contratos.Add(contrato);

                        Console.WriteLine("Contrato added successfully!");
                    }

                    static void ViewContrato(List<Contrato> contratos)
                    {
                        Console.WriteLine("Contratos:");

                        foreach (var contrato in contratos)
                        {
                            Console.WriteLine($"Contrato ID: {contrato.ContratoId}, Inquilino ID: {contrato.InquilinoId}, Imovel ID: {contrato.ImovelId}, Data Inicio: {contrato.DataInicio}, Data Fim: {contrato.DataFim}");
                        }
                    }

                    break;
                case "8":
                    ManageRecibos<Recibo>(recibos, "Recibos");
                    break;


                    static void ManageRecibos<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddRecibo(recibos);
                                    break;
                                case "2":
                                    ViewRecibo(recibos);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddRecibo(List<Recibo> recibos)
                    {
                        Console.WriteLine("Enter Recibo Details:");

                        Console.Write("Recibo ID: ");
                        int reciboId = int.Parse(Console.ReadLine());

                        Console.Write("Inquilino ID: ");
                        int inquilinoId = int.Parse(Console.ReadLine());

                        Console.Write("Imovel ID: ");
                        int imovelId = int.Parse(Console.ReadLine());

                        Console.Write("Valor: ");
                        decimal valor = decimal.Parse(Console.ReadLine());

                        Console.Write("Data Emissao (MM/DD/YYYY): ");
                        DateTime dataEmissao = DateTime.Parse(Console.ReadLine());

                        Recibo recibo = new Recibo
                        {
                            ReciboId = reciboId,
                            InquilinoId = inquilinoId,
                            ImovelId = imovelId,
                            Valor = valor,
                            DataEmissao = dataEmissao,
                        };

                        recibos.Add(recibo);

                        Console.WriteLine("Recibo added successfully!");
                    }

                    static void ViewRecibo(List<Recibo> recibos)
                    {
                        Console.WriteLine("Recibos:");

                        foreach (var recibo in recibos)
                        {
                            Console.WriteLine($"Recibo ID: {recibo.ReciboId}, Inquilino ID: {recibo.InquilinoId}, Imovel ID: {recibo.ImovelId}, Valor: {recibo.Valor}, Data Emissao: {recibo.DataEmissao}");
                        }
                    }

                    break;
                case "9":
                    ManageDocumentos<Documento>(documentos, "Documentos");
                    break;

                    // ...

                    static void ManageDocumentos<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddDocumento(documentos);
                                    break;
                                case "2":
                                    ViewDocumento(documentos);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddDocumento(List<Documento> documentos)
                    {
                        Console.WriteLine("Enter Documento Details:");

                        Console.Write("Documento ID: ");
                        int documentoId = int.Parse(Console.ReadLine());

                        Console.Write("Imovel ID: ");
                        int imovelId = int.Parse(Console.ReadLine());

                        Console.Write("Tipo: ");
                        string tipo = Console.ReadLine();

                        Console.Write("Caminho: ");
                        string caminho = Console.ReadLine();

                        Documento documento = new Documento
                        {
                            DocumentoId = documentoId,
                            ImovelId = imovelId,
                            Tipo = tipo,
                            Caminho = caminho,
                        };

                        documentos.Add(documento);

                        Console.WriteLine("Documento added successfully!");
                    }

                    static void ViewDocumento(List<Documento> documentos)
                    {
                        Console.WriteLine("Documentos:");

                        foreach (var documento in documentos)
                        {
                            Console.WriteLine($"Documento ID: {documento.DocumentoId}, Imovel ID: {documento.ImovelId}, Tipo: {documento.Tipo}, Caminho: {documento.Caminho}");
                        }
                    }

                    break;
                case "10":
                    ManageDespesas<Despesa>(despesas, "Despesas");
                    break;

                    // ...

                    static void ManageDespesas<T>(List<T> items, string className)
                    {
                        while (true)
                        {
                            Console.WriteLine($"1. Add {className}");
                            Console.WriteLine($"2. View {className}");
                            Console.WriteLine($"3. Back to Main Menu");
                            Console.Write($"Enter your choice for {className}: ");

                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    AddDespesa(despesas);
                                    break;
                                case "2":
                                    ViewDespesa(despesas);
                                    break;
                                case "3":
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    break;
                            }
                        }
                    }

                    static void AddDespesa(List<Despesa> despesas)
                    {
                        Console.WriteLine("Enter Despesa Details:");

                        Console.Write("Despesa ID: ");
                        int despesaId = int.Parse(Console.ReadLine());

                        Console.Write("Imovel ID: ");
                        int imovelId = int.Parse(Console.ReadLine());

                        Console.Write("Valor: ");
                        decimal valor = decimal.Parse(Console.ReadLine());

                        Console.Write("Descrição: ");
                        string descricao = Console.ReadLine();

                        Despesa despesa = new Despesa
                        {
                            DespesaId = despesaId,
                            ImovelId = imovelId,
                            Valor = valor,
                            Descricao = descricao,
                        };

                        despesas.Add(despesa);

                        Console.WriteLine("Despesa added successfully!");
                    }

                    static void ViewDespesa(List<Despesa> despesas)
                    {
                        Console.WriteLine("Despesas:");

                        foreach (var despesa in despesas)
                        {
                            Console.WriteLine($"Despesa ID: {despesa.DespesaId}, Imovel ID: {despesa.ImovelId}, Valor: {despesa.Valor}, Descrição: {despesa.Descricao}");
                        }
                    }

                    break;

                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
    


