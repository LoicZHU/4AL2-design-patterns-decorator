namespace decorator.App;

public class EmptyLineFilterStreamReaderDecorator : StreamReaderBaseDecorator
{
	public EmptyLineFilterStreamReaderDecorator(IStreamReader decoratedStreamReader)
		: base(decoratedStreamReader) { }

	public override String? ReadLine()
	{
		String? line;
		do
		{
			line = base.ReadLine();
		} while (IsWhiteSpace(line));

		return line;
	}

	private static Boolean IsWhiteSpace(String? line)
	{
		return line is not null && String.IsNullOrWhiteSpace(line);
	}
}
