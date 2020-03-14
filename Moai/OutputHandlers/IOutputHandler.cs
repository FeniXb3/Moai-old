namespace Moai.OutputHandlers
{
  public interface IOutputHandler
  {
    void WriteLine(string text);
    void Clear();
    void WriteAt(int x, int y, char sign);
  }
}