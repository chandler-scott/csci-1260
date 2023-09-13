namespace SolidLib_Bad;

/*
* Interface Segregation: 
* Clients should not be forced to depend upon interfaces that they do not use.
*/
public interface FileManager {
	public void ReadFile(string filePath);

	public void WriteFile(string filePath);

	public void EncryptFile(string filePath, string encryptionKey);

	public void DecryptFile(string filePath, string encryptionKey);
}
