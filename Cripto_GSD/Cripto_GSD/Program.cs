// Importações das bibliotecas necessárias
using System;                    // Tipos e funcionalidades básicas do C#
using System.Collections.Generic; // Listas e coleções genéricas (não usadas diretamente aqui)
using System.Linq;               // Consultas e transformações em coleções (não usadas diretamente aqui)
using System.Threading.Tasks;   // Suporte a programação assíncrona (não usada diretamente aqui)
using System.Windows.Forms;     // Framework Windows Forms — necessário para Application.Run()

// Define o namespace do projeto — agrupa todas as classes relacionadas
namespace Cripto_GSD
{
    // Classe Program — ponto de entrada do aplicativo
    // "internal" = visível apenas dentro deste projeto (não exposta como API pública)
    // "static"   = não precisa ser instanciada — apenas contém métodos de classe
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// Este comentário no formato XML é reconhecido pelo Visual Studio como documentação.
        /// </summary>

        // [STAThread] = Single-Threaded Apartment
        // Obrigatório para aplicações Windows Forms — define que a thread principal
        // usará o modelo de apartamento de thread único, necessário para componentes COM
        // (como diálogos de arquivo, área de transferência, etc.)
        [STAThread]
        static void Main()
        {
            // Ativa os estilos visuais do Windows (bordas arredondadas, temas modernos, etc.)
            // Sem isso, os controles teriam aparência antiga (Windows 95/98)
            Application.EnableVisualStyles();

            // Define que a renderização de texto usa GDI+ padrão em vez do GDI legado
            // "false" = usa o modo moderno de renderização (recomendado para novas aplicações)
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia o loop de mensagens do Windows Forms e abre o formulário principal (Form1)
            // Application.Run() mantém o programa rodando até que o Form1 seja fechado
            // Quando o usuário fecha o Form1, o Application.Run() termina e o programa encerra
            Application.Run(new Form1()); // "new Form1()" cria e exibe a janela principal
        }
    }
}