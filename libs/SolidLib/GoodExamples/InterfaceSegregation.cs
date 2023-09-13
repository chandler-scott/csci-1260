namespace SolidLib_Good;

public interface IReadableFile {
    void ReadFile(string filePath);
}

public interface IWritableFile {
    void WriteFile(string filePath);
}

public interface IEncryptableFile {
    void EncryptFile(string filePath, string encryptionKey);
}

public interface IDecryptableFile {
    void DecryptFile(string filePath, string encryptionKey);
}

