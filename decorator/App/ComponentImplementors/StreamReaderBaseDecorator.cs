namespace decorator.App;

public abstract class StreamReaderBaseDecorator : IStreamReader
{
	protected IStreamReader _decoratedStreamReader;

	public StreamReaderBaseDecorator(IStreamReader decoratedStreamReader)
	{
		_decoratedStreamReader = decoratedStreamReader;
	}

	public virtual String? ReadLine()
	{
		return _decoratedStreamReader.ReadLine();
	}
}
