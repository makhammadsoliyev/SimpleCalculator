string expression;
decimal result;
char[] separators = { '-', '+', '*', '/', '%', ':' };

Console.WriteLine("Welcome to Simple Calculator!");
expression = Console.ReadLine().Trim();

string[] arrayOfExpression = expression.Split(separators, StringSplitOptions.TrimEntries);

decimal firstNum = decimal.Parse(arrayOfExpression[0]);
decimal secondNum = decimal.Parse(arrayOfExpression[1]);

char theOperator = expression[expression.IndexOfAny(separators)];

result = theOperator switch
{
    '+' => firstNum + secondNum,
    '-' => firstNum - secondNum,
    '/' => firstNum / secondNum,
    ':' => firstNum / secondNum,
    '%' => firstNum % secondNum,
    '*' => firstNum * secondNum
};

Console.WriteLine(result);
