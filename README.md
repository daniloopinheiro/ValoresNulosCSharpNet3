# Valores Nulos .Net3

## Processo de construção do projeto

    OBS: Por estarmos usando uma distribuição linux(Ubuntu), utilizaremos arquivo via script para construção do projeto e instalação da versão desta demo.

### Comandos utilizados no terminal

    $ sudo apt install wget 
    $ wget https://dot.net/v1/dotnet-install.sh
    $ chmod +x dotnet-install.sh
    $ ./dotnet-install.sh -c 3.1

### Porjeto global e mais console

    $ dotnet --list-sdks
    $ dotnet new globaljson --sdk-version 3.1.426
    $ dotnet new console -O 'nome-do-projeto-ou-demo'
    
[ref:comando para criar projeto cli .net via terminal](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new) 

#### Executar o projeto

    $ dotnet run

[ref:comando para executar cli .net via terminal](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-run)


https://www.infoworld.com/article/3703048/how-to-handle-null-values-in-c-sharp.html#tk.rss_all
