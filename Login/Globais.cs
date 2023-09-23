using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; // 0=Básico - 1=Gerente - 2=Master
        public static string status = "B";
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_dados.db";
        public static string caminhoBanco = caminho+@"\banco\";
        public static string cidade = "";
        public static string uf = "";
        public static int linhasUsuarios = 0;
        public static int linhasFornecedos = 0;
    }
}
