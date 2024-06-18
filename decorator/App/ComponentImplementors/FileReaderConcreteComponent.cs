namespace decorator.App;

public class ConcreteFileReaderComponent : IStreamReader
{
	private StreamReader _streamReader;

	public ConcreteFileReaderComponent(String filePath)
	{
		if (!File.Exists(filePath))
		{
			throw new FileNotFoundException("...");
		}

		_streamReader = new StreamReader(filePath);
	}

	public String? ReadLine()
	{
		return _streamReader.ReadLine();
	}
}
