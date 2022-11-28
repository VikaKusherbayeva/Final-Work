Console.Write("Введите несколько значений через пробел: ");
string[] input = Console.ReadLine().Split();
string[] result = new string[input.Length];

int index = 0;

foreach(var item in input ) {
  if(item.Length <= 3) {
    result[index] = item;
    index++;
  }
}

if(result.Length < 1) {
  Console.WriteLine("Не найдено ни одного результата.");
} else {
  result = result.Where(
    item => !string.IsNullOrEmpty(item)
  ).ToArray();
  
  string output = string.Join(", ", result);
  Console.WriteLine($"Результат: {output}");
}