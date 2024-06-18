using decorator.App;

namespace decorator;

static class Program
{
	public static void Main(string[] args)
	{
		IStreamReader fileReader = new ConcreteFileReaderComponent("Assets/example.txt");

		IStreamReader loggingReader = new LoggingStreamReaderConcreteDecorator(fileReader);
		IStreamReader filteredReadr = new EmptyLineFilterStreamReaderDecorator(loggingReader);

		// IStreamReader filteredReadr = new EmptyLineFilterStreamReaderDecorator(fileReader);
		// IStreamReader loggingReader = new LoggingStreamReaderConcreteDecorator(filteredReadr);

		String? line;
		while ((line = loggingReader.ReadLine()) is not null)
		// while ((line = filteredReadr.ReadLine()) is not null)
		{
			Console.WriteLine($"👉 Ligne actuelle : {line}\n");
		}
	}
}
