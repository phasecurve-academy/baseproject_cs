### Fizz Buzz

Using TDD create an algorithm that will print out the string representation of a number .
1. If the number is a multiple of 3 then it should print "Fizz" instead
2. If it is a multiple of 5 then should print "Buzz" instead.
3. If it is a multiple of 3 and 5 then should print "FizzBuzz" instead.

Examples:

- `1` returns `"1"`
- `2` returns `"2"`
- `3` returns `"Fizz"`
- `5` returns `"Buzz"`
- `6` returns `"Fizz"`
- `10` returns `"Buzz"`
- `15` returns `"FizzBuzz"`

Pseudooode:

```
BEGIN function "Converter" with INPUT num:
  IF num is divisible by 3 and 5:
    RETURN "FizzBuzz"
  IF num is divisible by 5:
    RETURN "Buzz"
  IF num is divisible by 3:
    RETURN "Fizz"
  VARIABLE fizz_buzz_string = CONVERT_TO_STRING num
  RETURN fizz_buzz_string
END function
```
