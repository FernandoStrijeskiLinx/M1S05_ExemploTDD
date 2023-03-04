# Criar projeto de Teste
```dotnet new mstest -o Calculadora.Test```

# Rodar Projeto de Teste 
```dotnet teste Calculadora.Test```

# Criar projeto de Calculadora 
```dotnet new console -o Calculadora```

# Rodar projeto Calculadora 
```dotnet run --project Calculadora```


# Relacionar projeto de teste com o projeto Caluladora
```
cd Calculadora.Test
dotnet add reference ../Calculadora/Calculadora.csproj
cd ..
```
