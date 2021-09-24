# Answers

## Extension Methods

1. Flatten the numbers in `xs`

    ```csharp
    xs.Flatten();
    ```

2. Select numbers in `ys` which are divisible by 7 and greater than 42

    ```csharp
    ys.Filter(y => y % 7 == 0).Filter(y => y > 42);
    ```

3. Selecter numbers in ys which are leap years

    ```csharp
    ys.Filter(y => y.IsLeapYear());
    ```
