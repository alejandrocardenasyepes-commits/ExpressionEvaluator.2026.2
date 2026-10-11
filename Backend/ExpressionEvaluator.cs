using System.Globalization;

namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix) => EvalutePostfix(ToPostfix(infix));

    private static string ToPostfix(string infix)
    {
        var posfix = string.Empty;
        var stack = new Stack<char>();
        foreach (var item in infix)
        {
            if (IsOperator(item))
            {
                posfix += ' '; // separa los números
                if (item == ')')
                {
                    var ope = stack.Pop();
                    while (ope != '(')
                    {
                        posfix += ope;
                        ope = stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count > 0 && PriorityInfix(item) <= PriorityStack(stack.Peek()))
                    {
                        posfix += stack.Pop();
                    }
                    stack.Push(item);
                }
            }
            else
            {
                posfix += item;
            }
        }
        do
        {
            posfix += stack.Pop();
        } while (stack.Count != 0);
        return posfix;
    }

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static bool IsOperator(char item) => item == '^' || item == '*' || item == '/' || item == '+' || item == '-' || item == '(' || item == ')';

    private static double EvalutePostfix(string postfix)
    {
        var stack = new Stack<double>();
        var number = string.Empty;
        foreach (var item in postfix)
        {
            if (char.IsDigit(item) || item == '.')
            {
                number += item;
                continue;
            }

            if (number != string.Empty)
            {
                stack.Push(double.Parse(number, CultureInfo.InvariantCulture));
                number = string.Empty;
            }

            if (IsOperator(item))
            {
                var ope2 = stack.Pop();
                var ope1 = stack.Pop();
                stack.Push(Calculate(ope1, ope2, item));
            }
        }
        return stack.Pop();
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}