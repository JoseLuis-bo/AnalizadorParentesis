using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalizadorParentesisWinForms.Models;


namespace AnalizadorParentesisWinForms.Core
{
    public class ParenthesisAnalyzer
    {
        public ValidationResult Analyze(string input, bool trace = true)
        {
            var result = new ValidationResult();
            var stack = new Stack<char>();

            if (string.IsNullOrWhiteSpace(input))
            {
                result.IsValid = true;
                result.Message = "Cadena vacía: válida.";
                if (trace) result.Steps.Add("Inicio: cadena vacía → pila vacía.");
                return result;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '(')
                {
                    stack.Push(c);
                    if (trace) result.Steps.Add($"[{i}] PUSH '(' → pila={stack.Count}");
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        result.IsValid = false;
                        result.ErrorIndex = i;
                        result.Message = $"Error: ')' sin '(' en posición {i}.";
                        return result;
                    }
                    stack.Pop();
                    if (trace) result.Steps.Add($"[{i}] POP ')' → pila={stack.Count}");
                }
                else
                {
                    result.IsValid = false;
                    result.ErrorIndex = i;
                    result.Message = $"Carácter inválido '{c}' en posición {i}.";
                    return result;
                }
            }

            if (stack.Count == 0)
            {
                result.IsValid = true;
                result.Message = "Correcto: pila vacía al final.";
            }
            else
            {
                result.IsValid = false;
                result.Message = $"Error: quedaron {stack.Count} '(' sin cerrar.";
            }

            return result;
        }
    }
}