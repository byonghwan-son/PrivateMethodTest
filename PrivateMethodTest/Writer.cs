using System.Runtime.CompilerServices;
using System.Threading;

namespace PrivateMethodTest {
  public class Writer {
    private string WritePrivate() => "private";
    private string WritePrivate(string text) => $"private {text}";

    private string WritePrivate(int num) => $"private {num}";
  }
}