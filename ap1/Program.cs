        bool continuar = true;

        do
        {
            Console.WriteLine("Calculadora de IMC e Idade");

            // Passo 1: Perguntar o nome da pessoa
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            // Passo 2: Perguntar idade, altura e peso
            Console.Write("Digite a idade da pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a altura (em metros) da pessoa: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso (em quilogramas) da pessoa: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            // Passo 3: Calcular o IMC
            double imc = peso / (altura * altura);

            // Passo 4: Determinar a categoria de IMC
            string categoriaImc;
            if (imc < 18.5)
            {
                categoriaImc = "Abaixo do peso";
            }
            else if (imc < 24.9)
            {
                categoriaImc = "Normal";
            }
            else if (imc < 29.9)
            {
                categoriaImc = "Sobrepeso";
            }
            else
            {
                categoriaImc = "Obeso";
            }

            // Passo 5: Determinar a faixa etária da pessoa
            string faixaEtaria;
            if (idade < 12)
            {
                faixaEtaria = "Criança";
            }
            else if (idade < 18)
            {
                faixaEtaria = "Adolescente";
            }
            else if (idade < 60)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            // Passo 6: Gerar o relatório
            Console.WriteLine("\nRelatório:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc}");
            Console.WriteLine($"Categoria de IMC: {categoriaImc}");
            Console.WriteLine($"Faixa Etária: {faixaEtaria}");

            // Perguntar ao usuário se deseja continuar
            Console.Write("\nDeseja gerar um novo relatório? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();
            continuar = (resposta == "S");
        }
        while (continuar);

        Console.WriteLine("O programa foi encerrado.");
