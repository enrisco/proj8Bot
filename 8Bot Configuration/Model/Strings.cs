using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace _8Bot_Configuration.Model
{
    public class Strings
    {
        public static string formName = "Configurador do 8Bot",
                            titleWelcome = "Bem vindo ao configurador do 8Bot",
                            descWelcome = "Escolha uma das opções abaixo.",
                            _btnConfig = "Configurar",
                            _btnUninstall = "Desinstalar",
                            titleInstall = "Escolha um diretório",
                            descInstall = "Escolha o diretório onde o Grand Theft Auto: San Andreas está instalado.",
                            descExplain = "Use a pasta \"Addons\" para copiar e colar seus mods (lembre-se que todos os arquivos serão automaticamente copiados para a pasta raiz selecionada acima. Se precisar substituir um arquivo que originalmente fica dentro de uma pasta, crie uma nova de mesmo nome e coloque seu arquivo dentro.)",
                            _btnInstall = "Instalar",
                            _btnBack = "Voltar",
                            titleError = "Erro",
                            descError = "Diretório Inexistente.",
                            titleFinally = "Obrigado por usar 8Bot",
                            descFinally1 = "8Bot foi instalado com sucesso, aproveite!",
                            descFinally2 = "8Bot foi desinstalado com sucesso. Obrigado por usar 8Bot.",
                            _btnFinally = "Fechar",
                            titleWarning = "Aviso",
                            descWarning = "Você deseja mesmo desinstalar 8Bot?",
                            titleUninstall = "Desinstalando 8Bot",
                            descUninstall = "Espere um momento.";

        static void Translate(bool isPortuguese)
        {
            if (isPortuguese)
            {
                formName = "Configurador do 8Bot";
                titleWelcome = "Bem vindo ao configurador do 8Bot";
                descWelcome = "Escolha uma das opções abaixo.";
                _btnConfig = "Configurar";
                _btnUninstall = "Desinstalar";
                titleInstall = "Escolha um diretório";
                descInstall = "Escolha o diretório onde o Grand Theft Auto: San Andreas está instalado.";
                descExplain = "Use a pasta \"Addons\" para copiar e colar seus mods (lembre-se que todos os arquivos serão automaticamente copiados para a pasta raiz selecionada acima. Se precisar substituir um arquivo que originalmente fica dentro de uma pasta, crie uma nova de mesmo nome e coloque seu arquivo dentro.)";
                _btnInstall = "Instalar";
                _btnBack = "Voltar";
                titleError = "Erro";
                descError = "Diretório Inexistente.";
                titleFinally = "Obrigado por usar 8Bot";
                descFinally1 = "8Bot foi instalado com sucesso, aproveite!";
                descFinally2 = "8Bot foi desinstalado com sucesso. Obrigado por usar 8Bot.";
                _btnFinally = "Fechar";
                titleWarning = "Aviso";
                descWarning = "Você deseja mesmo desinstalar 8Bot?";
                titleUninstall = "Desinstalando 8Bot";
                descUninstall = "Espere um momento.";
            }
            else
            {
                formName = "8Bot Setup";
                titleWelcome = "Welcome to 8Bot Setup";
                descWelcome = "Choose one of the options below.";
                _btnConfig = "Setup";
                _btnUninstall = "Uninstall";
                titleInstall = "Choose a folder";
                descInstall = "Choose a directory where Grand Theft Auto: San Andreas are installed.";
                descExplain = "Use the folder \"Addons\" to copy and paste your mods (remember that all files will be automatically copied to the selected root folder above. If you need to subwrite a file that is originally inside a folder, create a new with same name and put the file inside.)";
                _btnInstall = "Install";
                _btnBack = "Back";
                titleError = "Error";
                descError = "Directory don't exist.";
                titleFinally = "Thank you for use 8Bot";
                descFinally1 = "8Bot was successfully installed, enjoy!";
                descFinally2 = "8Bot was successfully uninstalled. Thank you for use 8Bot.";
                _btnFinally = "Close";
                titleWarning = "Warning";
                descWarning = "You really want uninstall 8Bot?";
                titleUninstall = "Uninstalling 8Bot";
                descUninstall = "Wait a minute.";
            }
        }

        public static void Checklanguage()
        {
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);
            if (Thread.CurrentThread.CurrentCulture.Name == "pt-BR")
                Translate(true);
            else
                Translate(false);
        }
    }
}
