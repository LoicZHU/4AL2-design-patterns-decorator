namespace decorator.App;

public class LoggingStreamReaderConcreteDecorator : StreamReaderBaseDecorator
{
	public LoggingStreamReaderConcreteDecorator(IStreamReader decoratedStreamReader)
		: base(decoratedStreamReader) { }

	public override String? ReadLine()
	{
		var line = base.ReadLine();
		this.Log(line);

		return line;
	}

	private void Log(String? message)
	{
		Console.WriteLine($"[LOG] {message}");
	}
}
