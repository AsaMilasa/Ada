using System.Text;

namespace Ada 
{
    class Shaula //CON SUFICIENTE PROSPERA
    {
        public const byte vacio = 0b00000000;  //vacio o algo asi 
        static List<int> var_int = new List<int>();
        static List<string> var_str = new List<string>();
        static List<decimal> var_dec = new List<decimal>();
        static List<string> var_name = new List<string>();
        static List<int> var_dir = new List<int>();
        static List<int> var_type = new List<int>();
        static void crear_var(string name, int elint)
        {
            int largo = var_int.Count;
            var_name.Add(name); 
            var_dir.Add(largo);
            var_int.Add(elint);
            var_type.Add(1);
        }
        static void crear_var(string name, string elstr)
        {
            
            int largo = var_str.Count;
            var_name.Add(name);
            var_dir.Add(largo);
            var_str.Add(elstr);
            var_type.Add(2);
        }
        decimal hey = 0.003m;
        static void cambiar_var(string name, dynamic newvalor, decimal hola)
        {
            for (int i = 0; i < var_name.Count; i++)
            {
                if (var_name[i] == name)
                {
                    switch (var_type[i])
                    {
                        case 1: var_int[var_dir[i]] = newvalor; break;
                        case 2: var_str[var_dir[i]] = newvalor; break;
                        case 3: var_dec[var_dir[i]] = hola; break;
                    }
                }
            }
        }
        static string txtin;
        static string txt_sec;
        static List<string> palabs = new List<string>(); //texto
        static void Main(string[] args)
        {
            if (args.Length == 0) { return; }
            txtin = args[0];
            recon_PM(txtin);
        }
        #region primer proceso
        static void recon_PM (string texto)
       {
            bool comillas = false;
            var constru_1 = new StringBuilder();
            int actchar = 0;
            for (int i = actchar; i < texto.Length; i++)
            {
                switch (texto[i])//"  " 
                {
                    case '"':
                        comillas = !comillas;
                        constru_1.Append(texto[i]);
                        break;
                    case ' ':
                        if (comillas)
                        {
                            constru_1.Append(texto[i]);
                        }
                        else
                        {
                            if (constru_1.Length > 0)
                            {
                                agrp(constru_1.ToString());
                                constru_1.Length = 0;
                            }
                        }
                        break;
                    case ';':
                    case '{':
                    case '}':
                    case '(':
                    case ')':
                    case '[':
                    case ']':
                    case ',':
                        if (comillas)
                        {
                            constru_1.Append(texto[i]);
                            break;
                        }
                        else
                        {
                            if (constru_1.Length > 0)
                            {
                                agrp(constru_1.ToString());
                                constru_1.Length = 0;
                            }
                            agrp(texto[i].ToString());
                            break;
                        }
                    default: constru_1.Append(texto[i]); break;
                }
            }
            if (constru_1.Length > 0)
            {
                agrp(constru_1.ToString());
            }
        }

        static void agrp(string agregar)
        {
            palabs.Add(agregar);
        }
        #endregion
        //algo aqui cuidadete

        //terminado el primer proceso ahora viene el segundo

        #region segundo proceso
        static void exec_SM()
        {
            int poss = 0;
            int large = palabs.Count;
            for (int i = 0; i < large; i++)
            {
            }
        }

        #endregion


        static string plusstr(params string[] mistr)
        {
            var constru_str = new StringBuilder();
            string mistring = "";
            int largo = mistr.Length;
            for (int i = 0; i < largo; i++)
            {
                constru_str.Append(mistr[i]);
            }
            mistring = constru_str.ToString();
            return mistring;
        }
    }
}