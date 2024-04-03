public string[] ReadFileLines(string filePath)
{
    if (string.IsNullOrEmpty(filePath))
    {
        throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
    }

    try
    {
        // Read all lines from the file
        return System.IO.File.ReadAllLines(filePath);
    }
    catch (System.IO.FileNotFoundException ex)
    {
        // Handle the case where the file is not found
        Console.WriteLine($"The file was not found: {ex.Message}");
        return new string[0];
    }
    catch (System.IO.IOException ex)
    {
        // Handle other IO errors
        Console.WriteLine($"An IO exception occurred: {ex.Message}");
        return new string[0];
    }
    catch (Exception ex)
    {
        // Handle any other exceptions
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        return new string[0];
    }
}
